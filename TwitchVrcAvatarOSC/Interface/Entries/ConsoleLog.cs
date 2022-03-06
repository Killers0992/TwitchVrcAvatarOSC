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
using TwitchVrcAvatarOSC.Enums;

namespace TwitchVrcAvatarOSC.Interface
{
    public partial class ConsoleLog : PoisonUserControl
    {
        public ConsoleLog()
        {
            InitializeComponent();
        }

        DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get
            {
                return _timeStamp;
            }
            set
            {
                _timeStamp = value;
                time.Text = _timeStamp.TimeOfDay.ToString(@"hh\:mm\:ss");
            }
        }

        LogType _logType;
        public LogType LogType
        {
            get
            {
                return _logType;
            }
            set
            {
                _logType = value;
                switch (_logType)
                {
                    case LogType.Info:
                        type.ForeColor = Color.Cyan;
                        break;
                    case LogType.Warn:
                        type.ForeColor = Color.Orange;
                        break;
                    case LogType.Error:
                        type.ForeColor = Color.Red;
                        break;
                    case LogType.Debug:
                        type.ForeColor = Color.Yellow;
                        break;
                }
                type.Text = _logType.ToString().ToUpper();
            }
        }

        Color _tagColor;
        public Color TagColor
        {
            get
            {
                return _tagColor;
            }
            set
            {
                _tagColor = value;
                tag.ForeColor = _tagColor;
            }
        }

        string _tag;
        public string TagMessage
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag = value;
                tag.Text = _tag;
            }
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
