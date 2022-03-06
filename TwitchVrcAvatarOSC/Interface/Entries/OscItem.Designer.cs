namespace TwitchVrcAvatarOSC.Interface
{
    partial class OscItem
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
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.actionName = new ReaLTaiizor.Controls.PoisonTextBox();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.executionDuration = new ReaLTaiizor.Controls.ForeverNumeric();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            this.oscValue = new ReaLTaiizor.Controls.PoisonTextBox();
            this.defaultValue = new ReaLTaiizor.Controls.PoisonTextBox();
            this.removeAction = new ReaLTaiizor.Controls.PoisonButton();
            this.SuspendLayout();
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(3, 9);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(83, 19);
            this.poisonLabel1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel1.TabIndex = 0;
            this.poisonLabel1.Text = "Action name";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // actionName
            // 
            // 
            // 
            // 
            this.actionName.CustomButton.Image = null;
            this.actionName.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.actionName.CustomButton.Name = "";
            this.actionName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.actionName.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.actionName.CustomButton.TabIndex = 1;
            this.actionName.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.actionName.CustomButton.UseSelectable = true;
            this.actionName.CustomButton.Visible = false;
            this.actionName.Lines = new string[0];
            this.actionName.Location = new System.Drawing.Point(3, 40);
            this.actionName.MaxLength = 32767;
            this.actionName.Name = "actionName";
            this.actionName.PasswordChar = '\0';
            this.actionName.PromptText = "VRC Paramater name...";
            this.actionName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.actionName.SelectedText = "";
            this.actionName.SelectionLength = 0;
            this.actionName.SelectionStart = 0;
            this.actionName.ShortcutsEnabled = true;
            this.actionName.Size = new System.Drawing.Size(255, 23);
            this.actionName.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.actionName.TabIndex = 1;
            this.actionName.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.actionName.UseSelectable = true;
            this.actionName.WaterMark = "VRC Paramater name...";
            this.actionName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.actionName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.Location = new System.Drawing.Point(0, 88);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(266, 19);
            this.poisonLabel2.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel2.TabIndex = 2;
            this.poisonLabel2.Text = "Execution duration                         seconds.";
            this.poisonLabel2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // executionDuration
            // 
            this.executionDuration.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.executionDuration.ButtonColorA = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.executionDuration.ButtonColorB = System.Drawing.Color.White;
            this.executionDuration.ButtonColorC = System.Drawing.Color.White;
            this.executionDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.executionDuration.ForeColor = System.Drawing.Color.Silver;
            this.executionDuration.Location = new System.Drawing.Point(129, 77);
            this.executionDuration.Maximum = ((long)(100));
            this.executionDuration.Minimum = ((long)(0));
            this.executionDuration.Name = "executionDuration";
            this.executionDuration.Size = new System.Drawing.Size(68, 30);
            this.executionDuration.TabIndex = 3;
            this.executionDuration.Text = "foreverNumeric1";
            this.executionDuration.Value = ((long)(0));
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.Location = new System.Drawing.Point(5, 113);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(39, 19);
            this.poisonLabel3.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel3.TabIndex = 4;
            this.poisonLabel3.Text = "Value";
            this.poisonLabel3.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel4
            // 
            this.poisonLabel4.AutoSize = true;
            this.poisonLabel4.Location = new System.Drawing.Point(5, 142);
            this.poisonLabel4.Name = "poisonLabel4";
            this.poisonLabel4.Size = new System.Drawing.Size(84, 19);
            this.poisonLabel4.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel4.TabIndex = 5;
            this.poisonLabel4.Text = "Default value";
            this.poisonLabel4.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // oscValue
            // 
            // 
            // 
            // 
            this.oscValue.CustomButton.Image = null;
            this.oscValue.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.oscValue.CustomButton.Name = "";
            this.oscValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.oscValue.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.oscValue.CustomButton.TabIndex = 1;
            this.oscValue.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.oscValue.CustomButton.UseSelectable = true;
            this.oscValue.CustomButton.Visible = false;
            this.oscValue.Lines = new string[0];
            this.oscValue.Location = new System.Drawing.Point(124, 113);
            this.oscValue.MaxLength = 32767;
            this.oscValue.Name = "oscValue";
            this.oscValue.PasswordChar = '\0';
            this.oscValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oscValue.SelectedText = "";
            this.oscValue.SelectionLength = 0;
            this.oscValue.SelectionStart = 0;
            this.oscValue.ShortcutsEnabled = true;
            this.oscValue.Size = new System.Drawing.Size(136, 23);
            this.oscValue.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.oscValue.TabIndex = 6;
            this.oscValue.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.oscValue.UseSelectable = true;
            this.oscValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.oscValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // defaultValue
            // 
            // 
            // 
            // 
            this.defaultValue.CustomButton.Image = null;
            this.defaultValue.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.defaultValue.CustomButton.Name = "";
            this.defaultValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.defaultValue.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.defaultValue.CustomButton.TabIndex = 1;
            this.defaultValue.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.defaultValue.CustomButton.UseSelectable = true;
            this.defaultValue.CustomButton.Visible = false;
            this.defaultValue.Lines = new string[0];
            this.defaultValue.Location = new System.Drawing.Point(124, 143);
            this.defaultValue.MaxLength = 32767;
            this.defaultValue.Name = "defaultValue";
            this.defaultValue.PasswordChar = '\0';
            this.defaultValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.defaultValue.SelectedText = "";
            this.defaultValue.SelectionLength = 0;
            this.defaultValue.SelectionStart = 0;
            this.defaultValue.ShortcutsEnabled = true;
            this.defaultValue.Size = new System.Drawing.Size(136, 23);
            this.defaultValue.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.defaultValue.TabIndex = 7;
            this.defaultValue.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.defaultValue.UseSelectable = true;
            this.defaultValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.defaultValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // removeAction
            // 
            this.removeAction.FontSize = ReaLTaiizor.Extension.Poison.PoisonButtonSize.Tall;
            this.removeAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeAction.Location = new System.Drawing.Point(226, 0);
            this.removeAction.Name = "removeAction";
            this.removeAction.Size = new System.Drawing.Size(35, 35);
            this.removeAction.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.removeAction.TabIndex = 8;
            this.removeAction.Text = "❌";
            this.removeAction.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.removeAction.UseCustomForeColor = true;
            this.removeAction.UseSelectable = true;
            this.removeAction.Click += new System.EventHandler(this.removeAction_Click);
            // 
            // OscItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeAction);
            this.Controls.Add(this.defaultValue);
            this.Controls.Add(this.oscValue);
            this.Controls.Add(this.poisonLabel4);
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.executionDuration);
            this.Controls.Add(this.poisonLabel2);
            this.Controls.Add(this.actionName);
            this.Controls.Add(this.poisonLabel1);
            this.Name = "OscItem";
            this.Size = new System.Drawing.Size(263, 180);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.PoisonTextBox actionName;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.ForeverNumeric executionDuration;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel4;
        private ReaLTaiizor.Controls.PoisonTextBox oscValue;
        private ReaLTaiizor.Controls.PoisonTextBox defaultValue;
        private ReaLTaiizor.Controls.PoisonButton removeAction;
    }
}
