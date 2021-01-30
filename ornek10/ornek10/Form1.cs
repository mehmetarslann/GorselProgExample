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

namespace ornek10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader oku = new StreamReader("deneme.txt", Encoding.Default);

            while (!oku.EndOfStream)
            {
                string satir = oku.ReadLine();
                string[] kelime = satir.Split(',');

                foreach(object o in kelime)
                {
                    treeView1.Nodes.Add(o.ToString());
                }
            }
            oku.Close();



        }
    }
}
