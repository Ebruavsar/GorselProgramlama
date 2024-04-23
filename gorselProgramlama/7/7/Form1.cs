using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long sayi;
            int taban_degeri;
            string sayi_olusumu = " ";

            sayi = int.Parse(textBox1.Text);
            taban_degeri = Convert.ToInt16(textBox2.Text);
            label3.Text = taban_degeri.ToString() + " taban ndaki " + sayi.ToString() + "'in degeri=";
            long kalan_deger;
            while (sayi >= taban_degeri)
            {
                kalan_deger = sayi % taban_degeri;
                sayi = sayi / taban_degeri;

                if (kalan_deger > 9)
                {
                    sayi_olusumu = (char)(55 + kalan_deger) + sayi_olusumu;

                }
                else
                {
                    sayi_olusumu = kalan_deger + sayi_olusumu;
                }
            }

            if (sayi > 9)
            {
                sayi_olusumu = (char)(55 + sayi) + sayi_olusumu;
            }
            else
            {
                sayi_olusumu = sayi + sayi_olusumu;
            }
            label4.Text = sayi_olusumu;



        }
    }
}
