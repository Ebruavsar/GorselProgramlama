using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _146
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] renkler = { "kırmızı", "sarı", "yeşil", "mavi", "pembe", "kahverengi", "siyah" };
            domainUpDown1.Items.AddRange(renkler);
            domainUpDown1.Wrap = true;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.SelectedIndex >= 0)
            {
                if (domainUpDown1.SelectedItem.ToString() == "kırmızı")
                {
                    panel1.BackColor = Color.Red;
                }
                if (domainUpDown1.SelectedItem.ToString() == "sarı")
                {

                    panel1.BackColor = Color.Yellow;
                }
                if (domainUpDown1.SelectedItem.ToString() == "yeşil")
                {
                    panel1.BackColor = Color.Green;
                }
                if
                    (domainUpDown1.SelectedItem.ToString() == "mavi")
                {
                    panel1.BackColor = Color.Blue;
                }

                if (domainUpDown1.SelectedItem.ToString() == "pembe")
                {
                    panel1.BackColor = Color.Pink;
                }
                if (domainUpDown1.SelectedItem.ToString() == "kahverengi")
                {
                    panel1.BackColor = Color.Brown;
                }
                if (domainUpDown1.SelectedItem.ToString() == "siyah")
                {
                    panel1.BackColor = Color.Black;
                }
            }
            }
    }
}
