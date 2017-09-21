using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NewProject
{
    public partial class PicShow : Form
    {
        int index = 0;
        byte[] newdata = new byte[1024*1024];
       
        public PicShow()
        {
            InitializeComponent();
            this.Location = new Point(50, 50);
            //pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\2.jpg");
        } 

        private void PicShow_Load(object sender, EventArgs e)
        {

        }
        public void setImg(byte[] img)
        {

            int i;
            for (i = 3; i < img.Length; i++)
                newdata[index+i-3] = img[i];
            index = index + img.Length - 3;
            //richTextBox1.AppendText(index.ToString()+"\n");
            //ShowImg();
        }
        public void ShowName(string name)
        {
            label1.Hide();            
            this.Text = name+" 傳來了一張圖片！";
        }
        public void ShowImg(int num)
        {


            FileStream fs = File.Create(num.ToString() + ".jpg");
            fs.Write(newdata, 0, index);
            fs.Close();
            Image temp = Image.FromFile(Application.StartupPath + "//" + num.ToString() + ".jpg");
            if (temp.Height < 100)
                this.Height = 300;
            else
                this.Height = temp.Height+100;
            if (temp.Width < 100)
                this.Width = 300;
            else
                this.Width = temp.Width+100;
            pictureBox1.Height = temp.Height;
            pictureBox1.Width = temp.Width;
            pictureBox1.Location = new Point(this.Width / 2 - pictureBox1.Width / 2-10, this.Height / 2 - pictureBox1.Height / 2);
            button1.Location = new Point(this.Width - button1.Width - 30, 10);
            //MessageBox.Show("?");
            pictureBox1.Image = temp;
            index = 0;

            GC.ReRegisterForFinalize(fs);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
