using CoreOSC;
using CoreOSC.IO;

namespace TwitchVrcAvatarOSC
{
    public class OscActions : BackgroundService
    {
        static UdpClient _client;
        static IPEndPoint _endpoint;

        public static ConcurrentDictionary<string, Queue<OscOutAction>> ActionsQueue = new ConcurrentDictionary<string, Queue<OscOutAction>>();

        public ConcurrentDictionary<string, OscOutAction> CurrentlyRunningActions = new ConcurrentDictionary<string, OscOutAction>();

        public static void EnqueueAction(OscOutAction action)
        {
            Logger.Debug("OsrActions", $"Add new action {action.ActionName} to queue.", Color.Yellow, Color.White);
            if (ActionsQueue.TryGetValue(action.ActionName, out Queue<OscOutAction> queue))
                queue.Enqueue(action);
            else
                ActionsQueue.TryAdd(action.ActionName, new Queue<OscOutAction>(new[] {action}));
        }

        private async Task SendOcsData(string action, object obj)
        {
            if (obj is int _int)
                await _client.SendMessageAsync(new OscMessage(new Address(action), new object[] { _int }));
            else if (obj is long _long)
                await _client.SendMessageAsync(new OscMessage(new Address(action), new object[] { (int)_long }));
            else if (obj is double _double)
                await _client.SendMessageAsync(new OscMessage(new Address(action), new object[] { (float)_double }));
            else if (obj is bool _bool)
                await _client.SendMessageAsync(new OscMessage(new Address(action), new object[] { _bool }));
        }

        public async Task TryExecuting()
        {
            foreach(var action in ActionsQueue)
            {
                if (action.Value.Count == 0)
                {
                    ActionsQueue.TryRemove(action.Key, out _);
                    continue;
                }

                if (!CurrentlyRunningActions.ContainsKey(action.Key))
                {
                    var newAction = action.Value.Dequeue();

                    if (newAction.Value != null)
                    {
                        await SendOcsData(action.Key, newAction.Value);
                        Logger.Debug("OscActions", $"On execution start send value {newAction.Value} ({newAction.Value.GetType().FullName}) for action {newAction.ActionName}", Color.Yellow, Color.White);
                    }

                    newAction.AssignedTime = DateTime.Now;
                    Logger.Debug("OscActions", $"Execution time for action {action.Key} ends in {(int)(newAction.ExecutionTime - DateTime.Now).TotalSeconds} seconds", Color.Yellow, Color.White);
                    CurrentlyRunningActions.TryAdd(action.Key, newAction);
                }
            }

            foreach(var running in CurrentlyRunningActions)
            {
                if (running.Value.ExecutionTime < DateTime.Now)
                {
                    if (running.Value.DefaultValue != null)
                    {
                        await SendOcsData(running.Key, running.Value.DefaultValue);
                        Logger.Debug("OscActions", $"On execution end send default value {running.Value.DefaultValue} for action {running.Key}", Color.Yellow, Color.White);
                    }
                    Logger.Debug("OscActions", $"Execution time for action {running.Key} ended.", Color.Yellow, Color.White);
                    CurrentlyRunningActions.TryRemove(running.Key, out _);
                }
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _client = new UdpClient();
            _endpoint = new IPEndPoint(IPAddress.Parse(Config.Instance.VrcOscServer.IP), Config.Instance.VrcOscServer.Port);
            Logger.Info("OsrClient", $"Connect udp client to IP: {Config.Instance.VrcOscServer.IP}, Port: {Config.Instance.VrcOscServer.Port}.", Color.Yellow, Color.White);
            _client.Connect(_endpoint);

            while (true)
            {
                try
                {
                    await TryExecuting();
                }
                catch (Exception ex)
                {
                    Logger.Error("OsrClient", ex.Message, Color.Yellow, Color.White);
                }
                await Task.Delay(50);
            }
        }
    }
}
