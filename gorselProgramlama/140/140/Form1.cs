using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _140
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            checkedListBox2.Items.Add(textBox2.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indis;
            indis = checkedListBox1.SelectedIndex;

            if(indis <0)
            {
                MessageBox.Show("önce listeden bir seçim yapınız");
            }
            else
            {
                checkedListBox1.Items.RemoveAt(indis);
                checkedListBox2.Items.RemoveAt(indis);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indis, b, t;
            indis = checkedListBox1.SelectedIndex;

            checkedListBox2.SelectedIndex = indis;
            if(indis < 0)
            {
                return;
            }
            checkedListBox2.SetItemChecked(indis,checkedListBox1.GetItemChecked(indis));

            b = listBox1.Items.IndexOf(checkedListBox1.Items[indis]);

            if(b < 0)
            {
                if(checkedListBox1.GetItemChecked(indis)==true)
                {
                    listBox1.Items.Add(checkedListBox1.Items[indis]);

                    listBox2.Items.Add(checkedListBox2.Items[indis]);

                }
            }
            if(b >= 0)
            {
                if (checkedListBox1.GetItemChecked(indis) == false)
                {
                    listBox1.Items.RemoveAt(b);

                    listBox2.Items.RemoveAt(b);

                }
            }

            t = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                t = t + Convert.ToInt16(listBox2.Items[i].ToString());
            }
            label4.Text=t.ToString();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.SelectedIndex = checkedListBox2.SelectedIndex;
        }
    }
}
