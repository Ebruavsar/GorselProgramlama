using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime girilen_tarih;
            TimeSpan fark;
            girilen_tarih=Convert.ToDateTime(textBox1.Text);
            fark=DateTime.Now.Subtract(girilen_tarih);
            MessageBox.Show("girilen tarih ile şimdiki tarih  arasındaki toplam gün sayısı=" + fark.TotalDays.ToString("N0") + "\r\n"+
                "girilen tarih ile şimdiki tarih  arasındaki toplam gün sayısı=" + fark.TotalHours.ToString("N0") + "\r\n" +
                "girilen tarih ile şimdiki tarih  arasındaki toplam gün sayısı=" + fark.TotalMinutes.ToString("N0") + "\r\n" +
                "girilen tarih ile şimdiki tarih  arasındaki toplam gün sayısı=" + fark.TotalSeconds.ToString("N0") + "\r\n" +
                "girilen tarih ile şimdiki tarih  arasındaki toplam gün sayısı=" + fark.TotalMilliseconds.ToString("N0"));
        }
    }
}
