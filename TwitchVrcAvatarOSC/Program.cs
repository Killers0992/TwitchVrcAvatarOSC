
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Drawing;
using System.Text;

namespace TwitchVrcAvatarOSC
{
    public class Program
    {
        public static MainPanel MainForm { get; private set; }

        [STAThread]
        public static void Main(string[] args)
        {
            var window = ConsoleWindow.GetConsoleWindow();
            ConsoleWindow.ShowWindow(window, 0);

            CurrentVersion.Instance = JsonConvert.DeserializeObject<CurrentVersion>(Encoding.UTF8.GetString(Resources.version));

            Logger.Info("TwitchBot", $"Version: {CurrentVersion.Instance.Version}{(CurrentVersion.Instance.Changelog.Length != 0 ? ", Changelogs:" : string.Empty)}", Color.Magenta, Color.White);
            foreach (var change in CurrentVersion.Instance.Changelog)
            {
                Logger.Info("TwitchBot", $" - {change}", Color.Magenta, Color.White);
            }

            if (!File.Exists("./config.json"))
                File.WriteAllText("./config.json", JsonConvert.SerializeObject(new Config()
                {
                    Events = new TwitchEvents()
                    {
                        OnCommand = new Dictionary<string, TwitchCommand>() { { "test", new TwitchCommand() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } } } },
                        OnBeingHosted = new List<TwitchHost>() { new TwitchHost() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } } },
                        OnNewSubscriber = new List<TwitchNewSub>() { new TwitchNewSub() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } }, SubPlans = new List<SubscriptionPlan>() { SubscriptionPlan.NotSet, SubscriptionPlan.Prime, SubscriptionPlan.Tier1, SubscriptionPlan.Tier2 } } },
                        OnReceiveBits = new List<TwitchBits>() { new TwitchBits() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } } },
                        OnReSubscriber = new List<TwitchReSub>() { new TwitchReSub() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } }, SubPlans = new List<SubscriptionPlan>() { SubscriptionPlan.NotSet, SubscriptionPlan.Prime, SubscriptionPlan.Tier1, SubscriptionPlan.Tier2 } } },
                        OnReward = new Dictionary<string, TwitchReward>() { { "<REWARD ID>", new TwitchReward() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } } } },
                        OnUserBanned = new TwitchBan() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } },
                        OnUserTimedout = new TwitchTimedout() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } },
                        OnFollow = new TwitchFollow() { OscOutActions = new List<OscOutAction>() { new OscOutAction() { Value = 1, DefaultValue = 0 } } }
                    }
                }, Formatting.Indented, new Newtonsoft.Json.Converters.StringEnumConverter()));

            Config.Load();
            Config.Save();
           
            CancellationTokenSource cts = new CancellationTokenSource();
            CreateWebHostBuilder(args).Build().RunAsync(cts.Token);
            
            ApplicationConfiguration.Initialize();
            MainForm = new MainPanel();
            Application.Run(MainForm);
            cts.Cancel();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging(p => p.SetMinimumLevel(LogLevel.Error))
            .UseUrls("http://localhost:3000")
            .UseStartup<Startup>();
    }
}