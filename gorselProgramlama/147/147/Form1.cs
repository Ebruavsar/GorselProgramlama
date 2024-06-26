﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _147
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();

            for (int i = 0; i < 500; i++)
            {
                int rastgele_sayi = r.Next(100);
                listBox1.Items.Add(rastgele_sayi).ToString();
            }
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 500;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime baslama, bitis;
            TimeSpan fark;
            this.Text = "Lutfen Bekleyiniz";
            baslama = DateTime.Now;
            listBox1.BeginUpdate();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = i; j < listBox1.Items.Count; j++)
                {
                    int sayi1, sayi2;
                    sayi1 = Convert.ToInt32(listBox1.Items[i]);
                    sayi2 = Convert.ToInt32(listBox1.Items[j]);
                    if (sayi2 > sayi1)
                    {
                        int c = sayi2;
                        sayi2 = sayi1;
                        sayi1 = c;
                        listBox1.Items[i] = sayi1.ToString();
                        listBox1.Items[j] = sayi2.ToString();
                    }
                }
                progressBar1.Value = i + 1;
            }
            listBox1.EndUpdate();
            bitis = DateTime.Now;
            fark = bitis - baslama;
            this.Text = "İşlem Süresi:" + fark.ToString().Substring(0, 8);


        }
    }
}
