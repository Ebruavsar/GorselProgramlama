﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi1;
            double sayi2;
            decimal sayi3; ;
            sayi1 = 1234567890123456789;
            sayi2 = 1234567890123456789;
            sayi3 = 1234567890123456789;
            MessageBox.Show(sayi1.ToString(), "Sayi 1’in değeri");
            MessageBox.Show(sayi2.ToString(), "Sayi 2’in değeri");
            MessageBox.Show(sayi3.ToString(), "Sayi 3’in değeri");
        }
    }
}
