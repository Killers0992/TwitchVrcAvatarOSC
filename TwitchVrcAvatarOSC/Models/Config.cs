namespace TwitchVrcAvatarOSC.Models
{
    public class Config
    {
        public static Config? Instance;
        public Config() => Instance = this;

        public string OscServerIP { get; set; } = "127.0.0.1";
        public int OscServerPort { get; set; } = 9000;

        public string TwitchUsername { get; set; } = "twitch-username";
        public string TwitchOAuth { get; set; } = "twitch-oauth";
        public string ChannelName { get; set; } = "channel-name";

        public string CommandPrefix { get; set; } = "!";
        public Dictionary<string, TwitchCommand> Commands { get; set; } = new Dictionary<string, TwitchCommand>();
        public TwitchEvents Events { get; set; } = new TwitchEvents();
    }

    public class TwitchEvents
    {
        public List<TwitchBits> OnReceiveBits { get; set; } = new List<TwitchBits>();
    }
}
