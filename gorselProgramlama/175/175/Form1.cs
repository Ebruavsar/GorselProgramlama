using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _175
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                printDocument1.Print(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
        }
        int sayi = 1;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int sayfa_yüksekliği;
            System.Drawing.Printing.PageSettings sayfa_ayari;
            sayfa_ayari = printDocument1.DefaultPageSettings;
            sayfa_yüksekliği = sayfa_ayari.PaperSize.Height - sayfa_ayari.Margins.Top - sayfa_ayari.Margins.Bottom;

            Font fnt = new Font("Tahome", 14, FontStyle.Regular);
            int satir_yüksekliği;
            satir_yüksekliği = (int)e.Graphics.MeasureString("i", fnt).Height;

            int maksimum_Satir;
            maksimum_Satir = sayfa_yüksekliği / satir_yüksekliği;

            int i, satir_no = 0;

            for (i = sayi; i < sayi + maksimum_Satir; i++)
            {

                if (i > 200)
                {
                    e.HasMorePages = false;
                    sayi = 1;
                    return;
                }
                e.Graphics.DrawString(i.ToString() + ". satır", fnt, new SolidBrush(Color.Black),
                    printDocument1.DefaultPageSettings.Margins.Left,
                    y: printDocument1.DefaultPageSettings.Margins.Top + satir_no * satir_yüksekliği);
                satir_no++;
            }
            sayi = i;
            if (i < 200)
            {
                e.HasMorePages = true;
            }
        }
    }
}
