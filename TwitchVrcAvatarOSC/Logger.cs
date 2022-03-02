using System;
using TwitchVrcAvatarOSC.Models;

namespace TwitchVrcAvatarOSC
{
    public class Logger
    {
        public static void Log(string type, string message, ConsoleColor color = ConsoleColor.Green) => RawMessage("LOG", ConsoleColor.Cyan, type, color, message);
        public static void Error(string type, string message, ConsoleColor color = ConsoleColor.Green) => RawMessage("ERROR", ConsoleColor.DarkRed, type, color, message);
        public static void Warn(string type, string message, ConsoleColor color = ConsoleColor.Green) => RawMessage("WARN", ConsoleColor.DarkYellow, type, color, message);
        public static void Debug(string type, string message, ConsoleColor color = ConsoleColor.Green)
        {
            if (!Config.Instance.Debug) return;
            RawMessage("DEBUG", ConsoleColor.Green, type, color, message);
        }

        static void RawMessage(string tag, ConsoleColor tagcolor, string type, ConsoleColor typecolor, string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.Write(" [");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(DateTime.Now.ToString("T"));
            Console.ForegroundColor = defaultColor;
            Console.Write("] ");
            Console.Write("[");
            Console.ForegroundColor = tagcolor;
            Console.Write(tag);
            Console.ForegroundColor = defaultColor;
            Console.Write("]");
            Console.Write($" [");
            Console.ForegroundColor = typecolor;
            Console.Write(type);
            Console.ForegroundColor = defaultColor;
            Console.Write($"] ");
            Console.Write(message);
            Console.WriteLine();
        }
    }
}
