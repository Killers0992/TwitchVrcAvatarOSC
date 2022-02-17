namespace TwitchVrcAvatarOSC.Models
{
    public class Config
    {
        public static Config? Instance;
        public Config() => Instance = this;

        public string TwitchUsername { get; set; } = "twitch-username";
        public string TwitchOAuth { get; set; } = "twitch-oauth";
        public string ChannelName { get; set; } = "channel-name";

        public Dictionary<string, TwitchCommand> SlashCommands { get; set; } = new Dictionary<string, TwitchCommand>()
        {
            { "test", new TwitchCommand() }
        };
    }
}
