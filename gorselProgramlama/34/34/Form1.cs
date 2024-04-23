using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int sayi_karesi;

            listBox1.Items.Add("sayi     sayi karakter");
            listBox1.Items.Add(" ------           ----------");

            for (int i = 0; i < 100; i++)
            {
                sayi = i;
                sayi_karesi = i*i;
                listBox1.Items.Add(sayi.ToString()+"\t"+ sayi_karesi.ToString());
            }

        }
    }
}
