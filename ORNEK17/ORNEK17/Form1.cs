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

namespace ORNEK17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo de = new DirectoryInfo(@"C:\Users\ADMIN\Pictures\");
            FileInfo[] files = de.GetFiles();
            int x = 0;
            int y = 0;
            foreach(var item in files)
            {
                if(item.Extension == ".jpg")
                {
                    PictureBox p = new PictureBox();
                    p.Location = new Point(100 + 105 * x, 100 + 105 * y);
                    p.Size = new Size(100, 100);
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Image = Image.FromFile(item.FullName);
                    x++;
                    this.Controls.Add(p);
                    if(x>3)
                    {
                        x = 0;
                        y++;
                    }
                }
            }

        }
    }
}
