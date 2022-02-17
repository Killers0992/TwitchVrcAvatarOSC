namespace TwitchVrcAvatarOSC.Bot
{
    using TwitchLib.Client;
    using TwitchLib.Client.Models;
    using TwitchLib.Communication.Clients;
    using TwitchLib.Communication.Models;

    public class TwitchBot
    {
        TwitchClient? client;
        TwitchEventHandlers? eventHandlers;

        public TwitchBot(string nickName, string oauthToken, string channelName)
        {
            ConnectionCredentials credentials = new ConnectionCredentials(nickName, oauthToken);

            var clientOptions = new ClientOptions
            {
                MessagesAllowedInPeriod = 750,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };

            WebSocketClient customClient = new WebSocketClient(clientOptions);
            client = new TwitchClient(customClient);

            if (client == null)
            {
                Logger.Error($"TwitchBot", "Client is null!", ConsoleColor.DarkMagenta);
                return;
            }

            client.Initialize(credentials, channelName);

            eventHandlers = new TwitchEventHandlers();
            client.OnLog += eventHandlers.OnLog;
            client.OnMessageReceived += eventHandlers.OnMessageReceived;
            client.OnNewSubscriber += eventHandlers.OnNewSubscriber;
            client.OnReSubscriber += eventHandlers.OnReSubscriber;
            client.OnBeingHosted += eventHandlers.OnBeingHosted;
            client.OnUserTimedout += eventHandlers.OnUserTimedout;
            client.OnUserBanned += eventHandlers.OnUserBanned;

            client.Connect();
        }
    }
}
