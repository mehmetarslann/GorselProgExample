﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(object item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;

        }
    }
}
