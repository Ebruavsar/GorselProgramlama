using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gercek_metin = "", sifre_sayısal_metin = "", sifrelenmis_metin = "";
            char c;
            gercek_metin = textBox1.Text;
            sifre_sayısal_metin = textBox2.Text;

            for (int i = 0; i < sifre_sayısal_metin.Length; i++)
            {
                sifrelenmis_metin = "";
                for (int j = 0; j < gercek_metin.Length; j++)
                {
                    c = (char)(gercek_metin[j] ^ sifre_sayısal_metin[i]);
                    if (c == '0')
                    {
                        c = sifre_sayısal_metin[i];
                    }
                    sifrelenmis_metin = sifrelenmis_metin + (char)c;
                }
                gercek_metin = sifrelenmis_metin;
            }
            textBox3.Text = sifrelenmis_metin;
        }
    }
}
