﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifadee = " ";
            int sonuc;
            ifadee = textBox1.Text;
            sonuc = string.Compare("evet", ifadee);
            if (sonuc == 0)
            {
                MessageBox.Show("Burs İsteminde Bulunamazsınız ");
            }
            else
            {
                MessageBox.Show("Burs İşlemleri İçin Devam Ediniz ");
            }
                }
    }
}
