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
    
    public partial class WF : Form
    {
        public bool click = false;
        public String str;
        public WF(String str)
        {
            InitializeComponent();
            ToUser.Text = "To: "+str;
            whisper.Focus();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void s_Click(object sender, EventArgs e)
        {
            str = whisper.Text;
            if (str != "")
            {
                click = true;
            }
            this.Close();
        }

        private void whisper_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                whisper.Clear();
            }
            if(e.KeyCode==Keys.Enter)
            {
                s.PerformClick();
            }
        }

        private void WF_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode==Keys.Enter)
            {
                whisper.Text += "";
            }
        }
    }
}
