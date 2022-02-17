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
            if (!string.IsNullOrEmpty(e.ChatMessage.CustomRewardId))
            {
                if (Config.Instance.Events.OnReward.TryGetValue(e.ChatMessage.CustomRewardId, out TwitchReward? rew))
                {
                    if (rew.TryExecuteCommand(e.ChatMessage))
                        Logger.Log("TwitchReward", $"User {e.ChatMessage.Username} executed reward {e.ChatMessage.CustomRewardId}");
                    else
                        Logger.Log("TwitchReward", $"User {e.ChatMessage.Username} failed to execute command {e.ChatMessage.CustomRewardId}");
                }
                else
                {
                    Logger.Log("TwitchReward", $"User {e.ChatMessage.Username} executed reward {e.ChatMessage.CustomRewardId} but that reward id is not added in config!");
                }
            }

            if (e.ChatMessage.Bits > 0)
            {
                var bitsEvent = Config.Instance.Events.OnReceiveBits.FirstOrDefault(p => e.ChatMessage.Bits >= p.MinBits && e.ChatMessage.Bits <= p.MaxBits) ?? Config.Instance.Events.OnReceiveBits.OrderByDescending(p => p.MaxBits).FirstOrDefault();
                if (bitsEvent != null)
                {
                    bitsEvent.TryExecuteCommand(e.ChatMessage);
                }
            }

            if (!e.ChatMessage.Message.StartsWith(Config.Instance.CommandPrefix))
                return;

            string cmdName = e.ChatMessage.Message.Remove(0, 1);

            if (Config.Instance.Events.OnCommand.TryGetValue(cmdName.ToLower(), out TwitchCommand? cmd))
            {
                if (cmd.TryExecuteCommand(e.ChatMessage))
                    Logger.Log("TwitchCommand", $"User {e.ChatMessage.Username} executed command {cmdName}");
                else
                    Logger.Log("TwitchCommand", $"User {e.ChatMessage.Username} failed to execute command {cmdName}");
            }
        }

        public void OnBeingHosted(object? sender, OnBeingHostedArgs e)
        {
            var targetCommand = Config.Instance.Events.OnBeingHosted.FirstOrDefault(p => e.BeingHostedNotification.Viewers >= p.MinViewers && e.BeingHostedNotification.Viewers <= p.MaxViewers) ?? Config.Instance.Events.OnBeingHosted.OrderByDescending(p => p.MaxViewers).FirstOrDefault();

            if (targetCommand == null)
            {
                Logger.Log($"TwitchHost", $"User {e.BeingHostedNotification.HostedByChannel} is hosting your channel with {e.BeingHostedNotification.Viewers} viewers but any OscActions were made!");
                return;
            }

            targetCommand.TryExecuteCommand(e.BeingHostedNotification);
        }

        public void OnUserTimedout(object? sender, OnUserTimedoutArgs e)
        {
            if (Config.Instance.Events.OnUserTimedout == null) return;

            Config.Instance.Events.OnUserTimedout.TryExecuteCommand(e.UserTimeout.Username);
        }


        public void OnUserBanned(object? sender, OnUserBannedArgs e)
        {
            if (Config.Instance.Events.OnUserBanned == null) return;

            Config.Instance.Events.OnUserBanned.TryExecuteCommand(e.UserBan.Username);
        }

        public void OnReSubscriber(object? sender, OnReSubscriberArgs e)
        {
            var targetSubCommand = Config.Instance.Events.OnReSubscriber.FirstOrDefault(p => p.SubPlans.Contains(e.ReSubscriber.SubscriptionPlan) && e.ReSubscriber.Months >= p.MinMonths && e.ReSubscriber.Months <= p.MaxMonths) ?? Config.Instance.Events.OnReSubscriber.Where(p => p.SubPlans.Contains(e.ReSubscriber.SubscriptionPlan)).OrderByDescending(p => p.MaxMonths).FirstOrDefault();

            if (targetSubCommand == null)
            {
                Logger.Log($"TwitchReSub", $"User {e.ReSubscriber.DisplayName} subbed for {e.ReSubscriber.Months} months but sub plan {e.ReSubscriber.SubscriptionPlan} is not configured in config!");
                return;
            }

            targetSubCommand.TryExecuteCommand(e.ReSubscriber);
        }

        public void OnNewSubscriber(object? sender, OnNewSubscriberArgs e)
        {
            var targetSubCommand = Config.Instance.Events.OnNewSubscriber.FirstOrDefault(p => p.SubPlans.Contains(e.Subscriber.SubscriptionPlan));

            if (targetSubCommand == null)
            {
                Logger.Log($"TwitchNewSub", $"User {e.Subscriber.DisplayName} subbed but sub plan {e.Subscriber.SubscriptionPlan} is not configured in config!");
                return;
            }

            targetSubCommand.TryExecuteCommand(e.Subscriber);
        }
    }
}
