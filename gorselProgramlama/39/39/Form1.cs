using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void buyuk(int a, int b, int c)
        {
            int byk = 0;
            if (byk <= a) { byk = a; }
            if (byk <= b) { byk = b; }
            if (byk <= c) { byk = c; }
            MessageBox.Show("En büyük sayı: " + byk);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            buyuk(a, b, c);
        }
    }
}
