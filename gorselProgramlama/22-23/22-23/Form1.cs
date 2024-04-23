using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_23
{
    public partial class Form1 : Form
    {
        int[,] a = new int[3, 3];
        int[,] b = new int[3, 3];
        int[,] c = new int[3, 3];
        private object label3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            listBox1.Items.Clear();
            string sat;
            sat = " ";
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox((Convert.ToString(i) + Convert.ToString(",") + Convert.ToString(j) + Convert.ToString(". eleman")), "A matrisi degerleri", "0", 50, 50));
                    sat = sat + " " + Convert.ToString(a[i, j]);
                }
                listBox1.Items.Add(sat);
                sat = " ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j;
            listBox2.Items.Clear();
            string sat;
            sat = " ";
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox((Convert.ToString(i) + Convert.ToString(",") + Convert.ToString(j) + Convert.ToString(". eleman")), "A matrisi degerleri", "0", 50, 50));
                    sat = sat + " " + Convert.ToString(a[i, j]);
                }
                listBox2.Items.Add(sat);
                sat = " ";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int i, j;
            listBox3.Items.Clear();
            string sat;
            sat = " ";
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox((Convert.ToString(i) + Convert.ToString(",") + Convert.ToString(j) + Convert.ToString(". eleman")), "A matrisi degerleri", "0", 50, 50));
                    sat = sat + " " + Convert.ToString(a[i, j]);
                }
                listBox3.Items.Add(sat);
                sat = " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, j, k, x;
            listBox3.Items.Clear();
            string sat;
            sat = " ";
            label4.Text = "A+B matris islemi";
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    x = 0;
                    for (k = 0; k < 3; k++)
                    {
                        x = x + a[i, j] ^ b[k, j];
                    }
                    c[i, j] = x;
                    sat = sat + " " + Convert.ToString(c[i, j]);
                }
                listBox3.Items.Add(sat);
                sat = " ";
            }
        }
    }
}
