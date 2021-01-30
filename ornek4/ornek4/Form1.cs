using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var item in this.Controls)
            {
                string tut = "";
                if(item is CheckBox)
                {
                    CheckBox c = (CheckBox)item;
                    tut = c.Text;
                    if(tut.Length>3)
                    {
                        c.Checked = false;
                    }
                }
            }
        }
    }
}
