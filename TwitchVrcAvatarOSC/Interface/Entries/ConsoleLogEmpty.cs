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

namespace TwitchVrcAvatarOSC.Interface
{
    public partial class ConsoleLogEmpty : PoisonUserControl
    {
        public ConsoleLogEmpty()
        {
            InitializeComponent();
        }

        Color _messageColor;
        public Color MessageColor
        {
            get
            {
                return _messageColor;
            }
            set
            {
                _messageColor = value;
                message.ForeColor = _messageColor;
            }
        }

        string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                message.Text = _message;
            }
        }
    }
}
