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
    public partial class Input : Form
    {
        public String str;
        public bool click = false;
        public Input()
        {
            InitializeComponent();
        }
        public String GetStr()
        {
            return str;
        }
        private void Input_Load(object sender, EventArgs e)
        {

        }

        private void BInput_Click(object sender, EventArgs e)
        {
            str = textBox1.Text;
            click = true;
            this.Close();
        }

        private void Input_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
