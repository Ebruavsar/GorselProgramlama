using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int vize;
        int final;
        double sonuc;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonuc = (vize * 0.4) + (final * 0.6);
            if (sonuc <= 24)
            {
                MessageBox.Show("Harflik tabandaki notunuz FF'dir. Dersten kaldınız.", "Sonuç ifadesi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (sonuc <= 34)
            {
                MessageBox.Show("Harflik tabandaki notunuz FD'dir. Dersten kaldınız.", "Sonuç ifadesi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (sonuc <= 44)
            {
                MessageBox.Show("Harflik tabandaki notunuz DD'dir. Dersten kaldınız.", "Sonuç ifadesi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (sonuc <= 49)
            {
                MessageBox.Show("Harflik tabandaki notunuz DC'dir. Dersten kaldınız.", "Sonuç ifadesi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (sonuc <= 59)
            {
                MessageBox.Show("Harflik tabandaki notunuz CC'dir. Dersten geçtiniz.", "Sonuç ifadesi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (sonuc <= 69)
            {
                MessageBox.Show("Harflik tabandaki notunuz CB'dir. Dersten geçtiniz.", "Sonuç ifadesi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (sonuc <= 79)
            {
                MessageBox.Show("Harflik tabandaki notunuz BB'dir. Dersten geçtiniz.", "Sonuç ifadesi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (sonuc <= 89)
            {
                MessageBox.Show("Harflik tabandaki notunuz BA'dir. Dersten geçtiniz.", "Sonuç ifadesi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Harflik tabandaki notunuz AA'dir. Dersten geçtiniz.", "Sonuç ifadesi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            vize = Convert.ToInt16(textBox1.Text);
            if (vize > 100)
            {
                MessageBox.Show("Vize Notu 100'den büyük olamaz", "Yanlış not girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            final = Convert.ToInt16(textBox2.Text);
            if (final > 100)
            {
                MessageBox.Show("Final Notu 100'den büyük olamaz", "Yanlış not girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }

        }
    }
}
