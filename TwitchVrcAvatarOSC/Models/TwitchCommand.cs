using Newtonsoft.Json;
using TwitchLib.Client.Models;

namespace TwitchVrcAvatarOSC.Models
{
    public class TwitchCommand
    {
        public bool NormalAccess { get; set; } = true;
        public bool SubAccess { get; set; }
        public bool ModAccess { get; set; }
        public bool VipAccess { get; set; }

        public TimeSpan GlobalDelay { get; set; } = TimeSpan.Zero;
        [JsonIgnore]
        public DateTime CurrentGlobalDelay = DateTime.Now;

        public TimeSpan DelayPerUser { get; set; } = TimeSpan.Zero;
        [JsonIgnore]
        public Dictionary<string, DateTime> CurrentUserDelays = new Dictionary<string, DateTime>();

        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand(ChatMessage message)
        {
            if (GlobalDelay.TotalSeconds > 0)
            {
                if (CurrentGlobalDelay < DateTime.Now)
                    CurrentGlobalDelay = DateTime.Now.Add(GlobalDelay);
                else
                    return false;
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
                        return false;
                }
                CurrentUserDelays.Add(message.UserId, DateTime.Now.Add(DelayPerUser));
            }

            if (!NormalAccess)
            {
                if (SubAccess && !message.IsSubscriber) return false;
                if (ModAccess && !message.IsModerator) return false;
                if (VipAccess && !message.IsVip) return false;
            }

            foreach (var action in OscOutActions)
            {
                OscActions.EnqueueAction(action);
            }
            return true;
        }
    }
}
