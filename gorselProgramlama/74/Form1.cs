using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _74
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 255;
            numericUpDown2.Maximum = 255;
            numericUpDown3.Maximum = 255;
        }
        int red_deger, green_deger, blue_deger;

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            red_deger = Convert.ToInt32(numericUpDown1.Value);
            green_deger = Convert.ToInt32(numericUpDown2.Value);
            blue_deger = Convert.ToInt32(numericUpDown3.Value);

            panel1.BackColor = Color.FromArgb(red_deger, green_deger, blue_deger);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            red_deger = Convert.ToInt32(numericUpDown1.Value);
            green_deger = Convert.ToInt32(numericUpDown2.Value);
            blue_deger = Convert.ToInt32(numericUpDown3.Value);

            panel1.BackColor = Color.FromArgb(red_deger, green_deger, blue_deger);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            red_deger = Convert.ToInt32(numericUpDown1.Value);
            green_deger = Convert.ToInt32(numericUpDown2.Value);
            blue_deger = Convert.ToInt32(numericUpDown3.Value);

            panel1.BackColor = Color.FromArgb(red_deger,green_deger,blue_deger);
        }
    }
}
