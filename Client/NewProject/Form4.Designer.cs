namespace NewProject
{
    partial class WF
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WF));
            this.s = new System.Windows.Forms.Button();
            this.ToUser = new System.Windows.Forms.Label();
            this.whisper = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.Black;
            this.s.Location = new System.Drawing.Point(341, 79);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(75, 23);
            this.s.TabIndex = 0;
            this.s.Text = "送出";
            this.s.UseVisualStyleBackColor = false;
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // ToUser
            // 
            this.ToUser.AutoSize = true;
            this.ToUser.BackColor = System.Drawing.Color.Transparent;
            this.ToUser.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ToUser.ForeColor = System.Drawing.Color.White;
            this.ToUser.Location = new System.Drawing.Point(12, 9);
            this.ToUser.Name = "ToUser";
            this.ToUser.Size = new System.Drawing.Size(88, 24);
            this.ToUser.TabIndex = 2;
            this.ToUser.Text = "label1";
            // 
            // whisper
            // 
            this.whisper.Font = new System.Drawing.Font("標楷體", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.whisper.Location = new System.Drawing.Point(12, 40);
            this.whisper.Name = "whisper";
            this.whisper.Size = new System.Drawing.Size(404, 28);
            this.whisper.TabIndex = 3;
            this.whisper.KeyDown += new System.Windows.Forms.KeyEventHandler(this.whisper_KeyDown);
            // 
            // WF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(452, 117);
            this.Controls.Add(this.whisper);
            this.Controls.Add(this.ToUser);
            this.Controls.Add(this.s);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "密語";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WF_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Label ToUser;
        private System.Windows.Forms.TextBox whisper;
    }
}