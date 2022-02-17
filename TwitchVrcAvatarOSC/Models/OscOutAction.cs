using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchVrcAvatarOSC.Models
{
    public class OscOutAction
    {
        public string ActionName { get; set; } = "/avatar/parameters/VRCEmote";
        public int ExecutionDuration { get; set; } = 3;

        [JsonIgnore]
        DateTime _assignedTime;
        [JsonIgnore]
        public DateTime AssignedTime
        {
            set
            {
                _assignedTime = value.AddSeconds(ExecutionDuration);
            }
        }

        [JsonIgnore]
        public DateTime ExecutionTime => _assignedTime;

        public object? DefaultValue { get; set; }
        public object? Value { get; set; }
    }
}
