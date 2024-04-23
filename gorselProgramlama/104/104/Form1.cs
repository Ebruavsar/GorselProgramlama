using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "1234")
            {
                textBox2.ReadOnly = false;
                textBox3.ReadOnly=false;
            }
            else
            {
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
            }
        }
    }
}
