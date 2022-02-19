namespace TwitchVrcAvatarOSC.Models
{
    public class Config
    {
        public static Config? Instance;
        public Config() => Instance = this;

        public string OscServerIP { get; set; } = "127.0.0.1";
        public int OscServerPort { get; set; } = 9000;

        public bool Debug { get; set; }

        public string TwitchUsername { get; set; } = "twitch-username";
        public string TwitchOAuth { get; set; } = "twitch-oauth";
        public string ChannelName { get; set; } = "channel-name";

        public string CommandPrefix { get; set; } = "!";
        public TwitchEvents Events { get; set; } = new TwitchEvents();
    }

    public class TwitchEvents
    {
        public Dictionary<string, TwitchCommand> OnCommand { get; set; } = new Dictionary<string, TwitchCommand>();
        public Dictionary<string, TwitchReward> OnReward { get; set; } = new Dictionary<string, TwitchReward>();
        public List<TwitchBits> OnReceiveBits { get; set; } = new List<TwitchBits>();
        public List<TwitchNewSub> OnNewSubscriber { get; set; } = new List<TwitchNewSub>();
        public List<TwitchReSub> OnReSubscriber { get; set; } = new List<TwitchReSub>();
        public List<TwitchHost> OnBeingHosted { get; set; } = new List<TwitchHost>();
        public TwitchBan? OnUserBanned { get; set; }
        public TwitchTimedout? OnUserTimedout { get; set; }
        public TwitchFollow? OnFollow { get; set; }
    }
}
