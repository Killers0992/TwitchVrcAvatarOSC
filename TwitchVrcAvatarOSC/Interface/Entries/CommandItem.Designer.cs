namespace TwitchVrcAvatarOSC.Interface
{
    partial class CommandItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.commandName = new ReaLTaiizor.Controls.PoisonTextBox();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            this.normalAccess = new ReaLTaiizor.Controls.ForeverToggle();
            this.streamerAccess = new ReaLTaiizor.Controls.ForeverToggle();
            this.subAccess = new ReaLTaiizor.Controls.ForeverToggle();
            this.vipAccess = new ReaLTaiizor.Controls.ForeverToggle();
            this.oscActions = new System.Windows.Forms.FlowLayoutPanel();
            this.newOscAction = new ReaLTaiizor.Controls.PoisonButton();
            this.random = new ReaLTaiizor.Controls.MetroSwitch();
            this.poisonLabel5 = new ReaLTaiizor.Controls.PoisonLabel();
            this.removeCommand = new ReaLTaiizor.Controls.PoisonButton();
            this.SuspendLayout();
            // 
            // commandName
            // 
            // 
            // 
            // 
            this.commandName.CustomButton.Image = null;
            this.commandName.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.commandName.CustomButton.Name = "";
            this.commandName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.commandName.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.commandName.CustomButton.TabIndex = 1;
            this.commandName.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.commandName.CustomButton.UseSelectable = true;
            this.commandName.CustomButton.Visible = false;
            this.commandName.Lines = new string[0];
            this.commandName.Location = new System.Drawing.Point(15, 13);
            this.commandName.MaxLength = 32767;
            this.commandName.Name = "commandName";
            this.commandName.PasswordChar = '\0';
            this.commandName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.commandName.SelectedText = "";
            this.commandName.SelectionLength = 0;
            this.commandName.SelectionStart = 0;
            this.commandName.ShortcutsEnabled = true;
            this.commandName.Size = new System.Drawing.Size(212, 23);
            this.commandName.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.commandName.TabIndex = 0;
            this.commandName.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.commandName.UseSelectable = true;
            this.commandName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.commandName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.poisonLabel1.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel1.Location = new System.Drawing.Point(15, 50);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(129, 25);
            this.poisonLabel1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel1.TabIndex = 2;
            this.poisonLabel1.Text = "Normal Access";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel2.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel2.Location = new System.Drawing.Point(15, 168);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(96, 25);
            this.poisonLabel2.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel2.TabIndex = 3;
            this.poisonLabel2.Text = "Vip Access";
            this.poisonLabel2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel3.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel3.Location = new System.Drawing.Point(15, 89);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(140, 25);
            this.poisonLabel3.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel3.TabIndex = 4;
            this.poisonLabel3.Text = "Streamer Access";
            this.poisonLabel3.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel4
            // 
            this.poisonLabel4.AutoSize = true;
            this.poisonLabel4.FontSize = ReaLTaiizor.Extension.Poison.PoisonLabelSize.Tall;
            this.poisonLabel4.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Regular;
            this.poisonLabel4.Location = new System.Drawing.Point(15, 128);
            this.poisonLabel4.Name = "poisonLabel4";
            this.poisonLabel4.Size = new System.Drawing.Size(101, 25);
            this.poisonLabel4.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel4.TabIndex = 5;
            this.poisonLabel4.Text = "Sub Access";
            this.poisonLabel4.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // normalAccess
            // 
            this.normalAccess.BackColor = System.Drawing.Color.Transparent;
            this.normalAccess.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.normalAccess.BaseColorRed = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.normalAccess.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.normalAccess.Checked = false;
            this.normalAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.normalAccess.Location = new System.Drawing.Point(156, 50);
            this.normalAccess.Name = "normalAccess";
            this.normalAccess.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.normalAccess.Size = new System.Drawing.Size(76, 33);
            this.normalAccess.TabIndex = 7;
            this.normalAccess.Text = "foreverToggle2";
            this.normalAccess.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.normalAccess.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            // 
            // streamerAccess
            // 
            this.streamerAccess.BackColor = System.Drawing.Color.Transparent;
            this.streamerAccess.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.streamerAccess.BaseColorRed = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.streamerAccess.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.streamerAccess.Checked = false;
            this.streamerAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streamerAccess.Location = new System.Drawing.Point(156, 89);
            this.streamerAccess.Name = "streamerAccess";
            this.streamerAccess.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.streamerAccess.Size = new System.Drawing.Size(76, 33);
            this.streamerAccess.TabIndex = 8;
            this.streamerAccess.Text = "foreverToggle1";
            this.streamerAccess.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.streamerAccess.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            // 
            // subAccess
            // 
            this.subAccess.BackColor = System.Drawing.Color.Transparent;
            this.subAccess.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.subAccess.BaseColorRed = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.subAccess.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.subAccess.Checked = false;
            this.subAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subAccess.Location = new System.Drawing.Point(156, 128);
            this.subAccess.Name = "subAccess";
            this.subAccess.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.subAccess.Size = new System.Drawing.Size(76, 33);
            this.subAccess.TabIndex = 9;
            this.subAccess.Text = "foreverToggle3";
            this.subAccess.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.subAccess.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            // 
            // vipAccess
            // 
            this.vipAccess.BackColor = System.Drawing.Color.Transparent;
            this.vipAccess.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.vipAccess.BaseColorRed = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.vipAccess.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(85)))), ((int)(((byte)(86)))));
            this.vipAccess.Checked = false;
            this.vipAccess.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vipAccess.Location = new System.Drawing.Point(156, 168);
            this.vipAccess.Name = "vipAccess";
            this.vipAccess.Options = ReaLTaiizor.Controls.ForeverToggle._Options.Style1;
            this.vipAccess.Size = new System.Drawing.Size(76, 33);
            this.vipAccess.TabIndex = 10;
            this.vipAccess.Text = "foreverToggle4";
            this.vipAccess.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.vipAccess.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            // 
            // oscActions
            // 
            this.oscActions.AutoScroll = true;
            this.oscActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oscActions.BackColor = System.Drawing.Color.Transparent;
            this.oscActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oscActions.Location = new System.Drawing.Point(319, -1);
            this.oscActions.Name = "oscActions";
            this.oscActions.Size = new System.Drawing.Size(288, 180);
            this.oscActions.TabIndex = 11;
            // 
            // newOscAction
            // 
            this.newOscAction.Location = new System.Drawing.Point(319, 182);
            this.newOscAction.Name = "newOscAction";
            this.newOscAction.Size = new System.Drawing.Size(114, 23);
            this.newOscAction.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.newOscAction.TabIndex = 0;
            this.newOscAction.Text = "✙ Add OSC Action";
            this.newOscAction.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.newOscAction.UseSelectable = true;
            this.newOscAction.Click += new System.EventHandler(this.newOscAction_Click);
            // 
            // random
            // 
            this.random.BackColor = System.Drawing.Color.Transparent;
            this.random.BackgroundColor = System.Drawing.Color.Empty;
            this.random.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.random.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.random.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.random.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.random.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.random.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.random.IsDerivedStyle = true;
            this.random.Location = new System.Drawing.Point(548, 181);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(58, 22);
            this.random.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.random.StyleManager = null;
            this.random.Switched = false;
            this.random.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.random.TabIndex = 0;
            this.random.Text = "metroSwitch1";
            this.random.ThemeAuthor = "Taiizor";
            this.random.ThemeName = "MetroLight";
            this.random.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // poisonLabel5
            // 
            this.poisonLabel5.AutoSize = true;
            this.poisonLabel5.Location = new System.Drawing.Point(484, 182);
            this.poisonLabel5.Name = "poisonLabel5";
            this.poisonLabel5.Size = new System.Drawing.Size(59, 19);
            this.poisonLabel5.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel5.TabIndex = 12;
            this.poisonLabel5.Text = "Random";
            this.poisonLabel5.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // removeCommand
            // 
            this.removeCommand.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            this.removeCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeCommand.Location = new System.Drawing.Point(611, -1);
            this.removeCommand.Name = "removeCommand";
            this.removeCommand.Size = new System.Drawing.Size(35, 26);
            this.removeCommand.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.removeCommand.TabIndex = 13;
            this.removeCommand.Text = "❌";
            this.removeCommand.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.removeCommand.UseCustomForeColor = true;
            this.removeCommand.UseSelectable = true;
            this.removeCommand.Click += new System.EventHandler(this.removeCommand_Click);
            // 
            // CommandItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.removeCommand);
            this.Controls.Add(this.poisonLabel5);
            this.Controls.Add(this.random);
            this.Controls.Add(this.newOscAction);
            this.Controls.Add(this.oscActions);
            this.Controls.Add(this.vipAccess);
            this.Controls.Add(this.subAccess);
            this.Controls.Add(this.streamerAccess);
            this.Controls.Add(this.normalAccess);
            this.Controls.Add(this.poisonLabel4);
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.poisonLabel2);
            this.Controls.Add(this.poisonLabel1);
            this.Controls.Add(this.commandName);
            this.Name = "CommandItem";
            this.Size = new System.Drawing.Size(649, 204);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTextBox commandName;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel4;
        private ReaLTaiizor.Controls.ForeverToggle normalAccess;
        private ReaLTaiizor.Controls.ForeverToggle streamerAccess;
        private ReaLTaiizor.Controls.ForeverToggle subAccess;
        private ReaLTaiizor.Controls.ForeverToggle vipAccess;
        private FlowLayoutPanel oscActions;
        private ReaLTaiizor.Controls.PoisonButton newOscAction;
        private ReaLTaiizor.Controls.MetroSwitch random;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel5;
        private ReaLTaiizor.Controls.PoisonButton removeCommand;
    }
}
