namespace TwitchVrcAvatarOSC.Bot
{
    using TwitchLib.Api;
    using TwitchLib.Client;
    using TwitchLib.Client.Models;
    using TwitchLib.Communication.Clients;
    using TwitchLib.Communication.Models;
    using TwitchLib.PubSub;
    using TwitchVrcAvatarOSC.Models;

    public class TwitchBot
    {
        public static Random rng;

        public TwitchAPI? api;
        public TwitchClient? client;
        public TwitchPubSub? tPubSub;
        TwitchEventHandlers? eventHandlers;

        public TwitchBot(string nickName, string oauthToken, string channelName)
        {
            rng = new Random();

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

            eventHandlers = new TwitchEventHandlers(this);

            client.OnLog += eventHandlers.OnClientLog;
            client.OnMessageReceived += eventHandlers.OnMessageReceived;
            client.OnNewSubscriber += eventHandlers.OnNewSubscriber;
            client.OnReSubscriber += eventHandlers.OnReSubscriber;
            client.OnBeingHosted += eventHandlers.OnBeingHosted;
            client.OnUserTimedout += eventHandlers.OnUserTimedout;
            client.OnUserBanned += eventHandlers.OnUserBanned;
            client.OnConnected += eventHandlers.OnConnected;

            client.Connect();

            tPubSub = new TwitchPubSub();
            tPubSub.OnListenResponse += eventHandlers.OnListenResponse;

            tPubSub.OnFollow += eventHandlers.OnFollow;
            tPubSub.OnPubSubServiceClosed += eventHandlers.OnPubSubServiceClosed;
            tPubSub.OnPubSubServiceError += eventHandlers.OnPubSubServiceError;
            tPubSub.OnPubSubServiceConnected += eventHandlers.OnPubSubServiceConnected;

            tPubSub.ListenToFollows(Config.Instance.ChannelID);

            tPubSub.Connect();

        }
    }
}
