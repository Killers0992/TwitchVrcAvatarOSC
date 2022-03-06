namespace TwitchVrcAvatarOSC.Interface.Events
{
    public class StatusChangeArgs : EventArgs
    {
        public bool IsPubSub { get; set; }
        public bool IsConnected { get; set; }

        public StatusChangeArgs(bool isPubSub, bool isConnected)
        {
            IsPubSub = isPubSub;
            IsConnected = isConnected;
        }
    }
}
