namespace TwitchVrcAvatarOSC.Services
{
    public class TwitchBot : BackgroundService
    {
        public static Random rng = new Random();
        public static string ClientID => "4jpzwuj55bw2g2ww9sgu8r3wmshlla";
        public static string ChannelID;

        public static string TwitchName;
        public static string ChannelName;

        public static bool IsConnectedToTwitchChat;
        public static bool IsConnectedToTwitchPubSub;

        public static bool WaitingForAction;

        public TwitchAPI api;
        public TwitchClient client;
        public TwitchPubSub tPubSub;
        TwitchEventHandlers eventHandlers;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            api = new TwitchAPI();
            api.Settings.ClientId = ClientID;

            retry:

            while (WaitingForAction)
            {
                await Task.Delay(1000);
            }

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
                    WaitingForAction = true;
                    goto retry;
                }
            }
            catch (Exception)
            {
                var result = MessageBox.Show("OAuth token is invalid, do you want login via twitch?", "Failed connecting to Twitch", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo("http://localhost:3000/twitch/link") { UseShellExecute = true });
                }

                Logger.Info("TwitchBot", "After login copy token from browser and paste in settings tab.", Color.Magenta, Color.White);
                WaitingForAction = true;
                goto retry;
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
                Logger.Error($"TwitchBot", "Client is null!", Color.Magenta, Color.White);
                return;
            }

            Logger.Info("TwitchBot", "Starting...", Color.Magenta, Color.White);
            client.Initialize(credentials, ChannelName);

            eventHandlers = new TwitchEventHandlers(this);

            client.OnLog += eventHandlers.OnClientLog;
            client.OnMessageReceived += eventHandlers.OnMessageReceived;
            client.OnBeingHosted += eventHandlers.OnBeingHosted;
            client.OnUserTimedout += eventHandlers.OnUserTimedout;
            client.OnUserBanned += eventHandlers.OnUserBanned;
            client.OnConnected += eventHandlers.OnConnected;
            client.OnDisconnected += eventHandlers.OnDisconnected;

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
