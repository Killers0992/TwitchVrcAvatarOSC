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
                File.WriteAllText("./config.json", JsonConvert.SerializeObject(new Config(), Formatting.Indented));

            JsonConvert.DeserializeObject<Config>(File.ReadAllText("./config.json"));

            if (Config.Instance == null)
            {
                Logger.Log($"Core", "Config is null! ( config may have wrong format )");
                return;
            }

            Logger.Log("OsrClient", "Connecting to OSR Server...", ConsoleColor.DarkMagenta);
            Actions = new OscActions("127.0.0.1", 9000);
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