﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _129
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yer;
            string aranan;
            aranan = textBox1.Text;
            yer = listBox1.FindStringExact(aranan);
            if (yer < 0)
            {
                MessageBox.Show("Aranan ifade bulunamadı.");
            }
            else
            {
                MessageBox.Show((yer + 1).ToString() + " .eleman");
                listBox1.SelectedIndex = yer;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] isimler = { "Ahmet", "Serdar", "Uğur", "Erkan", "Kıvanç" ,"ebru" ,"beyza","selim" };
            listBox1.Items.AddRange(isimler);
        }
    }
}
