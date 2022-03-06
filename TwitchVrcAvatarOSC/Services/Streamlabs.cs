using System.Text;

namespace TwitchVrcAvatarOSC.Services
{
    public class Streamlabs : BackgroundService
    {
        public Dictionary<string, double> ExchangeRates = new Dictionary<string, double>();

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (!Config.Instance.StreamLabs.IsEnabled)
            {
                Logger.Info("StreamLabs", "Skip loading streamlabs events. (Enabled streamlabs in config)", Color.Cyan, Color.White);
                return Task.CompletedTask;
            }

            ExchangeRates = JsonConvert.DeserializeObject<Dictionary<string, double>>(Encoding.UTF8.GetString(Resources.exchangerates));
            Logger.Info("StreamLabs", $"Loaded exchange rates for {ExchangeRates.Count} currencies!", Color.Cyan, Color.White);
            Logger.Error($"StreamLabs", "NOT IMPLEMENTED", Color.Cyan, Color.White);
            return Task.CompletedTask;
        }
    }
}
