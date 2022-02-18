using Newtonsoft.Json;
using TwitchLib.Client.Models;
using TwitchVrcAvatarOSC.Bot;

namespace TwitchVrcAvatarOSC.Models
{
    public class TwitchCommand
    {
        public bool NormalAccess { get; set; } = true;
        public bool SubAccess { get; set; }
        public int SubMonths { get; set; }
        public bool ModAccess { get; set; }
        public bool VipAccess { get; set; }

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
                    Logger.Log($"TwitchCommand", $"User {message.DisplayName} tried to execute command {message.Message} but command is on cooldown! ( Cooldown ends in {(int)(CurrentGlobalDelay - DateTime.Now).TotalSeconds} seconds )");
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
                        Logger.Log($"TwitchCommand", $"User {message.DisplayName} tried to execute command {message.Message} but command is on cooldown! ( Cooldown ends in {(int)(delay - DateTime.Now).TotalSeconds} seconds )");
                        return false;
                    }
                }
                CurrentUserDelays.Add(message.UserId, DateTime.Now.Add(DelayPerUser));
            }

            if (!NormalAccess)
            {
                if (message.SubscribedMonthCount < SubMonths) return false;
                if (SubAccess)
                {
                    if (!message.IsSubscriber) return false;
                }
                if (ModAccess && !message.IsModerator) return false;
                if (VipAccess && !message.IsVip) return false;
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

            Logger.Log($"TwitchCommand", $"User {message.DisplayName} sended command {message.Message} and OSC actions added to queue!");
            return true;
        }
    }
}
