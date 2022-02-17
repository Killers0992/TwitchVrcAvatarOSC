using Newtonsoft.Json;

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
        public DateTime CurrentGlobalDelay;

        public TimeSpan DelayPerUser { get; set; } = TimeSpan.Zero;
        [JsonIgnore]
        public Dictionary<string, DateTime> CurrentUserDelays = new Dictionary<string, DateTime>();

        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand()
        {
            foreach(var action in OscOutActions)
            {
                OscActions.EnqueueAction(action);
            }
            return true;
        }
    }
}
