namespace TwitchVrcAvatarOSC.Interface
{
    partial class ConsoleLog
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
            this.time = new ReaLTaiizor.Controls.PoisonLabel();
            this.type = new ReaLTaiizor.Controls.PoisonLabel();
            this.message = new ReaLTaiizor.Controls.PoisonLabel();
            this.tag = new ReaLTaiizor.Controls.PoisonLabel();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.ForeColor = System.Drawing.Color.Silver;
            this.time.Location = new System.Drawing.Point(0, 2);
            this.time.Name = "time";
            this.time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.time.Size = new System.Drawing.Size(57, 19);
            this.time.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.time.TabIndex = 0;
            this.time.Text = "00:00:00";
            this.time.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.time.UseCustomForeColor = true;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.type.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.type.ForeColor = System.Drawing.Color.Cyan;
            this.type.Location = new System.Drawing.Point(62, 2);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(54, 19);
            this.type.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.type.TabIndex = 1;
            this.type.Text = "ERROR";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.type.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.type.UseCustomForeColor = true;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.ForeColor = System.Drawing.Color.Silver;
            this.message.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.message.Location = new System.Drawing.Point(196, 2);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(60, 19);
            this.message.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.message.TabIndex = 2;
            this.message.Text = "Message";
            this.message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.message.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.message.UseCustomForeColor = true;
            // 
            // tag
            // 
            this.tag.AutoSize = true;
            this.tag.FontWeight = ReaLTaiizor.Extension.Poison.PoisonLabelWeight.Bold;
            this.tag.ForeColor = System.Drawing.Color.Fuchsia;
            this.tag.Location = new System.Drawing.Point(121, 2);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(74, 19);
            this.tag.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.tag.TabIndex = 3;
            this.tag.Text = "TwitchBot";
            this.tag.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.tag.UseCustomForeColor = true;
            // 
            // ConsoleLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tag);
            this.Controls.Add(this.message);
            this.Controls.Add(this.type);
            this.Controls.Add(this.time);
            this.Name = "ConsoleLog";
            this.Size = new System.Drawing.Size(460, 25);
            this.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Magenta;
            this.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonLabel time;
        private ReaLTaiizor.Controls.PoisonLabel type;
        private ReaLTaiizor.Controls.PoisonLabel message;
        private ReaLTaiizor.Controls.PoisonLabel tag;
    }
}
