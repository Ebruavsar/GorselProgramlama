using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.ScrollBars = (RichTextBoxScrollBars)ScrollBars.Vertical;
            richTextBox1.HideSelection = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectedText=richTextBox1.SelectedText.ToUpper();
            }
            else
            {
                richTextBox1.Text= richTextBox1.Text.ToUpper();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text.ToLower();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yer = 0;
            string aranan_kelime;
            aranan_kelime =textBox1.Text;
            if (textBox1.SelectionLength > 0)
            {
                yer = richTextBox1.SelectionStart+richTextBox1.SelectedText.IndexOf(aranan_kelime);
            }
            else
            {
                yer= richTextBox1.SelectedText.IndexOf(aranan_kelime);
            }
            if (yer == 0)
            {
                MessageBox.Show("aranan kelime bulunamadı.");
            }
            else
            {
                richTextBox1.Select(yer, aranan_kelime.Length);
                richTextBox1.ScrollToCaret();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectedText = "";

            }
            else
            {
                richTextBox1.Text = "";
            }
        }
    }
}
