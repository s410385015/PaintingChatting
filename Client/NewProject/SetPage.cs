using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class SetPage : Form
    {
        public bool TFDraw = true;
        public bool TFWsp = true;
        public bool TFImg = true;
        public bool TFPk=true;
        public bool TFGame = true;
        public Color C=Color.Black;
        public int size = 10;
        public SetPage()
        {
            InitializeComponent();
        }

      
        private void SetPage_Load(object sender, EventArgs e)
        {

        }

       

        private void CheckWis_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckWis.Checked)
                TFWsp=true;
            else
                TFWsp=false;
        }

        private void CheckPoke_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckPoke.Checked)
                TFPk=true;
            else
                TFPk=false;
        }

        private void CheckImg_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckImg.Checked)
                TFImg=true;
            else
                TFImg=false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorPlate.ShowDialog();
            pictureBox1.BackColor=ColorPlate.Color;
            C = ColorPlate.Color;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = PenSize.SelectedIndex + 10;
            SizeLabel.Text = (PenSize.SelectedIndex + 10).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void GameInvite_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckWis.Checked)
                TFGame = true;
            else
                TFGame = false;
        }
        
        
    }
}
