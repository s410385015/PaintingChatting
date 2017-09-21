namespace NewProject
{
    partial class Gomoku
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gomoku));
            this.BLabel = new System.Windows.Forms.Label();
            this.Board = new System.Windows.Forms.PictureBox();
            this.WLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.LoseButton = new System.Windows.Forms.Button();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btime = new System.Windows.Forms.Label();
            this.Wtime = new System.Windows.Forms.Label();
            this.BReady = new System.Windows.Forms.Button();
            this.WReady = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.BackColor = System.Drawing.Color.Transparent;
            this.BLabel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BLabel.ForeColor = System.Drawing.Color.White;
            this.BLabel.Location = new System.Drawing.Point(703, 134);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(69, 20);
            this.BLabel.TabIndex = 1;
            this.BLabel.Text = "label1";
            this.BLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Board
            // 
            this.Board.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Board.BackgroundImage")));
            this.Board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Board.Location = new System.Drawing.Point(33, 29);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(650, 640);
            this.Board.TabIndex = 0;
            this.Board.TabStop = false;
            this.Board.Click += new System.EventHandler(this.Board_Click);
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WLabel.ForeColor = System.Drawing.Color.White;
            this.WLabel.Location = new System.Drawing.Point(706, 262);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(69, 20);
            this.WLabel.TabIndex = 2;
            this.WLabel.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(707, 433);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(366, 151);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(707, 613);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(998, 613);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 25);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "傳送";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(707, 659);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(84, 24);
            this.DrawButton.TabIndex = 6;
            this.DrawButton.Text = "求和(3)";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // LoseButton
            // 
            this.LoseButton.Location = new System.Drawing.Point(815, 659);
            this.LoseButton.Name = "LoseButton";
            this.LoseButton.Size = new System.Drawing.Size(84, 24);
            this.LoseButton.TabIndex = 7;
            this.LoseButton.Text = "投降";
            this.LoseButton.UseVisualStyleBackColor = true;
            this.LoseButton.Click += new System.EventHandler(this.LoseButton_Click);
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(927, 659);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(84, 24);
            this.LeaveButton.TabIndex = 8;
            this.LeaveButton.Text = "離開";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btime
            // 
            this.Btime.AutoSize = true;
            this.Btime.BackColor = System.Drawing.Color.Transparent;
            this.Btime.ForeColor = System.Drawing.Color.White;
            this.Btime.Location = new System.Drawing.Point(707, 77);
            this.Btime.Name = "Btime";
            this.Btime.Size = new System.Drawing.Size(0, 15);
            this.Btime.TabIndex = 9;
            // 
            // Wtime
            // 
            this.Wtime.AutoSize = true;
            this.Wtime.ForeColor = System.Drawing.Color.White;
            this.Wtime.Location = new System.Drawing.Point(704, 283);
            this.Wtime.Name = "Wtime";
            this.Wtime.Size = new System.Drawing.Size(0, 15);
            this.Wtime.TabIndex = 10;
            this.Wtime.Click += new System.EventHandler(this.Wtime_Click);
            // 
            // BReady
            // 
            this.BReady.Location = new System.Drawing.Point(707, 157);
            this.BReady.Name = "BReady";
            this.BReady.Size = new System.Drawing.Size(94, 23);
            this.BReady.TabIndex = 11;
            this.BReady.Text = "準備完畢";
            this.BReady.UseVisualStyleBackColor = true;
            this.BReady.Click += new System.EventHandler(this.BReady_Click);
            // 
            // WReady
            // 
            this.WReady.Location = new System.Drawing.Point(710, 285);
            this.WReady.Name = "WReady";
            this.WReady.Size = new System.Drawing.Size(94, 23);
            this.WReady.TabIndex = 12;
            this.WReady.Text = "準備完畢";
            this.WReady.UseVisualStyleBackColor = true;
            this.WReady.Click += new System.EventHandler(this.WReady_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(707, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(710, 239);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 20);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // Gomoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1119, 696);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WReady);
            this.Controls.Add(this.BReady);
            this.Controls.Add(this.Wtime);
            this.Controls.Add(this.Btime);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.LoseButton);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.WLabel);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.Board);
            this.Name = "Gomoku";
            this.Text = "Gomoku";
            this.Load += new System.EventHandler(this.Gomoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Board;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label WLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button LoseButton;
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Btime;
        private System.Windows.Forms.Label Wtime;
        private System.Windows.Forms.Button BReady;
        private System.Windows.Forms.Button WReady;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}