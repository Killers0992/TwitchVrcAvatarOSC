using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client.Models;
using TwitchLib.PubSub.Enums;
using TwitchLib.PubSub.Models.Responses.Messages;
using TwitchVrcAvatarOSC.Bot;

namespace TwitchVrcAvatarOSC.Models
{
    public class TwitchReSub
    {
        public int MinMonths { get; set; } = 0;
        public int MaxMonths { get; set; } = 365;

        public List<SubscriptionPlan> SubPlans { get; set; } = new List<SubscriptionPlan>();

        public TimeSpan GlobalDelay { get; set; } = TimeSpan.Zero;

        [JsonIgnore]
        public DateTime CurrentGlobalDelay = DateTime.Now;

        public bool ExecuteRandomAction { get; set; }
        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand(int months, ChannelSubscription sub)
        {
            if (GlobalDelay.TotalSeconds > 0)
            {
                if (CurrentGlobalDelay < DateTime.Now)
                    CurrentGlobalDelay = DateTime.Now.Add(GlobalDelay);
                else
                {
                    Logger.Info($"TwitchReSub", $"User {sub.DisplayName} subbed but action is on cooldown! ( Cooldown ends in {(int)(CurrentGlobalDelay - DateTime.Now).TotalSeconds} seconds )", Color.Magenta, Color.White);
                    return false;
                }
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

            Logger.Info($"TwitchReSub", $"User {sub.DisplayName} resubbed with plan {sub.SubscriptionPlan} for {months} and OSC actions added to queue!", Color.Magenta, Color.White);
            return true;
        }
    }
}
