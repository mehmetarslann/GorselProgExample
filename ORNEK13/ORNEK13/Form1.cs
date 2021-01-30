using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORNEK13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            for (int i = 1; i <= 10; i++)
            {
                TreeNode ilk = treeView1.Nodes.Add(i.ToString());
                for (int j = 1; j <= 10; j++)
                {
                    ilk.Nodes.Add(String.Format("{0} x {1} = {2}", i, j, i * j));
                  
                }
            }

        }
    }
}
