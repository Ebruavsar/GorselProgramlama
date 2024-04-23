using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _174
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(Color.Aqua), 10, 10, 450,150);
            e.Graphics.DrawString("Visual c#.Net 2008", new Font("Tahoma", 28, FontStyle.Regular), new SolidBrush(Color.White), 75, 25);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(Color.Aqua), 10, 10, 450, 150);
            e.Graphics.DrawString("Visual c#.Net 2008", new Font("Tahoma", 28, FontStyle.Regular), new SolidBrush(Color.White), 75, 25);
        }
    }
}
