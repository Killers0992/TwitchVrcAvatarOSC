namespace TwitchVrcAvatarOSC.Bot
{
    using System;
    using TwitchLib.Client.Events;
    using TwitchVrcAvatarOSC.Models;

    public class TwitchEventHandlers
    {
        public void OnLog(object sender, OnLogArgs e) => Logger.Log("TwitchBot", e.Data, ConsoleColor.DarkMagenta);

        public void OnMessageReceived(object? sender, OnMessageReceivedArgs e)
        {
            if (!e.ChatMessage.Message.StartsWith("!"))
                return;

            string cmdName = e.ChatMessage.Message.Remove(0, 1);

            if (Config.Instance.SlashCommands.TryGetValue(cmdName.ToLower(), out TwitchCommand cmd))
            {
                if (cmd.TryExecuteCommand(e.ChatMessage))
                    Console.WriteLine($"User {e.ChatMessage.Username} executed command {cmdName}");
                else
                    Console.WriteLine($"User {e.ChatMessage.Username} failed to execute command {cmdName}");
            }
        }
    }
}
