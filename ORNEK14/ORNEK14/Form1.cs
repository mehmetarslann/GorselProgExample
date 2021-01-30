using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORNEK14
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
                if(item is CheckBox)
                {
                    CheckBox c = (CheckBox)item;
                    listBox1.Items.Add(c.Text);
                }
            }
        }
    }
}
