
using System.Text;

var builder = WebApplication.CreateBuilder(args);

CurrentVersion.Instance = JsonConvert.DeserializeObject<CurrentVersion>(Encoding.UTF8.GetString(Resources.version));

Logger.Log("TwitchBot", $"Version: {CurrentVersion.Instance.Version}{(CurrentVersion.Instance.Changelog.Length != 0 ? ", Changelogs:" : string.Empty)}");
foreach (var change in CurrentVersion.Instance.Changelog)
{
    Logger.Log("Updater", $" - {change}");
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

Config.Instance = JsonConvert.DeserializeObject<Config>(File.ReadAllText("./config.json"));
File.WriteAllText("./config.json", JsonConvert.SerializeObject(Config.Instance, Formatting.Indented, new Newtonsoft.Json.Converters.StringEnumConverter()));

builder.Services.AddHostedService<TwitchBot>();
builder.Services.AddHostedService<OscActions>();
builder.Services.AddHostedService<Updater>();

builder.Services.AddControllersWithViews();

builder.Services.AddLogging(builder =>
    {
    builder.AddFilter("Microsoft", LogLevel.Error)
           .AddFilter("System", LogLevel.Error)
           .AddFilter("NToastNotify", LogLevel.Error)
           .AddConsole();
});

var app = builder.Build();

app.MapControllers();

app.Run("http://localhost:3000");
