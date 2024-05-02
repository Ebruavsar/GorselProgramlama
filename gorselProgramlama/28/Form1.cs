using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal para = 0;
            int adet = 0;
            listBox1.Items.Clear();

            para=Convert.ToDecimal(textBox1.Text);

            adet = (int)para / 200;
            listBox1.Items.Add(adet.ToString()+"adet 200 TL var");
            para = para % 200;

            adet = (int)para / 100;
            listBox1.Items.Add(adet.ToString() + "adet 100 TL var");
            para = para % 100;

            adet = (int)para / 50;
            listBox1.Items.Add(adet.ToString() + "adet 50 TL var");
            para = para % 50;

            adet = (int)para / 20;
            listBox1.Items.Add(adet.ToString() + "adet 20 TL var");
            para = para % 20;

            adet = (int)para / 10;
            listBox1.Items.Add(adet.ToString() + "adet 10 TL var");
            para = para % 10;

            adet = (int)para / 5;
            listBox1.Items.Add(adet.ToString() + "adet 5 TL var");
            para = para % 5;

            adet = (int)para / 1;
            listBox1.Items.Add(adet.ToString() + "adet 1 TL var");
            para = para % 1;
        }
    }
}
