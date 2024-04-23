using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _216_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Maximum = 264;
            hScrollBar2.Maximum = 264;
            hScrollBar3.Maximum = 264;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.BackColor =Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

            label4.Text = hScrollBar1.Value.ToString();
            label6.Text = hScrollBar2.Value.ToString();
            label7.Text = hScrollBar3.Value.ToString();


        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

            label4.Text = hScrollBar1.Value.ToString();
            label6.Text = hScrollBar2.Value.ToString();
            label7.Text = hScrollBar3.Value.ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

            label4.Text = hScrollBar1.Value.ToString();
            label6.Text = hScrollBar2.Value.ToString();
            label7.Text = hScrollBar3.Value.ToString();
        }
    }
}
