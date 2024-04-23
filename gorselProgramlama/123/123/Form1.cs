using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            //listBox1.Items.AddRange(gunler);

            //string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            //listBox1.Items.AddRange(gunler);

            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            listBox1.Items.AddRange(gunler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(listBox1.SelectedItem);
            //MessageBox.Show("Seçili olan eleman silinmiştir.");

            //listBox1.Items.Remove(listBox1.SelectedItem);
            //MessageBox.Show("Seçili olan eleman silinmiştir.");
            //MessageBox.Show("Listede " + listBox1.Items.Count + " tane eleman vardır.");

            string aranan;
            aranan = textBox1.Text;
            int yer;
            yer = listBox1.Items.IndexOf(aranan);
            if (yer < 0)
            {
                MessageBox.Show("Aradığınız kelime bulunamamıştır.");
            }
            else
            {
                MessageBox.Show("Aradığınız kelime " + (yer + 1) + ". sıradadır.");
            }


        }
    }
}
