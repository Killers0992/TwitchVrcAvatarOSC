using OscCore;
using System.Collections.Concurrent;
using TwitchVrcAvatarOSC.Models;

namespace TwitchVrcAvatarOSC
{
    public class OscActions
    {
        static OscClient? _client;

        public static ConcurrentDictionary<string, Queue<OscOutAction>> ActionsQueue = new ConcurrentDictionary<string, Queue<OscOutAction>>();

        public static ConcurrentDictionary<string, OscOutAction> CurrentlyRunningActions = new ConcurrentDictionary<string, OscOutAction>();

        public OscActions(string connectTo, int port, int delayBetweenExecutions = 50)
        {
            Task.Factory.StartNew(async () =>
            {
                _client = new OscClient(connectTo, port);
                while (true)
                {
                    try
                    {
                        TryExecuting();
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("OsrActions", ex.Message, ConsoleColor.White);
                    }
                    await Task.Delay(delayBetweenExecutions);
                }
            });
        }


        public static void EnqueueAction(OscOutAction action)
        {
            Logger.Log("OsrActions", $"Add new action {action.ActionName} to queue.");
            if (ActionsQueue.TryGetValue(action.ActionName, out Queue<OscOutAction> queue))
                queue.Enqueue(action);
            else
                ActionsQueue.TryAdd(action.ActionName, new Queue<OscOutAction>(new[] {action}));
        }

        public static void TryExecuting()
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
                        if (newAction.Value is int integer)
                            _client?.Send(newAction.ActionName, integer);
                        else if (newAction.Value is long lng)
                            _client?.Send(newAction.ActionName, (int)lng);

                        Logger.Log("OscActions", $"On execution start send value {newAction.Value} ({newAction.Value.GetType().FullName}) for action {newAction.ActionName}");

                    }

                    newAction.AssignedTime = DateTime.Now;
                    Logger.Log("OscActions", $"Execution time for action {action.Key} ends in {(int)(newAction.ExecutionTime - DateTime.Now).TotalSeconds} seconds");
                    CurrentlyRunningActions.TryAdd(action.Key, newAction);
                }
            }

            foreach(var running in CurrentlyRunningActions)
            {
                if (running.Value.ExecutionTime < DateTime.Now)
                {
                    if (running.Value.DefaultValue != null)
                    {
                        if (running.Value.DefaultValue is int integer)
                            _client?.Send(running.Value.ActionName, integer);
                        else if (running.Value.DefaultValue is long lng)
                            _client?.Send(running.Value.ActionName, (int)lng);

                        Logger.Log("OscActions", $"On execution end send default value {running.Value.DefaultValue} for action {running.Key}");
                    }
                    Logger.Log("OscActions", $"Execution time for action {running.Key} ended.");
                    CurrentlyRunningActions.TryRemove(running.Key, out _);
                }
            }
        }

    }
}
