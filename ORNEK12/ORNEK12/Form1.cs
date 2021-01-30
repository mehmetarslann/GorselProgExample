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

namespace ORNEK12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] files = Directory.GetFiles(@"U:\Users\ADMIN\Documents");
            
            TreeNode ilk = new TreeNode(files[0]);

            for (int i = 1; i < files.Length;i++)
            {
                ilk.Nodes.Add(files[i]);
            }

            treeView1.Nodes.Add(ilk);
        }
    }
}
