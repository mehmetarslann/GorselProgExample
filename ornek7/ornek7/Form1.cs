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

namespace ornek7
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
            StreamWriter yaz = new StreamWriter("yeni.txt", false);

            while(!oku.EndOfStream)
            {
                string satir = oku.ReadLine();
                string[] kelime = satir.Split(' ');

                if(kelime.Length<=3)
                {
                    yaz.WriteLine(satir);
                }
            }
            oku.Close();
            yaz.Close();
            File.Delete("deneme.txt");
            File.Move("yeni.txt", "deneme.txt");
        }
    }
}
