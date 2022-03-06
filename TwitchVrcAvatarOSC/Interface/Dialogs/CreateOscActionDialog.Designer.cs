namespace TwitchVrcAvatarOSC.Interface.Dialogs
{
    partial class CreateOscActionDialog
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
            this.actionName = new ReaLTaiizor.Controls.PoisonTextBox();
            this.poisonLabel1 = new ReaLTaiizor.Controls.PoisonLabel();
            this.executionDuration = new ReaLTaiizor.Controls.ForeverNumeric();
            this.poisonLabel2 = new ReaLTaiizor.Controls.PoisonLabel();
            this.value = new ReaLTaiizor.Controls.PoisonTextBox();
            this.defaultValue = new ReaLTaiizor.Controls.PoisonTextBox();
            this.poisonLabel3 = new ReaLTaiizor.Controls.PoisonLabel();
            this.poisonLabel4 = new ReaLTaiizor.Controls.PoisonLabel();
            this.confirmButton = new ReaLTaiizor.Controls.Button();
            this.cancelButton = new ReaLTaiizor.Controls.Button();
            this.SuspendLayout();
            // 
            // actionName
            // 
            // 
            // 
            // 
            this.actionName.CustomButton.Image = null;
            this.actionName.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.actionName.CustomButton.Name = "";
            this.actionName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.actionName.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.actionName.CustomButton.TabIndex = 1;
            this.actionName.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.actionName.CustomButton.UseSelectable = true;
            this.actionName.CustomButton.Visible = false;
            this.actionName.Lines = new string[0];
            this.actionName.Location = new System.Drawing.Point(23, 19);
            this.actionName.MaxLength = 32767;
            this.actionName.Name = "actionName";
            this.actionName.PasswordChar = '\0';
            this.actionName.PromptText = "VRC Paramater name...";
            this.actionName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.actionName.SelectedText = "";
            this.actionName.SelectionLength = 0;
            this.actionName.SelectionStart = 0;
            this.actionName.ShortcutsEnabled = true;
            this.actionName.Size = new System.Drawing.Size(170, 23);
            this.actionName.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.actionName.TabIndex = 0;
            this.actionName.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.actionName.UseSelectable = true;
            this.actionName.WaterMark = "VRC Paramater name...";
            this.actionName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.actionName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(23, -3);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(86, 19);
            this.poisonLabel1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel1.TabIndex = 1;
            this.poisonLabel1.Text = "Action Name";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // executionDuration
            // 
            this.executionDuration.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.executionDuration.ButtonColorA = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.executionDuration.ButtonColorB = System.Drawing.Color.White;
            this.executionDuration.ButtonColorC = System.Drawing.Color.White;
            this.executionDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.executionDuration.ForeColor = System.Drawing.Color.Silver;
            this.executionDuration.Location = new System.Drawing.Point(149, 50);
            this.executionDuration.Maximum = ((long)(100));
            this.executionDuration.Minimum = ((long)(0));
            this.executionDuration.Name = "executionDuration";
            this.executionDuration.Size = new System.Drawing.Size(75, 30);
            this.executionDuration.TabIndex = 2;
            this.executionDuration.Text = "foreverNumeric1";
            this.executionDuration.Value = ((long)(0));
            // 
            // poisonLabel2
            // 
            this.poisonLabel2.AutoSize = true;
            this.poisonLabel2.Location = new System.Drawing.Point(23, 56);
            this.poisonLabel2.Name = "poisonLabel2";
            this.poisonLabel2.Size = new System.Drawing.Size(266, 19);
            this.poisonLabel2.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel2.TabIndex = 3;
            this.poisonLabel2.Text = "Execution duration                         seconds.";
            this.poisonLabel2.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // value
            // 
            // 
            // 
            // 
            this.value.CustomButton.Image = null;
            this.value.CustomButton.Location = new System.Drawing.Point(84, 1);
            this.value.CustomButton.Name = "";
            this.value.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.value.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.value.CustomButton.TabIndex = 1;
            this.value.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.value.CustomButton.UseSelectable = true;
            this.value.CustomButton.Visible = false;
            this.value.Lines = new string[0];
            this.value.Location = new System.Drawing.Point(118, 100);
            this.value.MaxLength = 32767;
            this.value.Name = "value";
            this.value.PasswordChar = '\0';
            this.value.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.value.SelectedText = "";
            this.value.SelectionLength = 0;
            this.value.SelectionStart = 0;
            this.value.ShortcutsEnabled = true;
            this.value.Size = new System.Drawing.Size(106, 23);
            this.value.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.value.TabIndex = 4;
            this.value.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.value.UseSelectable = true;
            this.value.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.value.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // defaultValue
            // 
            // 
            // 
            // 
            this.defaultValue.CustomButton.Image = null;
            this.defaultValue.CustomButton.Location = new System.Drawing.Point(84, 1);
            this.defaultValue.CustomButton.Name = "";
            this.defaultValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.defaultValue.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.defaultValue.CustomButton.TabIndex = 1;
            this.defaultValue.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.defaultValue.CustomButton.UseSelectable = true;
            this.defaultValue.CustomButton.Visible = false;
            this.defaultValue.Lines = new string[0];
            this.defaultValue.Location = new System.Drawing.Point(118, 143);
            this.defaultValue.MaxLength = 32767;
            this.defaultValue.Name = "defaultValue";
            this.defaultValue.PasswordChar = '\0';
            this.defaultValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.defaultValue.SelectedText = "";
            this.defaultValue.SelectionLength = 0;
            this.defaultValue.SelectionStart = 0;
            this.defaultValue.ShortcutsEnabled = true;
            this.defaultValue.Size = new System.Drawing.Size(106, 23);
            this.defaultValue.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.defaultValue.TabIndex = 5;
            this.defaultValue.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.defaultValue.UseSelectable = true;
            this.defaultValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.defaultValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // poisonLabel3
            // 
            this.poisonLabel3.AutoSize = true;
            this.poisonLabel3.Location = new System.Drawing.Point(23, 100);
            this.poisonLabel3.Name = "poisonLabel3";
            this.poisonLabel3.Size = new System.Drawing.Size(39, 19);
            this.poisonLabel3.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel3.TabIndex = 6;
            this.poisonLabel3.Text = "Value";
            this.poisonLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.poisonLabel3.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // poisonLabel4
            // 
            this.poisonLabel4.AutoSize = true;
            this.poisonLabel4.Location = new System.Drawing.Point(23, 143);
            this.poisonLabel4.Name = "poisonLabel4";
            this.poisonLabel4.Size = new System.Drawing.Size(84, 19);
            this.poisonLabel4.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel4.TabIndex = 7;
            this.poisonLabel4.Text = "Default value";
            this.poisonLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.poisonLabel4.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.Image = null;
            this.confirmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmButton.InactiveColor = System.Drawing.Color.Lime;
            this.confirmButton.Location = new System.Drawing.Point(163, 172);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.confirmButton.Size = new System.Drawing.Size(120, 25);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Image = null;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButton.Location = new System.Drawing.Point(23, 173);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.cancelButton.Size = new System.Drawing.Size(120, 24);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateOscActionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.poisonLabel4);
            this.Controls.Add(this.poisonLabel3);
            this.Controls.Add(this.defaultValue);
            this.Controls.Add(this.value);
            this.Controls.Add(this.executionDuration);
            this.Controls.Add(this.poisonLabel2);
            this.Controls.Add(this.poisonLabel1);
            this.Controls.Add(this.actionName);
            this.Name = "CreateOscActionDialog";
            this.Size = new System.Drawing.Size(305, 212);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTextBox actionName;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.ForeverNumeric executionDuration;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel2;
        private ReaLTaiizor.Controls.PoisonTextBox value;
        private ReaLTaiizor.Controls.PoisonTextBox defaultValue;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel3;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel4;
        private ReaLTaiizor.Controls.Button confirmButton;
        private ReaLTaiizor.Controls.Button cancelButton;
    }
}
