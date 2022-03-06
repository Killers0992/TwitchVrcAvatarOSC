using TwitchLib.PubSub.Models.Responses.Messages.Redemption;

namespace TwitchVrcAvatarOSC.Models
{
    public class TwitchReward
    {
        [JsonIgnore]
        DateTime CurrentGlobalDelay = DateTime.Now;
        [JsonIgnore]
        Dictionary<string, DateTime> CurrentUserDelays = new Dictionary<string, DateTime>();

        public TimeSpan GlobalDelay { get; set; } = TimeSpan.Zero;
        public TimeSpan DelayPerUser { get; set; } = TimeSpan.Zero;
        public bool ExecuteRandomAction { get; set; }
        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand(Redemption message)
        {
            if (GlobalDelay.TotalSeconds > 0)
            {
                if (CurrentGlobalDelay < DateTime.Now)
                    CurrentGlobalDelay = DateTime.Now.Add(GlobalDelay);
                else
                {
                    Logger.Info($"TwitchReward", $"User {message.User.DisplayName} redeemed reward {message.Reward.Id} but action is on cooldown! ( Cooldown ends in {(int)(CurrentGlobalDelay - DateTime.Now).TotalSeconds} seconds )", Color.Magenta, Color.White);
                    return false;
                }
            }

            if (DelayPerUser.TotalSeconds > 0 && !string.IsNullOrEmpty(message.User.Id))
            {
                if (CurrentUserDelays.TryGetValue(message.User.Id, out DateTime delay))
                {
                    if (delay < DateTime.Now)
                    {
                        CurrentUserDelays.Remove(message.User.Id);
                    }
                    else
                    {
                        Logger.Info($"TwitchReward", $"User {message.User.DisplayName} redeemed reward {message.Reward.Id} but action is on cooldown! ( Cooldown ends in {(int)(delay - DateTime.Now).TotalSeconds} seconds )", Color.Magenta, Color.White);
                        return false;
                    }
                }
                CurrentUserDelays.Add(message.User.Id, DateTime.Now.Add(DelayPerUser));
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

            Logger.Info($"TwitchReward", $"User {message.User.DisplayName} redeemed reward {message.Reward.Id} and OSC actions added to queue!", Color.Magenta, Color.White);
            return true;
        }
    }
}
