using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchVrcAvatarOSC.Interface.Dialogs
{
    public partial class CreateOscActionDialog : PoisonUserControl
    {
        private CommandItem _commandItem;

        public CreateOscActionDialog(CommandItem commandItem)
        {
            _commandItem = commandItem;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _commandItem.AddNewAction(-1, actionName.Text, (int)executionDuration.Value, value.Text, defaultValue.Text, true);
            ParentForm.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
