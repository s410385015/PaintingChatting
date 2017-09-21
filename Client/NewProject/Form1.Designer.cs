namespace NewProject
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Box = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ChooseColor = new System.Windows.Forms.ColorDialog();
            this.ColorBox = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.CheckDraw = new System.Windows.Forms.CheckBox();
            this.ToolList = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.跑馬燈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.傳送圖片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.UserBox = new System.Windows.Forms.ListBox();
            this.UsesOpt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.戳一下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.黑名單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解除黑名單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PTotal = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.WorkerToSend = new System.ComponentModel.BackgroundWorker();
            this.邀請下棋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawBox = new NewProject.UserControl1();
            this.Game5p = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.ToolList.SuspendLayout();
            this.UsesOpt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.Color.White;
            this.Box.EnableAutoDragDrop = true;
            this.Box.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Box.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Box.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Box.Location = new System.Drawing.Point(45, 83);
            this.Box.Name = "Box";
            this.Box.ReadOnly = true;
            this.Box.Size = new System.Drawing.Size(859, 422);
            this.Box.TabIndex = 0;
            this.Box.Text = "";
            this.Box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Box_MouseClick);
            this.Box.TextChanged += new System.EventHandler(this.Box_TextChanged);
            this.Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Box_KeyDown);
            this.Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(49, 544);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(668, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(732, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "送出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.Color.Black;
            this.ColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorBox.Location = new System.Drawing.Point(638, 37);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(40, 40);
            this.ColorBox.TabIndex = 4;
            this.ColorBox.TabStop = false;
            this.ColorBox.Click += new System.EventHandler(this.ColorBox_Click);
            this.ColorBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ColorBox_MouseClick);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.Azure;
            this.trackBar1.Location = new System.Drawing.Point(745, 37);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(213, 40);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // CheckDraw
            // 
            this.CheckDraw.AutoSize = true;
            this.CheckDraw.BackColor = System.Drawing.Color.Transparent;
            this.CheckDraw.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckDraw.ForeColor = System.Drawing.Color.Transparent;
            this.CheckDraw.Location = new System.Drawing.Point(883, 542);
            this.CheckDraw.Name = "CheckDraw";
            this.CheckDraw.Size = new System.Drawing.Size(97, 34);
            this.CheckDraw.TabIndex = 6;
            this.CheckDraw.Text = "塗鴉";
            this.CheckDraw.UseVisualStyleBackColor = false;
            this.CheckDraw.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ToolList
            // 
            this.ToolList.BackColor = System.Drawing.Color.Transparent;
            this.ToolList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.ToolList.Location = new System.Drawing.Point(0, 0);
            this.ToolList.Name = "ToolList";
            this.ToolList.Size = new System.Drawing.Size(1163, 27);
            this.ToolList.TabIndex = 7;
            this.ToolList.Text = "toolStrip1";
            this.ToolList.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.跑馬燈ToolStripMenuItem,
            this.傳送圖片ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.設定ToolStripMenuItem,
            this.Logout});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // 跑馬燈ToolStripMenuItem
            // 
            this.跑馬燈ToolStripMenuItem.Name = "跑馬燈ToolStripMenuItem";
            this.跑馬燈ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.跑馬燈ToolStripMenuItem.Text = "跑馬燈";
            this.跑馬燈ToolStripMenuItem.Click += new System.EventHandler(this.跑馬燈ToolStripMenuItem_Click);
            // 
            // 傳送圖片ToolStripMenuItem
            // 
            this.傳送圖片ToolStripMenuItem.Name = "傳送圖片ToolStripMenuItem";
            this.傳送圖片ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.傳送圖片ToolStripMenuItem.Text = "傳送圖片";
            this.傳送圖片ToolStripMenuItem.Click += new System.EventHandler(this.傳送圖片ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItem2.Text = "黑名單";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(144, 26);
            this.Logout.Text = "登出";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // UserBox
            // 
            this.UserBox.BackColor = System.Drawing.Color.White;
            this.UserBox.ContextMenuStrip = this.UsesOpt;
            this.UserBox.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UserBox.FormattingEnabled = true;
            this.UserBox.ItemHeight = 23;
            this.UserBox.Location = new System.Drawing.Point(941, 110);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(167, 395);
            this.UserBox.TabIndex = 8;
            this.UserBox.Click += new System.EventHandler(this.UserBox_Click);
            this.UserBox.SelectedIndexChanged += new System.EventHandler(this.UserBox_SelectedIndexChanged);
            // 
            // UsesOpt
            // 
            this.UsesOpt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.UsesOpt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.戳一下ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.黑名單ToolStripMenuItem,
            this.解除黑名單ToolStripMenuItem,
            this.邀請下棋ToolStripMenuItem});
            this.UsesOpt.Name = "UsesOpt";
            this.UsesOpt.Size = new System.Drawing.Size(160, 134);
            // 
            // 戳一下ToolStripMenuItem
            // 
            this.戳一下ToolStripMenuItem.Name = "戳一下ToolStripMenuItem";
            this.戳一下ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.戳一下ToolStripMenuItem.Text = "戳一下";
            this.戳一下ToolStripMenuItem.Click += new System.EventHandler(this.戳一下ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.toolStripMenuItem1.Text = "密語";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 黑名單ToolStripMenuItem
            // 
            this.黑名單ToolStripMenuItem.Name = "黑名單ToolStripMenuItem";
            this.黑名單ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.黑名單ToolStripMenuItem.Text = "加入黑名單";
            this.黑名單ToolStripMenuItem.Click += new System.EventHandler(this.黑名單ToolStripMenuItem_Click);
            // 
            // 解除黑名單ToolStripMenuItem
            // 
            this.解除黑名單ToolStripMenuItem.Name = "解除黑名單ToolStripMenuItem";
            this.解除黑名單ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.解除黑名單ToolStripMenuItem.Text = "解除黑名單";
            this.解除黑名單ToolStripMenuItem.Click += new System.EventHandler(this.解除黑名單ToolStripMenuItem_Click);
            // 
            // PTotal
            // 
            this.PTotal.AutoSize = true;
            this.PTotal.BackColor = System.Drawing.Color.Transparent;
            this.PTotal.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PTotal.Location = new System.Drawing.Point(937, 83);
            this.PTotal.Name = "PTotal";
            this.PTotal.Size = new System.Drawing.Size(136, 24);
            this.PTotal.TabIndex = 9;
            this.PTotal.Text = "總人數:0人";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MLabel
            // 
            this.MLabel.AutoSize = true;
            this.MLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.MLabel.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MLabel.Location = new System.Drawing.Point(47, 40);
            this.MLabel.Name = "MLabel";
            this.MLabel.Size = new System.Drawing.Size(122, 40);
            this.MLabel.TabIndex = 12;
            this.MLabel.Text = "Label";
            this.MLabel.Click += new System.EventHandler(this.MLabel_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(1003, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "傳送圖片";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WorkerToSend
            // 
            this.WorkerToSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerToSend_DoWork);
            // 
            // 邀請下棋ToolStripMenuItem
            // 
            this.邀請下棋ToolStripMenuItem.Name = "邀請下棋ToolStripMenuItem";
            this.邀請下棋ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.邀請下棋ToolStripMenuItem.Text = "邀請下棋";
            this.邀請下棋ToolStripMenuItem.Click += new System.EventHandler(this.邀請下棋ToolStripMenuItem_Click);
            // 
            // DrawBox
            // 
            this.DrawBox.BackColor = System.Drawing.Color.Transparent;
            this.DrawBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawBox.Location = new System.Drawing.Point(45, 83);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(859, 422);
            this.DrawBox.TabIndex = 3;
            this.DrawBox.Load += new System.EventHandler(this.DrawBox_Load);
            this.DrawBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrawBox_KeyDown);
            this.DrawBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrawBox_KeyPress);
            this.DrawBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseDown);
            this.DrawBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseMove);
            this.DrawBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseUp);
            // 
            // Game5p
            // 
            this.Game5p.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Game5p_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 612);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MLabel);
            this.Controls.Add(this.PTotal);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.ToolList);
            this.Controls.Add(this.CheckDraw);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.DrawBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "塗鴉聊天";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ToolList.ResumeLayout(false);
            this.ToolList.PerformLayout();
            this.UsesOpt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private UserControl1 DrawBox;
        private System.Windows.Forms.ColorDialog ChooseColor;
        private System.Windows.Forms.PictureBox ColorBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox CheckDraw;
        private System.Windows.Forms.ToolStrip ToolList;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.ListBox UserBox;
        private System.Windows.Forms.Label PTotal;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ContextMenuStrip UsesOpt;
        private System.Windows.Forms.ToolStripMenuItem 戳一下ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MLabel;
        private System.Windows.Forms.ToolStripMenuItem 跑馬燈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker WorkerToSend;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 傳送圖片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑名單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 解除黑名單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 邀請下棋ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker Game5p;
    }
}

