using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _113
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "buraya ad girişi yapın ");
            toolTip1.SetToolTip(textBox2, "sınav notunu giriniz. " +"not 100den büyük olamaz");
            toolTip1.SetToolTip(textBox3, "mail adresini giriniz ");
            toolTip1.SetToolTip(textBox4, "araç plakalarını girerken boşluk vermeyi unutmayın "+"06 ab 432 gibi");
            toolTip1.SetToolTip(textBox5, "telefon numarasını giriniz. (505 654 5434 bibi)  " );


        }
    }
}
