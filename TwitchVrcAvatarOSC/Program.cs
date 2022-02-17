namespace TwitchVrcAvatarOSC
{
    using Newtonsoft.Json;
    using TwitchVrcAvatarOSC.Bot;
    using TwitchVrcAvatarOSC.Models;

    public class Program
    {
        public static TwitchBot? Bot;
        public static OscActions? Actions;

        static void Main(string[] args)
        {
            if (!File.Exists("./config.json"))
                File.WriteAllText("./config.json", JsonConvert.SerializeObject(new Config()
                {
                    Events = new TwitchEvents()
                    {
                        OnCommand = new Dictionary<string, TwitchCommand>() { { "test", new TwitchCommand() { OscOutActions = new List<OscOutAction>() { new OscOutAction() } } } },
                        OnBeingHosted = new List<TwitchHost>() { new TwitchHost() { OscOutActions = new List<OscOutAction>() {new OscOutAction() } } },
                        OnNewSubscriber = new List<TwitchNewSub>() { new TwitchNewSub() { OscOutActions = new List<OscOutAction>() { new OscOutAction() }, SubPlans = new List<TwitchLib.Client.Enums.SubscriptionPlan>() { TwitchLib.Client.Enums.SubscriptionPlan.NotSet } } },
                        OnReceiveBits = new List<TwitchBits>() { new TwitchBits() {  OscOutActions = new List<OscOutAction>() { new OscOutAction() } } },
                        OnReSubscriber = new List<TwitchReSub>() { new TwitchReSub() { OscOutActions = new List<OscOutAction>() { new OscOutAction()}, SubPlans = new List<TwitchLib.Client.Enums.SubscriptionPlan>() { TwitchLib.Client.Enums.SubscriptionPlan.NotSet } } },
                        OnReward = new Dictionary<string, TwitchReward>() { { "<REWARD ID>", new TwitchReward() { OscOutActions = new List<OscOutAction>() { new OscOutAction() } } } } ,
                        OnUserBanned = new TwitchBan() { OscOutActions = new List<OscOutAction>() { new OscOutAction()} },
                        OnUserTimedout = new TwitchTimedout() { OscOutActions = new List<OscOutAction>() { new OscOutAction() } }
                    }
                }, Formatting.Indented, new Newtonsoft.Json.Converters.StringEnumConverter()));

            JsonConvert.DeserializeObject<Config>(File.ReadAllText("./config.json"));
            File.WriteAllText("./config.json", JsonConvert.SerializeObject(Config.Instance, Formatting.Indented, new Newtonsoft.Json.Converters.StringEnumConverter()));

            if (Config.Instance == null)
            {
                Logger.Log($"Core", "Config is null! ( config may have wrong format )");
                return;
            }

            Logger.Log("OsrClient", $"Connecting to OSR Server... ( IP: {Config.Instance.OscServerIP}, Port: {Config.Instance.OscServerPort} )", ConsoleColor.DarkMagenta);
            Actions = new OscActions(Config.Instance.OscServerIP, Config.Instance.OscServerPort);
            Logger.Log("OsrClient", "Connected to OSR Server!", ConsoleColor.DarkMagenta);

            Logger.Log("TwitchBot", "Starting bot...", ConsoleColor.DarkMagenta);
            try
            {
                Bot = new TwitchBot(Config.Instance.TwitchUsername, Config.Instance.TwitchOAuth, Config.Instance.ChannelName);
                Logger.Log("TwitchBot", "Bot started!", ConsoleColor.DarkMagenta);
            }
            catch (Exception ex)
            {
                Logger.Error("TwitchBot", "Starting bot failed...", ConsoleColor.DarkMagenta);
                Logger.Error("TwitchBot", ex.Message, ConsoleColor.DarkMagenta);
            }
            Logger.Log($"Core", "Press any key to exit...");
            Console.ReadKey();
        }
    }
}