namespace TwitchVrcAvatarOSC.Models
{
    public class Config
    {
        public static Config Instance;

        public static void Load() => Instance = JsonConvert.DeserializeObject<Config>(File.ReadAllText("./config.json"));

        public static void Save()
        {
            if (Instance == null) return;
            File.WriteAllText("./config.json", JsonConvert.SerializeObject(Config.Instance, Formatting.Indented, new Newtonsoft.Json.Converters.StringEnumConverter()));
        }

        public bool Debug { get; set; }
        public string TwitchOAuth { get; set; } = "twitch-oauth";
        public VrcOsc VrcOscServer { get; set; } = new VrcOsc();
        public StreamLabsApp StreamLabs { get; set; } = new StreamLabsApp();
        public TwitchEvents Events { get; set; } = new TwitchEvents();
    }

    public class VrcOsc
    {
        public string IP { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 9000;
    }

    public class StreamLabsApp
    {
        public bool IsEnabled { get; set; }
        public string SocketApiKey { get; set; } = "SOCKET-API-KEY";
        public StreamLabsEvents Events { get; set; } = new StreamLabsEvents();
    }

    public class StreamLabsEvents
    {
        public List<object> OnDonation { get; set; } = new List<object>();
    }

    public class TwitchEvents
    {
        public string CommandPrefix { get; set; } = "!";
        public Dictionary<string, TwitchCommand> OnCommand { get; set; } = new Dictionary<string, TwitchCommand>();
        public Dictionary<string, TwitchReward> OnReward { get; set; } = new Dictionary<string, TwitchReward>();
        public List<TwitchBits> OnReceiveBits { get; set; } = new List<TwitchBits>();
        public List<TwitchNewSub> OnNewSubscriber { get; set; } = new List<TwitchNewSub>();
        public List<TwitchReSub> OnReSubscriber { get; set; } = new List<TwitchReSub>();
        public List<TwitchHost> OnBeingHosted { get; set; } = new List<TwitchHost>();
        public TwitchBan OnUserBanned { get; set; }
        public TwitchTimedout OnUserTimedout { get; set; }
        public TwitchFollow OnFollow { get; set; }
    }
}
