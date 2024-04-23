using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _63
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Font = new Font(listBox1.SelectedItem.ToString(), 16, FontStyle.Regular);
            }
            catch (Exception)
            {
                MessageBox.Show("Bu font gösterilemiyor");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            FontFamily[] fontlar = FontFamily.Families;
            for (int i = 0; i < fontlar.Length; i++)
            {
                listBox1.Items.Add(fontlar[i].Name);
            }
        }
      

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            FontFamily[] fontlar = FontFamily.Families;
            Font fnt = null;
            float x = 0, y = 0;
            string ifade;
            for (int i = 0; i < fontlar.Length; i++)
            {
                try
                {
                    fnt = new Font(fontlar[i].Name, 10, FontStyle.Regular);
                    ifade = fontlar[i].Name;
                }
                catch (Exception)
                {

                    ifade = fontlar[i].Name + " bu font gösterilemez";
                }

                e.Graphics.DrawString(ifade, fnt, Brushes.Black, x, y);
                y += fnt.Height;
                if (((i + 1) % 20) == 0)
                {
                    x = x + 200;
                    y = 0;
                }
            }
        }
    }
}
