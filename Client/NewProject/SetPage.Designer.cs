namespace NewProject
{
    partial class SetPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPage));
            this.CheckWis = new System.Windows.Forms.CheckBox();
            this.CheckPoke = new System.Windows.Forms.CheckBox();
            this.CheckImg = new System.Windows.Forms.CheckBox();
            this.ColorPlate = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.PenSize = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GameInvite = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckWis
            // 
            this.CheckWis.AutoSize = true;
            this.CheckWis.BackColor = System.Drawing.Color.Transparent;
            this.CheckWis.Checked = true;
            this.CheckWis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckWis.ForeColor = System.Drawing.Color.White;
            this.CheckWis.Location = new System.Drawing.Point(39, 43);
            this.CheckWis.Name = "CheckWis";
            this.CheckWis.Size = new System.Drawing.Size(89, 19);
            this.CheckWis.TabIndex = 2;
            this.CheckWis.Text = "密語功能";
            this.CheckWis.UseVisualStyleBackColor = false;
            this.CheckWis.CheckedChanged += new System.EventHandler(this.CheckWis_CheckedChanged);
            // 
            // CheckPoke
            // 
            this.CheckPoke.AutoSize = true;
            this.CheckPoke.BackColor = System.Drawing.Color.Transparent;
            this.CheckPoke.Checked = true;
            this.CheckPoke.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckPoke.ForeColor = System.Drawing.Color.White;
            this.CheckPoke.Location = new System.Drawing.Point(39, 82);
            this.CheckPoke.Name = "CheckPoke";
            this.CheckPoke.Size = new System.Drawing.Size(74, 19);
            this.CheckPoke.TabIndex = 3;
            this.CheckPoke.Text = "戳一下";
            this.CheckPoke.UseVisualStyleBackColor = false;
            this.CheckPoke.CheckedChanged += new System.EventHandler(this.CheckPoke_CheckedChanged);
            // 
            // CheckImg
            // 
            this.CheckImg.AutoSize = true;
            this.CheckImg.BackColor = System.Drawing.Color.Transparent;
            this.CheckImg.Checked = true;
            this.CheckImg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckImg.ForeColor = System.Drawing.Color.White;
            this.CheckImg.Location = new System.Drawing.Point(39, 119);
            this.CheckImg.Name = "CheckImg";
            this.CheckImg.Size = new System.Drawing.Size(89, 19);
            this.CheckImg.TabIndex = 4;
            this.CheckImg.Text = "圖片功能";
            this.CheckImg.UseVisualStyleBackColor = false;
            this.CheckImg.CheckedChanged += new System.EventHandler(this.CheckImg_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(237, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SizeLabel.ForeColor = System.Drawing.Color.White;
            this.SizeLabel.Location = new System.Drawing.Point(152, 86);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(71, 15);
            this.SizeLabel.TabIndex = 7;
            this.SizeLabel.Text = "文字大小:";
            this.SizeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PenSize
            // 
            this.PenSize.FormattingEnabled = true;
            this.PenSize.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.PenSize.Location = new System.Drawing.Point(230, 81);
            this.PenSize.Name = "PenSize";
            this.PenSize.Size = new System.Drawing.Size(121, 23);
            this.PenSize.TabIndex = 8;
            this.PenSize.Text = "10";
            this.PenSize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "字體顏色:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(231, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 45);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // GameInvite
            // 
            this.GameInvite.AutoSize = true;
            this.GameInvite.BackColor = System.Drawing.Color.Transparent;
            this.GameInvite.Checked = true;
            this.GameInvite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GameInvite.ForeColor = System.Drawing.Color.White;
            this.GameInvite.Location = new System.Drawing.Point(39, 159);
            this.GameInvite.Name = "GameInvite";
            this.GameInvite.Size = new System.Drawing.Size(89, 19);
            this.GameInvite.TabIndex = 13;
            this.GameInvite.Text = "遊戲邀請";
            this.GameInvite.UseVisualStyleBackColor = false;
            this.GameInvite.CheckedChanged += new System.EventHandler(this.GameInvite_CheckedChanged);
            // 
            // SetPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(390, 273);
            this.Controls.Add(this.GameInvite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PenSize);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckImg);
            this.Controls.Add(this.CheckPoke);
            this.Controls.Add(this.CheckWis);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetPage";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.SetPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckWis;
        private System.Windows.Forms.CheckBox CheckPoke;
        private System.Windows.Forms.CheckBox CheckImg;
        private System.Windows.Forms.ColorDialog ColorPlate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.ComboBox PenSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox GameInvite;
    }
}