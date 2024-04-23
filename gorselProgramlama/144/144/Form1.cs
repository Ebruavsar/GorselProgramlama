using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _144
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iller[] il = { new iller("ANKARA", "06"),
                new iller("İzmit", "41"),
                new iller("Sakarya", "54"),
                new iller("İstanbul", "34"),
                new iller("Bursa","16"),
                new iller("Muğla","48"),
                new iller("İzmir","35"),
                new iller("Balıkesir","10"),};
            comboBox1.Items.AddRange(il);
        }
        class iller
        {
            public string adi;
            public string plaka;

            public iller(string adi, string plaka)
            {
                this.adi = adi;
                this.plaka = plaka;
            }

            public iller()
            {
                this.adi = "";
                this.plaka = "";
            }
            public override string ToString()
            {
                return plaka + " " + adi;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                return;
            }
            label4.Text = ((iller)comboBox1.SelectedItem).adi;
            label5.Text = ((iller)comboBox1.SelectedItem).plaka;
        }
    }
}
