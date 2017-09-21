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
    public partial class Login : Form
    {
        //private String Name;
        public SetUpData s=new SetUpData();
        public SetUpConnect set=new SetUpConnect();
        public Login()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.No;
            //SetUpConnect set=new SetUpConnect;
            //set.Hide();
        }

        
       
        private void LB_Click(object sender, EventArgs e)
        {
            if(NameBox.Text.Length>10)
            {
                MessageBox.Show("名字太長了!");
                NameBox.Text = "";
                return;
            }
            if (NameBox.Text.Contains('.') || NameBox.Text.Contains('/'))
            {
                MessageBox.Show("名字含非法字元!");
                NameBox.Text = "";
                return;
            }

            s.UserName = NameBox.Text;
            s.IP = set.address;
            s.Port = set.port;
            this.DialogResult = DialogResult.OK;
          
        }
        public SetUpData Get()
        {
            return s;
        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 連線設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set.Show();
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                LB.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
