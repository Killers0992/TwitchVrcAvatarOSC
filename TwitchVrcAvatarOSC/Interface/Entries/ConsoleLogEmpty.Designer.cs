namespace TwitchVrcAvatarOSC.Interface
{
    partial class ConsoleLogEmpty
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
            this.message = new ReaLTaiizor.Controls.PoisonLabel();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(196, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(60, 19);
            this.message.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.message.TabIndex = 0;
            this.message.Text = "Message";
            this.message.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.message.UseCustomForeColor = true;
            // 
            // ConsoleLogEmpty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.message);
            this.Name = "ConsoleLogEmpty";
            this.Size = new System.Drawing.Size(460, 25);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel message;
    }
}
