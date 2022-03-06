using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TwitchVrcAvatarOSC.Enums;
using TwitchVrcAvatarOSC.Interface.Dialogs;
using TwitchVrcAvatarOSC.Interface.Events;

namespace TwitchVrcAvatarOSC.Interface
{
    public partial class MainPanel : PoisonForm
    {
        public static event EventHandler<StatusChangeArgs> StatusChanged;
        public static event EventHandler<ConsoleLogArgs> LogReceived;

        public static List<ConsoleLogArgs> PendingLogs = new List<ConsoleLogArgs>();

        public static bool Loaded;

        private PoisonTaskWindow _currentCreateCommandWindow;

        public static void OnStatusChanged(StatusChangeArgs e)
        {
            if (StatusChanged != null)
                StatusChanged(null, e);
        }

        public static void OnReceiveLog(ConsoleLogArgs e)
        {
            if (LogReceived != null)
                LogReceived(null, e);
        }

        public MainPanel()
        {
            InitializeComponent();
            LogReceived += new EventHandler<ConsoleLogArgs>(OnReceiveConsoleLog);
            StatusChanged += new EventHandler<StatusChangeArgs>(OnStatusChanged);
            version.Text = CurrentVersion.Instance.Version;
            debugSwitch.Switched = Config.Instance.Debug;
            twitchOAuth.Text = Config.Instance.TwitchOAuth;
            Loaded = true;
            foreach(var e in PendingLogs)
                AddConsoleLog(e.Time, e.Type, e.MessageColor, e.Message);
            PendingLogs.Clear();

            debugSwitch.SwitchedChanged += OnDebugChanged;
            twitchOAuth.LostFocus += OnOAuthChanged;
            twitchOAuth.KeyDown += OnOAuthKeyDown;
        }

        void OnOAuthKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ActiveControl = null;
        }

        void OnOAuthChanged(object sender, EventArgs e)
        {
            Config.Instance.TwitchOAuth = twitchOAuth.Text;
            Config.Save();

            TwitchBot.WaitingForAction = false;
        }

        void OnDebugChanged(object sender)
        {
            Config.Instance.Debug = debugSwitch.Switched;
            Config.Save();
        }

        void OnReceiveConsoleLog(object sender, ConsoleLogArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    OnReceiveConsoleLog(sender, e);
                });
                return;
            }

            if (!Loaded)
            {
                PendingLogs.Add(e);
                return;
            }
            AddConsoleLog(e.Time, e.Type, e.MessageColor, e.Message);
        }

        void OnStatusChanged(object sender, StatusChangeArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    OnStatusChanged(sender, e);
                });
                return;
            }

            SetStatus(e.IsPubSub, e.IsConnected);
        }

        public void AddConsoleLog(DateTime time, LogType type, Color messageColor, string message)
        {
            List<string> lines = message.SplitToLines(40).ToList();

            var control = new ConsoleLog()
            {
                TimeStamp = time,
                LogType = type,
                MessageColor = messageColor,
                Message = lines[0],
            };
            consoleLogs.Controls.Add(control);

            if (lines.Count == 1)
            {
                consoleLogs.ScrollControlIntoView(control);
                return;
            }
            ConsoleLogEmpty last = null;
            for (int x = 1; x < lines.Count; x++)
            {
                var emptyControl = new ConsoleLogEmpty()
                {
                    MessageColor = messageColor,
                    Message = lines[x]
                };
                consoleLogs.Controls.Add(emptyControl);
            }
            consoleLogs.ScrollControlIntoView(last);
        }

        public void SetStatus(bool isPubsub, bool isConnected)
        {
            if (isPubsub)
            {
                if (pubsubSpinner.EnsureVisible)
                    pubsubSpinner.Visible = false;

                twitchPusSubStatus.Text = isConnected ? "✔" : "❌";
                twitchPusSubStatus.ForeColor = isConnected ? Color.Green : Color.Red;
            }
            else
            {
                if (chatSpinner.EnsureVisible)
                    chatSpinner.Visible = false;

                twitchChatStatus.Text = isConnected ? "✔" : "❌";
                twitchChatStatus.ForeColor = isConnected ? Color.Green : Color.Red;
            }
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            PopulateCommands();
        }

        public void RemoveCommand(Control control)
        {
            commands.Controls.Remove(control);
        }

        public void AddCommand(string commandName, bool normalAccess = true, bool streamerAccess = false, bool subAccess = false, bool vipAccess = false, bool randomExecution = false, List<OscOutAction> actions = null)
        {
            if (!Config.Instance.Events.OnCommand.ContainsKey(commandName))
            {
                Config.Instance.Events.OnCommand.Add(commandName, new TwitchCommand() 
                { 
                    OscOutActions = new List<OscOutAction>(),
                });
                Config.Save();
            }

            var cmdItem = new CommandItem(this);
            cmdItem.Width = commands.Width - 25;

            cmdItem.CommandName = commandName;
            cmdItem.NormalAccess = normalAccess;
            cmdItem.StreamerAccess = streamerAccess;
            cmdItem.SubAccess = subAccess;
            cmdItem.VipAccess = vipAccess;
            cmdItem.RandomExecution = randomExecution;
            cmdItem.OscActions = actions ?? new List<OscOutAction>();

            commands.Controls.Add(cmdItem);
        }

        public void PopulateCommands()
        {
            foreach(var cmd in Config.Instance.Events.OnCommand)
            {
                AddCommand(cmd.Key, 
                    cmd.Value.NormalAccess,
                    cmd.Value.BroadcasterAccess,
                    cmd.Value.SubAccess,
                    cmd.Value.VipAccess,
                    cmd.Value.ExecuteRandomAction,
                    cmd.Value.OscOutActions);
            }
        }

        private void addNewCommand_Click(object sender, EventArgs e)
        {
            if (_currentCreateCommandWindow != null)
            {
                _currentCreateCommandWindow.Close();
                _currentCreateCommandWindow.Dispose();
                _currentCreateCommandWindow = null;
            }

            _currentCreateCommandWindow = new PoisonTaskWindow(0, new CreateCommandDialog(this))
            {
                Text = "Add Command",
                Resizable = false,
                MinimizeBox = false,
                MaximizeBox = false,
                Movable = true,
                WindowState = FormWindowState.Normal,
            };
            _currentCreateCommandWindow.Controls[0].Parent = _currentCreateCommandWindow;

            _currentCreateCommandWindow.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            _currentCreateCommandWindow.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            _currentCreateCommandWindow.Show();
            _currentCreateCommandWindow.Size = new System.Drawing.Size(325, 200);
        }
    }
}