using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System.Windows.Forms;

namespace TwitchVrcAvatarOSC.Interface
{
    partial class MainPanel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.poisonTabControl1 = new ReaLTaiizor.Controls.PoisonTabControl();
            this.Tab0 = new ReaLTaiizor.Controls.PoisonTabPage();
            this.consoleLogs = new System.Windows.Forms.FlowLayoutPanel();
            this.pubsubSpinner = new ReaLTaiizor.Controls.PoisonProgressSpinner();
            this.chatSpinner = new ReaLTaiizor.Controls.PoisonProgressSpinner();
            this.version = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel23 = new ReaLTaiizor.Controls.PoisonLabel();
            this.twitchPusSubStatus = new ReaLTaiizor.Controls.PoisonLabel();
            this.twitchChatStatus = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel8 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel9 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonTabPage2 = new ReaLTaiizor.Controls.PoisonTabPage();
            this.commands = new System.Windows.Forms.FlowLayoutPanel();
            this.poisonTabPage3 = new ReaLTaiizor.Controls.PoisonTabPage();
            this.poisonTabPage4 = new ReaLTaiizor.Controls.PoisonTabPage();
            this.debugSwitch = new ReaLTaiizor.Controls.MetroSwitch();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel15 = new ReaLTaiizor.Controls.PoisonLabel();
            this.twitchOAuth = new ReaLTaiizor.Controls.PoisonTextBox();
            this.poisonStyleManager = new ReaLTaiizor.Manager.PoisonStyleManager(this.components);
            this.poisonToolTip = new ReaLTaiizor.Controls.PoisonToolTip();
            this.poisonStyleExtender = new ReaLTaiizor.Controls.PoisonStyleExtender(this.components);
            this.materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.addNewCommand = new ReaLTaiizor.Controls.PoisonButton();
            this.poisonTabControl1.SuspendLayout();
            this.Tab0.SuspendLayout();
            this.poisonTabPage2.SuspendLayout();
            this.poisonTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonTabControl1
            // 
            this.poisonTabControl1.Controls.Add(this.Tab0);
            this.poisonTabControl1.Controls.Add(this.poisonTabPage2);
            this.poisonTabControl1.Controls.Add(this.poisonTabPage3);
            this.poisonTabControl1.Controls.Add(this.poisonTabPage4);
            this.poisonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonTabControl1.Location = new System.Drawing.Point(20, 60);
            this.poisonTabControl1.Name = "poisonTabControl1";
            this.poisonTabControl1.Padding = new System.Drawing.Point(6, 8);
            this.poisonTabControl1.SelectedIndex = 0;
            this.poisonTabControl1.Size = new System.Drawing.Size(680, 302);
            this.poisonTabControl1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonTabControl1.TabIndex = 0;
            this.poisonTabControl1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonTabControl1.UseSelectable = true;
            // 
            // Tab0
            // 
            this.Tab0.AutoScroll = true;
            this.Tab0.Controls.Add(this.consoleLogs);
            this.Tab0.Controls.Add(this.pubsubSpinner);
            this.Tab0.Controls.Add(this.chatSpinner);
            this.Tab0.Controls.Add(this.version);
            this.Tab0.Controls.Add(this.poisonLabel23);
            this.Tab0.Controls.Add(this.twitchPusSubStatus);
            this.Tab0.Controls.Add(this.twitchChatStatus);
            this.Tab0.Controls.Add(this.poisonLabel8);
            this.Tab0.Controls.Add(this.poisonLabel9);
            this.Tab0.Controls.Add(this.poisonLabel1);
            this.Tab0.HorizontalScrollbar = true;
            this.Tab0.HorizontalScrollbarBarColor = true;
            this.Tab0.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab0.HorizontalScrollbarSize = 10;
            this.Tab0.Location = new System.Drawing.Point(4, 38);
            this.Tab0.Name = "Tab0";
            this.Tab0.Padding = new System.Windows.Forms.Padding(25);
            this.Tab0.Size = new System.Drawing.Size(672, 260);
            this.Tab0.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Tab0.TabIndex = 0;
            this.Tab0.Text = "Main Controls";
            this.Tab0.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.Tab0.VerticalScrollbar = true;
            this.Tab0.VerticalScrollbarBarColor = true;
            this.Tab0.VerticalScrollbarHighlightOnWheel = false;
            this.Tab0.VerticalScrollbarSize = 10;
            // 
            // consoleLogs
            // 
            this.consoleLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleLogs.AutoScroll = true;
            this.consoleLogs.BackColor = System.Drawing.Color.Transparent;
            this.consoleLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleLogs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.consoleLogs.Location = new System.Drawing.Point(181, 28);
            this.consoleLogs.Name = "consoleLogs";
            this.consoleLogs.Size = new System.Drawing.Size(488, 229);
            this.consoleLogs.TabIndex = 16;
            this.consoleLogs.WrapContents = false;
            // 
            // pubsubSpinner
            // 
            this.pubsubSpinner.Location = new System.Drawing.Point(134, 103);
            this.pubsubSpinner.Maximum = 100;
            this.pubsubSpinner.Name = "pubsubSpinner";
            this.pubsubSpinner.Size = new System.Drawing.Size(20, 20);
            this.pubsubSpinner.Speed = 2F;
            this.pubsubSpinner.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.pubsubSpinner.TabIndex = 15;
            this.pubsubSpinner.Text = "poisonProgressSpinner5";
            this.pubsubSpinner.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.pubsubSpinner.UseSelectable = true;
            this.pubsubSpinner.Value = 90;
            // 
            // chatSpinner
            // 
            this.chatSpinner.Location = new System.Drawing.Point(134, 65);
            this.chatSpinner.Maximum = 100;
            this.chatSpinner.Name = "chatSpinner";
            this.chatSpinner.Size = new System.Drawing.Size(20, 20);
            this.chatSpinner.Speed = 2F;
            this.chatSpinner.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.chatSpinner.TabIndex = 14;
            this.chatSpinner.Text = "chatSpinner";
            this.chatSpinner.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.chatSpinner.UseSelectable = true;
            this.chatSpinner.Value = 90;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.version.Location = new System.Drawing.Point(115, 148);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(47, 25);
            this.version.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.version.TabIndex = 13;
            this.version.Text = "0.0.0";
            this.version.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel23
            // 
            this.poisonLabel23.AutoSize = true;
            this.poisonLabel23.Location = new System.Drawing.Point(28, 103);
            this.poisonLabel23.Name = "poisonLabel23";
            this.poisonLabel23.Size = new System.Drawing.Size(93, 19);
            this.poisonLabel23.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel23.TabIndex = 11;
            this.poisonLabel23.Text = "Twitch PubSub";
            this.poisonLabel23.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // twitchPusSubStatus
            // 
            this.twitchPusSubStatus.AutoSize = true;
            this.twitchPusSubStatus.BackColor = System.Drawing.Color.Chocolate;
            this.twitchPusSubStatus.ForeColor = System.Drawing.Color.Red;
            this.twitchPusSubStatus.Location = new System.Drawing.Point(134, 103);
            this.twitchPusSubStatus.Name = "twitchPusSubStatus";
            this.twitchPusSubStatus.Size = new System.Drawing.Size(28, 19);
            this.twitchPusSubStatus.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.twitchPusSubStatus.TabIndex = 11;
            this.twitchPusSubStatus.Text = "❌";
            this.twitchPusSubStatus.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.twitchPusSubStatus.UseCustomForeColor = true;
            // 
            // twitchChatStatus
            // 
            this.twitchChatStatus.AutoSize = true;
            this.twitchChatStatus.BackColor = System.Drawing.Color.Chocolate;
            this.twitchChatStatus.ForeColor = System.Drawing.Color.Red;
            this.twitchChatStatus.Location = new System.Drawing.Point(134, 65);
            this.twitchChatStatus.Name = "twitchChatStatus";
            this.twitchChatStatus.Size = new System.Drawing.Size(28, 19);
            this.twitchChatStatus.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.twitchChatStatus.TabIndex = 11;
            this.twitchChatStatus.Text = "❌";
            this.twitchChatStatus.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.twitchChatStatus.UseCustomForeColor = true;
            // 
            // poisonLabel8
            // 
            this.poisonLabel8.AutoSize = true;
            this.poisonLabel8.Location = new System.Drawing.Point(28, 65);
            this.poisonLabel8.Name = "poisonLabel8";
            this.poisonLabel8.Size = new System.Drawing.Size(75, 19);
            this.poisonLabel8.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel8.TabIndex = 11;
            this.poisonLabel8.Text = "Twitch Chat";
            this.poisonLabel8.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel9
            // 
            this.poisonLabel9.AutoSize = true;
            this.poisonLabel9.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel9.Location = new System.Drawing.Point(28, 148);
            this.poisonLabel9.Name = "poisonLabel9";
            this.poisonLabel9.Size = new System.Drawing.Size(67, 25);
            this.poisonLabel9.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel9.TabIndex = 8;
            this.poisonLabel9.Text = "Version";
            this.poisonLabel9.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel1.Location = new System.Drawing.Point(28, 28);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(149, 25);
            this.poisonLabel1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel1.TabIndex = 8;
            this.poisonLabel1.Text = "Connection Status";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonTabPage2
            // 
            this.poisonTabPage2.Controls.Add(this.addNewCommand);
            this.poisonTabPage2.Controls.Add(this.commands);
            this.poisonTabPage2.HorizontalScrollbarBarColor = true;
            this.poisonTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonTabPage2.HorizontalScrollbarSize = 10;
            this.poisonTabPage2.Location = new System.Drawing.Point(4, 38);
            this.poisonTabPage2.Name = "poisonTabPage2";
            this.poisonTabPage2.Padding = new System.Windows.Forms.Padding(25);
            this.poisonTabPage2.Size = new System.Drawing.Size(672, 260);
            this.poisonTabPage2.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonTabPage2.TabIndex = 1;
            this.poisonTabPage2.Text = "Commands";
            this.poisonTabPage2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonTabPage2.VerticalScrollbarBarColor = true;
            this.poisonTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.poisonTabPage2.VerticalScrollbarSize = 10;
            this.poisonTabPage2.Visible = false;
            // 
            // commands
            // 
            this.poisonStyleExtender.SetApplyPoisonTheme(this.commands, true);
            this.commands.AutoScroll = true;
            this.commands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.commands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.commands.Location = new System.Drawing.Point(3, 25);
            this.commands.Name = "commands";
            this.commands.Size = new System.Drawing.Size(669, 210);
            this.commands.TabIndex = 2;
            // 
            // poisonTabPage3
            // 
            this.poisonTabPage3.HorizontalScrollbar = true;
            this.poisonTabPage3.HorizontalScrollbarBarColor = true;
            this.poisonTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonTabPage3.HorizontalScrollbarSize = 10;
            this.poisonTabPage3.Location = new System.Drawing.Point(4, 35);
            this.poisonTabPage3.Name = "poisonTabPage3";
            this.poisonTabPage3.Padding = new System.Windows.Forms.Padding(25);
            this.poisonTabPage3.Size = new System.Drawing.Size(672, 263);
            this.poisonTabPage3.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonTabPage3.TabIndex = 2;
            this.poisonTabPage3.Text = "Events";
            this.poisonTabPage3.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonTabPage3.VerticalScrollbar = true;
            this.poisonTabPage3.VerticalScrollbarBarColor = true;
            this.poisonTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.poisonTabPage3.VerticalScrollbarSize = 10;
            this.poisonTabPage3.Visible = false;
            // 
            // poisonTabPage4
            // 
            this.poisonTabPage4.Controls.Add(this.debugSwitch);
            this.poisonTabPage4.Controls.Add(this.poisonLabel2);
            this.poisonTabPage4.Controls.Add(this.poisonLabel15);
            this.poisonTabPage4.Controls.Add(this.twitchOAuth);
            this.poisonTabPage4.HorizontalScrollbarBarColor = true;
            this.poisonTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonTabPage4.HorizontalScrollbarSize = 10;
            this.poisonTabPage4.Location = new System.Drawing.Point(4, 35);
            this.poisonTabPage4.Name = "poisonTabPage4";
            this.poisonTabPage4.Padding = new System.Windows.Forms.Padding(25);
            this.poisonTabPage4.Size = new System.Drawing.Size(672, 263);
            this.poisonTabPage4.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonTabPage4.TabIndex = 3;
            this.poisonTabPage4.Text = "Settings";
            this.poisonTabPage4.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonTabPage4.VerticalScrollbarBarColor = true;
            this.poisonTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.poisonTabPage4.VerticalScrollbarSize = 10;
            this.poisonTabPage4.Visible = false;
            // 
            // debugSwitch
            // 
            this.poisonStyleExtender.SetApplyPoisonTheme(this.debugSwitch, true);
            this.debugSwitch.BackColor = System.Drawing.Color.Transparent;
            this.debugSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.debugSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.debugSwitch.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.debugSwitch.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.debugSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.debugSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.debugSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.debugSwitch.IsDerivedStyle = true;
            this.debugSwitch.Location = new System.Drawing.Point(30, 115);
            this.debugSwitch.Name = "debugSwitch";
            this.debugSwitch.Size = new System.Drawing.Size(58, 22);
            this.debugSwitch.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.debugSwitch.StyleManager = null;
            this.debugSwitch.Switched = false;
            this.debugSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.debugSwitch.TabIndex = 13;
            this.debugSwitch.ThemeAuthor = "Them3";
            this.debugSwitch.ThemeName = "MetroDark5";
            this.debugSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.Location = new System.Drawing.Point(28, 89);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(87, 19);
            this.poisonLabel2.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel2.TabIndex = 12;
            this.poisonLabel2.Text = "Debug mode";
            this.poisonLabel2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel15
            // 
            this.poisonLabel15.AutoSize = true;
            this.poisonLabel15.Location = new System.Drawing.Point(28, 23);
            this.poisonLabel15.Margin = new System.Windows.Forms.Padding(3);
            this.poisonLabel15.Name = "poisonLabel15";
            this.poisonLabel15.Size = new System.Drawing.Size(123, 19);
            this.poisonLabel15.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel15.TabIndex = 10;
            this.poisonLabel15.Text = "Twitch OAuth Token";
            this.poisonLabel15.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // twitchOAuth
            // 
            this.twitchOAuth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.twitchOAuth.CustomButton.Image = null;
            this.twitchOAuth.CustomButton.Location = new System.Drawing.Point(151, 2);
            this.twitchOAuth.CustomButton.Name = "";
            this.twitchOAuth.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.twitchOAuth.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.twitchOAuth.CustomButton.TabIndex = 1;
            this.twitchOAuth.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.twitchOAuth.CustomButton.UseSelectable = true;
            this.twitchOAuth.CustomButton.Visible = false;
            this.twitchOAuth.Lines = new string[0];
            this.twitchOAuth.Location = new System.Drawing.Point(28, 48);
            this.twitchOAuth.MaxLength = 32767;
            this.twitchOAuth.Name = "twitchOAuth";
            this.twitchOAuth.PasswordChar = '*';
            this.twitchOAuth.PromptText = "Token";
            this.twitchOAuth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.twitchOAuth.SelectedText = "";
            this.twitchOAuth.SelectionLength = 0;
            this.twitchOAuth.SelectionStart = 0;
            this.twitchOAuth.ShortcutsEnabled = true;
            this.twitchOAuth.Size = new System.Drawing.Size(171, 22);
            this.twitchOAuth.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.twitchOAuth.TabIndex = 3;
            this.twitchOAuth.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.poisonToolTip.SetToolTip(this.twitchOAuth, "Textbox Tooltip");
            this.twitchOAuth.UseSelectable = true;
            this.twitchOAuth.WaterMark = "Token";
            this.twitchOAuth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.twitchOAuth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // poisonStyleManager
            // 
            this.poisonStyleManager.Owner = this;
            this.poisonStyleManager.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonStyleManager.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonToolTip
            // 
            this.poisonToolTip.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.poisonToolTip.StyleManager = null;
            this.poisonToolTip.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonStyleExtender
            // 
            this.poisonStyleExtender.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(10, 10);
            this.materialCheckBox1.TabIndex = 0;
            this.materialCheckBox1.Text = "Log";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(10, 10);
            this.materialCheckBox2.TabIndex = 0;
            this.materialCheckBox2.Text = "Log1";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // addNewCommand
            // 
            this.addNewCommand.Location = new System.Drawing.Point(3, 237);
            this.addNewCommand.Name = "addNewCommand";
            this.addNewCommand.Size = new System.Drawing.Size(137, 23);
            this.addNewCommand.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.addNewCommand.TabIndex = 3;
            this.addNewCommand.Text = "✙ Add New Command";
            this.addNewCommand.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.addNewCommand.UseSelectable = true;
            this.addNewCommand.Click += new System.EventHandler(this.addNewCommand_Click);
            // 
            // MainPanel
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackImagePadding = new System.Windows.Forms.Padding(210, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(720, 382);
            this.Controls.Add(this.poisonTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPanel";
            this.Resizable = false;
            this.ShadowType = ReaLTaiizor.Enum.Poison.FormShadowType.AeroShadow;
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.StyleManager = this.poisonStyleManager;
            this.Text = "VRC Twitch Integration";
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.poisonTabControl1.ResumeLayout(false);
            this.Tab0.ResumeLayout(false);
            this.Tab0.PerformLayout();
            this.poisonTabPage2.ResumeLayout(false);
            this.poisonTabPage4.ResumeLayout(false);
            this.poisonTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PoisonTabControl poisonTabControl1;
        private PoisonStyleManager poisonStyleManager;
        private PoisonTabPage Tab0;
        private PoisonToolTip poisonToolTip;
        private PoisonLabel poisonLabel1;
        private PoisonTabPage poisonTabPage3;
        private PoisonTabPage poisonTabPage4;
        private PoisonLabel poisonLabel8;
        private PoisonTextBox twitchOAuth;
        private PoisonLabel poisonLabel15;
        private PoisonStyleExtender poisonStyleExtender;
        private PoisonLabel twitchChatStatus;
        private PoisonLabel twitchPusSubStatus;
        private MaterialCheckBox materialCheckBox1;
        private PoisonLabel poisonLabel9;
        private MaterialCheckBox materialCheckBox2;
        private PoisonLabel poisonLabel23;
        private PoisonLabel version;
        private PoisonTabPage poisonTabPage2;
        private PoisonProgressSpinner chatSpinner;
        private PoisonProgressSpinner pubsubSpinner;
        private PoisonLabel poisonLabel2;
        private MetroSwitch debugSwitch;
        private FlowLayoutPanel commands;
        private FlowLayoutPanel consoleLogs;
        private PoisonButton addNewCommand;
    }
}
