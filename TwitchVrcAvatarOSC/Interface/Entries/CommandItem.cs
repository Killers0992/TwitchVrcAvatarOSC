using ReaLTaiizor.Controls;
using System.ComponentModel;
using TwitchVrcAvatarOSC.Interface.Dialogs;

namespace TwitchVrcAvatarOSC.Interface
{
    public partial class CommandItem : PoisonUserControl
    {
        private MainPanel _mainPanel;
        private PoisonTaskWindow _currentAddOscWindow;

        public CommandItem(MainPanel panel)
        {
            _mainPanel = panel;
            InitializeComponent();

            commandName.LostFocus += OnCommandNameTypingEnded;
            commandName.KeyDown += OnCommandNameKeyDown;
            normalAccess.CheckedChanged += OnNormalAccessChanged;
            streamerAccess.CheckedChanged += OnStreamerAccessChanged;
            subAccess.CheckedChanged += OnSubAccessChanged;
            vipAccess.CheckedChanged += OnVipAccessChanged;
            random.SwitchedChanged += OnRandomChanged;
        }

        private void OnCommandNameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ActiveControl = null;
        }

        string _commandName;
        [Category("Command Info")]
        public string CommandName
        {
            get
            {
                return _commandName;
            }
            set
            {
                _commandName = value;
                if (commandName.Text != _commandName)
                    commandName.Text = value;
            }
        }

        void OnCommandNameTypingEnded(object sender, EventArgs e)
        {
            if (CommandName == commandName.Text) return;

            if (Config.Instance.Events.OnCommand.ContainsKey(commandName.Text))
            {
                MessageBox.Show($"Command with name \"{commandName.Text}\" already exists!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            var saved = Config.Instance.Events.OnCommand[CommandName];

            Config.Instance.Events.OnCommand.Remove(CommandName);
            CommandName = commandName.Text;
            Config.Instance.Events.OnCommand.Add(CommandName, saved);
            Config.Save();
        }

        bool _normalAccess;
        [Category("Command Info")]
        public bool NormalAccess
        {
            get
            {
                return _normalAccess;
            }
            set
            {
                _normalAccess = value;
                normalAccess.Checked = value;
            }
        }

        void OnNormalAccessChanged(object sender)
        {
            Config.Instance.Events.OnCommand[CommandName].NormalAccess = normalAccess.Checked;
            Config.Save();
        }

        bool _streamerAccess;
        [Category("Command Info")]
        public bool StreamerAccess
        {
            get
            {
                return _streamerAccess;
            }
            set
            {
                _streamerAccess = value;
                streamerAccess.Checked = value;
            }
        }

        void OnStreamerAccessChanged(object sender)
        {
            Config.Instance.Events.OnCommand[CommandName].BroadcasterAccess = streamerAccess.Checked;
            Config.Save();
        }

        bool _subAccess;
        [Category("Command Info")]
        public bool SubAccess
        {
            get
            {
                return _subAccess;
            }
            set
            {
                _subAccess = value;
                subAccess.Checked = value;
            }
        }


        void OnSubAccessChanged(object sender)
        {
            Config.Instance.Events.OnCommand[CommandName].SubAccess = subAccess.Checked;
            Config.Save();
        }

        bool _vipAccess;
        [Category("Command Info")]
        public bool VipAccess
        {
            get
            {
                return _vipAccess;
            }
            set
            {
                _vipAccess = value;
                vipAccess.Checked = value;
            }
        }

        void OnVipAccessChanged(object sender)
        {
            Config.Instance.Events.OnCommand[CommandName].VipAccess = vipAccess.Checked;
            Config.Save();
        }

        bool _randomExecution;
        public bool RandomExecution
        {
            get
            {
                return _randomExecution;
            }
            set
            {
                _randomExecution = value;
                random.Switched = value;
            }
        }

        void OnRandomChanged(object sender)
        {
            Config.Instance.Events.OnCommand[CommandName].ExecuteRandomAction = random.Switched;
            Config.Save();
        }

        List<OscOutAction> _oscActions;
        public List<OscOutAction> OscActions
        {
            get
            {
                return _oscActions;
            }
            set
            {
                _oscActions = value;
                for(int x = 0; x < _oscActions.Count; x++)
                {
                    AddNewAction(x, _oscActions[x].ActionName, _oscActions[x].ExecutionDuration, _oscActions[x].Value != null ? _oscActions[x].Value.ToString() : string.Empty, _oscActions[x].DefaultValue != null ? _oscActions[x].DefaultValue.ToString() : string.Empty);
                }
            }
        }

        public void AddNewAction(int id, string actionName, int duration, string value, string defaultValue, bool scroll = false)
        {
            if (id == -1)
            {
                if (Config.Instance.Events.OnCommand.TryGetValue(CommandName, out TwitchCommand cmd))
                {
                    cmd.OscOutActions.Add(new OscOutAction()
                    {
                        ActionName = actionName,
                        ExecutionDuration = duration,
                        Value = value.ConvertStringToObject(),
                        DefaultValue = defaultValue.ConvertStringToObject(),
                    });
                    id = cmd.OscOutActions.Count - 1;
                    Config.Save();
                }
            }

            var item = new OscItem(this);
            item.ID = id;
            item.ActionName = actionName;
            item.ExecutionDuration = duration;
            item.Value = value;
            item.DefaultValue = defaultValue;
            oscActions.Controls.Add(item);

            if (scroll)
                oscActions.ScrollControlIntoView(item);
        }

        private void newOscAction_Click(object sender, EventArgs e)
        {
            if (_currentAddOscWindow != null)
            {
                _currentAddOscWindow.Close();
                _currentAddOscWindow.Dispose();
                _currentAddOscWindow = null;
            }

            _currentAddOscWindow = new PoisonTaskWindow(0, new CreateOscActionDialog(this))
            {
                Text = "Add OSC Action",
                Resizable = false,
                MinimizeBox = false,
                MaximizeBox = false,
                Movable = true,
                WindowState = FormWindowState.Normal,
            };
            _currentAddOscWindow.Controls[0].Parent = _currentAddOscWindow;

            _currentAddOscWindow.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            _currentAddOscWindow.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            _currentAddOscWindow.Show();
            _currentAddOscWindow.Size = new System.Drawing.Size(325, 282);
        }

        public void RemoveAction(Control control)
        {
            oscActions.Controls.Remove(control);
        }

        private void removeCommand_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to remove command {CommandName}?", "Remove command", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            Config.Instance.Events.OnCommand.Remove(CommandName);
            Config.Save();
            _mainPanel.RemoveCommand(this);
        }
    }
}
