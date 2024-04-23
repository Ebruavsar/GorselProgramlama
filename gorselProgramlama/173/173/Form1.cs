using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _173
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.Text = "Yazdırma işlemi başladı";
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.Text = "Yazdırma işlemi bitti";
        }
        int sayfano = 0;

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            sayfano += 1;
            e.Graphics.DrawString("Sayfa " + sayfano.ToString(), new Font("Tahoma", 50, FontStyle.Regular), Brushes.Black, 100, 100);
            if (sayfano == 3)
            {
                e.HasMorePages = false;
                sayfano = 0;
            }
            else
            {
                e.HasMorePages = true;
            }
        }
    }
}
