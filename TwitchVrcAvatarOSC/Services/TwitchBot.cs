namespace TwitchVrcAvatarOSC.Services
{
    public class TwitchBot : BackgroundService
    {
        public static Random rng = new Random();
        public static string ClientID => "4jpzwuj55bw2g2ww9sgu8r3wmshlla";
        public static string ChannelID;

        public static string TwitchName;
        public static string ChannelName;

        public TwitchAPI api;
        public TwitchClient client;
        public TwitchPubSub tPubSub;
        TwitchEventHandlers eventHandlers;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            api = new TwitchAPI();
            api.Settings.ClientId = ClientID;

            try
            {
                var user = await api.Helix.Users.GetUsersAsync(accessToken: Config.Instance.TwitchOAuth);
                var firstUser = user.Users.FirstOrDefault();
                if (firstUser != null)
                {
                    ChannelID = firstUser.Id;
                    TwitchName = firstUser.DisplayName;
                    ChannelName = firstUser.Login;
                }
                else
                {
                    Logger.Error($"TwitchBot", "Returned user from oauth token not exists!");
                    return;
                }
            }
            catch (Exception)
            {
                Process.Start(new ProcessStartInfo("http://localhost:3000/twitch/link") { UseShellExecute = true });
                Logger.Log("TwitchBot", "OAuth is invalid, opening browser with twitch login...");
                Logger.Log("TwitchBot", "After login copy token from browser and paste in \"TwitchOAuth\" field in config.json");
                return;
            }

            ConnectionCredentials credentials = new ConnectionCredentials(TwitchName, Config.Instance.TwitchOAuth);

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

            Logger.Log("TwitchBot", "Starting bot...", ConsoleColor.DarkMagenta);
            client.Initialize(credentials, ChannelName);

            eventHandlers = new TwitchEventHandlers(this);

            client.OnLog += eventHandlers.OnClientLog;
            client.OnMessageReceived += eventHandlers.OnMessageReceived;
            client.OnBeingHosted += eventHandlers.OnBeingHosted;
            client.OnUserTimedout += eventHandlers.OnUserTimedout;
            client.OnUserBanned += eventHandlers.OnUserBanned;
            client.OnConnected += eventHandlers.OnConnected;
            client.OnDisconnected += eventHandlers.OnDisconnected;

            Logger.Log("TwitchBot", $"Connect to client with channelname {ChannelName} and twitch nickname {TwitchName}");
            client.Connect();

            tPubSub = new TwitchPubSub();

            tPubSub.OnChannelSubscription += eventHandlers.OnChannelSubscription;
            tPubSub.OnFollow += eventHandlers.OnFollow;
            tPubSub.OnChannelPointsRewardRedeemed += eventHandlers.OnRewardRedeem;

            tPubSub.OnListenResponse += eventHandlers.OnListenResponse;
            tPubSub.OnPubSubServiceClosed += eventHandlers.OnPubSubServiceClosed;
            tPubSub.OnPubSubServiceError += eventHandlers.OnPubSubServiceError;
            tPubSub.OnPubSubServiceConnected += eventHandlers.OnPubSubServiceConnected;

            tPubSub.ListenToSubscriptions(ChannelID);
            tPubSub.ListenToFollows(ChannelID);
            tPubSub.ListenToChannelPoints(ChannelID);

            tPubSub.Connect();

            await Task.Delay(-1);
        }
    }
}
