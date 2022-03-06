using System.Drawing;
using TwitchVrcAvatarOSC.Enums;

namespace TwitchVrcAvatarOSC
{
    public class Logger
    {
        public static void Info(string tag, string message, Color tagColor, Color messageColor) => RawMessage(LogType.Info, tagColor, tag, messageColor, message);
        public static void Error(string tag, string message, Color tagColor, Color messageColor) => RawMessage(LogType.Error, tagColor, tag, messageColor, message);
        public static void Warn(string tag, string message, Color tagColor, Color messageColor) => RawMessage(LogType.Warn, tagColor, tag, messageColor, message);
        public static void Debug(string tag, string message, Color tagColor, Color messageColor)
        {
            if (!Config.Instance.Debug) return;
            RawMessage(LogType.Debug, tagColor, tag, messageColor, message);
        }

        static void RawMessage(LogType logType, Color tagcolor, string tag, Color messageColor, string message)
        {
            MainPanel.OnReceiveLog(new Interface.Events.ConsoleLogArgs(DateTime.Now, logType, tagcolor, tag, messageColor, message));
        }
    }
}
