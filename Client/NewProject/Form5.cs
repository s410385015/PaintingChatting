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
    public partial class BlackList : Form
    {
        public List<String> Black =new List<String>();
        public BlackList()
        {
            InitializeComponent();
        }

        private void BlackList_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

       
        public void ShowList()
        {
            foreach(string x in Black)
            {
                richTextBox1.AppendText(x+"\n");
            }
        }

        public bool CheckList(string name)
        {
            foreach(string x in Black)
            {
                if (x == name)
                    return true;
            }
            return false;
        }
    }
}
