namespace TwitchVrcAvatarOSC.Models
{
    public class CurrentVersion
    {
        public static CurrentVersion Instance;

        public string Version { get; set; }
        public string[] Changelog { get; set; }
    }
}
