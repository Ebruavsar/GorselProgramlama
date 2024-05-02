using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true;

            numericUpDown1.Maximum = 500;
            numericUpDown2.Maximum = 500;
            numericUpDown3.Maximum = 500;
            numericUpDown4.Maximum = 500;

            numericUpDown1.Value = textBox1.Left;
            numericUpDown2.Value = textBox1.Top;
            numericUpDown3.Value = textBox1.Width;
            numericUpDown4.Value = textBox1.Height;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Left=(int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Top = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Width = (int)numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Height = (int)numericUpDown4.Value;
        }
    }
}
