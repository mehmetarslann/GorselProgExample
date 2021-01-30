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


namespace ornek6
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
            StreamWriter yeni = new StreamWriter("yeni.txt", false);


            while (!oku.EndOfStream)
            {
                string satir = oku.ReadLine();
                if (satir.Length >= 5)
                {
                    string tut = "";
                    for (int i = satir.Length - 1; i >= 0; i--)
                    {
                        tut += satir[i];

                    }
                yeni.WriteLine(tut);
                }


            }
            oku.Close();
            yeni.Close();
            File.Delete("deneme.txt");
            File.Move("yeni.txt", "deneme.txt");

        }
    }
}
