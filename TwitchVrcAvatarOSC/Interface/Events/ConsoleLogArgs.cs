using System.Drawing;
using TwitchVrcAvatarOSC.Enums;

namespace TwitchVrcAvatarOSC.Interface.Events
{
    public class ConsoleLogArgs : EventArgs
    {
        public DateTime Time { get; set; }
        public LogType Type { get; set; }
        public Color TagColor { get; set; }
        public string TagMessage { get; set; }
        public Color MessageColor { get; set; }
        public string Message { get; set; }

        public ConsoleLogArgs(DateTime time, LogType type, Color tagColor, string tagMessage, Color messageColor, string message)
        {
            Time = time;
            Type = type;
            TagColor = tagColor;
            TagMessage = tagMessage;
            MessageColor = messageColor;
            Message = message;
        }
    }
}
