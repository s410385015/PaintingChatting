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
    public partial class SetUpConnect : Form
    {
        public int port;
        public String address;
        public SetUpConnect()
        {
            InitializeComponent();
            address = IA.Text;
            port = Int32.Parse(PT.Text);
        }

        private void IT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            address = IA.Text;
            port = Int32.Parse(PT.Text);
            this.Hide();
        }

        private void IP_Click(object sender, EventArgs e)
        {

        }

        private void SetUpConnect_Load(object sender, EventArgs e)
        {

        }
    }
}
