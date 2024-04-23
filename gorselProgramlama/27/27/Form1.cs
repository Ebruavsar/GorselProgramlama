using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int i;
            int aa = 0;
            int sonuc = 0;
            int artismiktari = 1;
            if (checkBox1.Checked && checkBox2.Checked == false)
            {
                if (a % 2 != 0)
                { aa = a; }
                else { aa = a + 1; }
                artismiktari = 2;
            }
            else if (checkBox2.Checked && checkBox1.Checked == false)
            {
                artismiktari = 2;
                if (a % 2 == 0) { aa = a; }
                else
                { aa = a + 1; }
            }
            else if (checkBox1.Checked && checkBox2.Checked)
                artismiktari = 1;
            for (i = aa; i <= b; i += artismiktari)
            {
                sonuc += i;
            }
            label3.Text = sonuc.ToString();
        }
    }
}
