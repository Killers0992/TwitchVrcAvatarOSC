namespace TwitchVrcAvatarOSC.Models
{
    public class CurrentVersion
    {
        public static CurrentVersion Instance;

        public string Version { get; set; }
        public string[] Changelog { get; set; }
        public int SuiteID { get; set; }
        public int ArtifactID { get; set; }
    }
}
