namespace TwitchVrcAvatarOSC.Interface.Dialogs
{
    partial class CreateCommandDialog
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
            this.actionName.PromptText = "Name without spaces.";
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
            this.actionName.WaterMark = "Name without spaces.";
            this.actionName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.actionName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // poisonLabel1
            // 
            this.poisonLabel1.AutoSize = true;
            this.poisonLabel1.Location = new System.Drawing.Point(23, -3);
            this.poisonLabel1.Name = "poisonLabel1";
            this.poisonLabel1.Size = new System.Drawing.Size(112, 19);
            this.poisonLabel1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.poisonLabel1.TabIndex = 1;
            this.poisonLabel1.Text = "Command Name";
            this.poisonLabel1.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.Image = null;
            this.confirmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmButton.InactiveColor = System.Drawing.Color.Lime;
            this.confirmButton.Location = new System.Drawing.Point(163, 66);
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
            this.cancelButton.Location = new System.Drawing.Point(23, 67);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.cancelButton.Size = new System.Drawing.Size(120, 24);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateCommandDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.poisonLabel1);
            this.Controls.Add(this.actionName);
            this.Name = "CreateCommandDialog";
            this.Size = new System.Drawing.Size(305, 109);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTextBox actionName;
        private ReaLTaiizor.Controls.PoisonLabel poisonLabel1;
        private ReaLTaiizor.Controls.Button confirmButton;
        private ReaLTaiizor.Controls.Button cancelButton;
    }
}
