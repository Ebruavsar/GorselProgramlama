using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void liste_Click(object sender, EventArgs e)
        {

            //string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            //listBox1.Items.AddRange(gunler);

            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            listBox1.Items.AddRange(gunler);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            //MessageBox.Show("Seçili olan eleman listeden silinmiştir.");

            listBox1.Items.Remove("Salı");
        }
    }
}
