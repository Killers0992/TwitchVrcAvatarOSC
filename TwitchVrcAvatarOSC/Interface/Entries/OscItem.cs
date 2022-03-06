using ReaLTaiizor.Controls;
using System.ComponentModel;

namespace TwitchVrcAvatarOSC.Interface
{
    public partial class OscItem : PoisonUserControl
    {
        private CommandItem _commandItem;

        public OscItem(CommandItem item)
        {
            _commandItem = item;
            InitializeComponent();

            actionName.LostFocus += OnActionNameTypingEnded;
            executionDuration.TextChanged += OnExecutionDurationChanged;
            oscValue.TextChanged += OnValueChanged;
            defaultValue.TextChanged += OnDefaultValueChanged;
        }

        public int ID { get; set; }

        string _actionName;

        [Category("Osc Item")]
        public string ActionName
        {
            get
            {
                return _actionName;
            }
            set
            {
                _actionName = value;
                actionName.Text = value;
            }
        }

        void OnActionNameTypingEnded(object sender, EventArgs e)
        {
            Config.Instance.Events.OnCommand[_commandItem.CommandName].OscOutActions[ID].ActionName = actionName.Text;
        }

        int _executionDuration;
        [Category("Osc Item")]
        public int ExecutionDuration
        {
            get
            {
                return _executionDuration;
            }
            set
            {
                _executionDuration = value;
                executionDuration.Value = value;
            }
        }

        void OnExecutionDurationChanged(object sender, EventArgs e)
        {
            Config.Instance.Events.OnCommand[_commandItem.CommandName].OscOutActions[ID].ExecutionDuration = (int)executionDuration.Value;
        }

        string _value;
        [Category("Osc Item")]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                this.oscValue.Text = value;
            }
        }

        void OnValueChanged(object sender, EventArgs e)
        {
            var parsed = oscValue.Text.ConvertStringToObject();
            var currentValue = Config.Instance.Events.OnCommand[_commandItem.CommandName].OscOutActions[ID].Value;

            if (currentValue == parsed)
                return;

            Config.Instance.Events.OnCommand[_commandItem.CommandName].OscOutActions[ID].Value = parsed;
            Config.Save();
        }

        string _defaultValue;
        [Category("Osc Item")]
        public string DefaultValue
        {
            get
            {
                return _defaultValue;
            }
            set
            {
                _defaultValue = value;
                this.defaultValue.Text = value;
            }
        }

        void OnDefaultValueChanged(object sender, EventArgs e)
        {
            var parsed = defaultValue.Text.ConvertStringToObject();
            var currentValue = Config.Instance.Events.OnCommand[_commandItem.CommandName].OscOutActions[ID].DefaultValue;

            if (currentValue == parsed)
                return;

            Config.Instance.Events.OnCommand[_commandItem.CommandName].OscOutActions[ID].DefaultValue = parsed;
            Config.Save();
        }

        private void removeAction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to remove action {ActionName}?", "Remove action", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                return;

            Config.Instance.Events.OnCommand[_commandItem.CommandName].OscOutActions.RemoveAt(ID);
            Config.Save();
            _commandItem.RemoveAction(this);
        }
    }
}
