namespace NewProject
{
    partial class SetUpConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUpConnect));
            this.IP = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.IA = new System.Windows.Forms.TextBox();
            this.PT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.BackColor = System.Drawing.Color.Transparent;
            this.IP.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IP.Location = new System.Drawing.Point(12, 21);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(130, 24);
            this.IP.TabIndex = 0;
            this.IP.Text = "IP Address";
            this.IP.Click += new System.EventHandler(this.IP_Click);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.BackColor = System.Drawing.Color.Transparent;
            this.Port.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Port.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Port.Location = new System.Drawing.Point(30, 81);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(58, 24);
            this.Port.TabIndex = 1;
            this.Port.Text = "Port";
            // 
            // IA
            // 
            this.IA.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IA.Location = new System.Drawing.Point(177, 21);
            this.IA.Name = "IA";
            this.IA.Size = new System.Drawing.Size(190, 31);
            this.IA.TabIndex = 2;
            this.IA.Text = "127.0.0.1";
            this.IA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IA.TextChanged += new System.EventHandler(this.IT_TextChanged);
            // 
            // PT
            // 
            this.PT.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PT.Location = new System.Drawing.Point(177, 81);
            this.PT.Name = "PT";
            this.PT.Size = new System.Drawing.Size(190, 31);
            this.PT.TabIndex = 3;
            this.PT.Text = "777";
            this.PT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 91);
            this.button1.TabIndex = 4;
            this.button1.Text = "設定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetUpConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(546, 137);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PT);
            this.Controls.Add(this.IA);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetUpConnect";
            this.Text = "SetUpConnect";
            this.Load += new System.EventHandler(this.SetUpConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox IA;
        private System.Windows.Forms.TextBox PT;
        private System.Windows.Forms.Button button1;
    }
}