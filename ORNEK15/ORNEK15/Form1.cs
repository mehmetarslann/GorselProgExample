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

namespace ORNEK15
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
            int adet = 0;

            while(!oku.EndOfStream)
            {
                string satir = oku.ReadLine();
                adet = satir.Length;

                yaz.WriteLine(satir + " Uzunluk : " + adet);
            }
            oku.Close();
            yaz.Close();
            File.Delete("deneme.txt");
            File.Move("yeni.txt", "deneme.txt");
        }
    }
}
