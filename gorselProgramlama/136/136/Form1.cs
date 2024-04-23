using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _136
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] liste = { "Ali", "Masa", "Serdar", "Bilgisayar", "Kalem", "Bora", "Çay", "Araba", "Saat", "Okul", "Anne","12","4","1" };
            listBox1.Items.AddRange(liste);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Sorted = true;
            listBox2.Items.AddRange(listBox1.Items);
            
        }
    }
}
