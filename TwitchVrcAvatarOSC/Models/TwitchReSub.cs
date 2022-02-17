using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Models;

namespace TwitchVrcAvatarOSC.Models
{
    public class TwitchReSub
    {
        public int MinMonths { get; set; } = 0;
        public int MaxMonths { get; set; } = 365;

        public List<SubscriptionPlan> SubPlans { get; set; } = new List<SubscriptionPlan>() { SubscriptionPlan.NotSet };

        public TimeSpan GlobalDelay { get; set; } = TimeSpan.Zero;

        [JsonIgnore]
        public DateTime CurrentGlobalDelay = DateTime.Now;

        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand(ReSubscriber sub)
        {
            if (GlobalDelay.TotalSeconds > 0)
            {
                if (CurrentGlobalDelay < DateTime.Now)
                    CurrentGlobalDelay = DateTime.Now.Add(GlobalDelay);
                else
                {
                    Logger.Log($"TwitchReSub", $"User {sub.DisplayName} subbed but action is on cooldown! ( Cooldown ends in {(int)(CurrentGlobalDelay - DateTime.Now).TotalSeconds} seconds )");
                    return false;
                }
            }

            foreach (var action in OscOutActions)
            {
                OscActions.EnqueueAction(action);
            }
            return true;
        }
    }
}
