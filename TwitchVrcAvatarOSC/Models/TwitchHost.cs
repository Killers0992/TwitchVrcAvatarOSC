using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client.Models;

namespace TwitchVrcAvatarOSC.Models
{
    public class TwitchHost
    {
        public int MinViewers { get; set; } = 0;
        public int MaxViewers { get; set; } = 1000;

        public TimeSpan GlobalDelay { get; set; } = TimeSpan.Zero;

        [JsonIgnore]
        public DateTime CurrentGlobalDelay = DateTime.Now;

        public List<OscOutAction> OscOutActions { get; set; } = new List<OscOutAction>();

        public bool TryExecuteCommand(BeingHostedNotification host)
        {
            if (GlobalDelay.TotalSeconds > 0)
            {
                if (CurrentGlobalDelay < DateTime.Now)
                    CurrentGlobalDelay = DateTime.Now.Add(GlobalDelay);
                else
                {
                    Logger.Log($"TwitchHost", $"User {host.HostedByChannel} hosted your channel but action is on cooldown! ( Cooldown ends in {(int)(CurrentGlobalDelay - DateTime.Now).TotalSeconds} seconds )");
                    return false;
                }
            }

            foreach (var action in OscOutActions)
            {
                OscActions.EnqueueAction(action);
            }
            Logger.Log($"TwitchHost", $"User {host.HostedByChannel} hosted your channel and OSC actions added to queue!");
            return true;
        }
    }
}
