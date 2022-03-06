using System.Drawing;

namespace TwitchVrcAvatarOSC.Models.StreamLabs
{
    public class StreamLabsDonation
    {
        public int MinAmount { get; set; } = 0;
        public int MaxAmount { get; set; } = 1000;

        public TimeSpan GlobalDelay { get; set; } = TimeSpan.Zero;

        [JsonIgnore]
        public DateTime CurrentGlobalDelay = DateTime.Now;

        public TimeSpan DelayPerUser { get; set; } = TimeSpan.Zero;

        [JsonIgnore]
        public Dictionary<string, DateTime> CurrentUserDelays = new Dictionary<string, DateTime>();

        public bool ExecuteRandomAction { get; set; }
        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand(ChatMessage message)
        {
            if (GlobalDelay.TotalSeconds > 0)
            {
                if (CurrentGlobalDelay < DateTime.Now)
                    CurrentGlobalDelay = DateTime.Now.Add(GlobalDelay);
                else
                {
                    Logger.Info($"TwitchBits", $"User {message.DisplayName} sended {message.Bits} bits but action is on cooldown! ( Cooldown ends in {(int)(CurrentGlobalDelay - DateTime.Now).TotalSeconds} seconds )", Color.Magenta, Color.White);
                    return false;
                }
            }

            if (DelayPerUser.TotalSeconds > 0 && !string.IsNullOrEmpty(message.UserId))
            {
                if (CurrentUserDelays.TryGetValue(message.UserId, out DateTime delay))
                {
                    if (delay < DateTime.Now)
                    {
                        CurrentUserDelays.Remove(message.UserId);
                    }
                    else
                    {
                        Logger.Info($"TwitchBits", $"User {message.DisplayName} sended {message.Bits} bits but action is on cooldown! ( Cooldown ends in {(int)(delay - DateTime.Now).TotalSeconds} seconds )", Color.Magenta, Color.White);
                        return false;
                    }
                }
                CurrentUserDelays.Add(message.UserId, DateTime.Now.Add(DelayPerUser));
            }

            if (ExecuteRandomAction && OscOutActions.Count > 1)
            {
                var action = OscOutActions[TwitchBot.rng.Next(0, OscOutActions.Count - 1)];
                OscActions.EnqueueAction(action);
            }
            else
            {
                foreach (var action in OscOutActions)
                    OscActions.EnqueueAction(action);
            }

            Logger.Info($"TwitchBits", $"User {message.DisplayName} sended {message.Bits} and OSC actions added to queue!", Color.Magenta, Color.White);
            return true;
        }
    }
}
