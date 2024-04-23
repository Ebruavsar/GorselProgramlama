using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string s;
            listBox1.Font = new Font("Courier new", 9, FontStyle.Regular);
            listBox1.Items.Add("Karakter kodu   Karakter");
            for (int i = 0; i <= 255; i++)
            {
                s = i.ToString().PadLeft(4, ' ');
                s = s + "         " + (char)i;
                switch (comboBox1.Text)
                {
                    case "Control":
                        if (Char.IsControl((char)i))
                            listBox1.Items.Add(s);
                        break;
                    case "Digit":
                        if (Char.IsDigit((char)i))
                            listBox1.Items.Add(s);
                        break;
                    case "Letter":
                        if (Char.IsControl((char)i))
                            listBox1.Items.Add(s);
                        break;
                    case "LetterOrDigit":
                        if (Char.IsDigit((char)i))
                            listBox1.Items.Add(s);
                        break;
                    case "Lower":
                        if (Char.IsControl((char)i))
                            listBox1.Items.Add(s);
                        break;
                    case "Number":
                        if (Char.IsDigit((char)i))
                            listBox1.Items.Add(s);
                        break;
                    case "Punutation":
                        if (Char.IsControl((char)i))
                            listBox1.Items.Add(s);
                        break;
                    case "Separtor":
                        if (Char.IsDigit((char)i))
                            listBox1.Items.Add(s);
                        break;
                    case "Surrogate":
                        if (Char.IsControl((char)i))
                            listBox1.Items.Add(s);
                        break;
                    case "Symbol":
                        if (Char.IsDigit((char)i))
                            listBox1.Items.Add(s);
                        break;
                    case "Upper":
                        if (Char.IsControl((char)i))
                            listBox1.Items.Add(s);
                        break;
                    case "WhiteSpace":
                        if (Char.IsDigit((char)i))
                            listBox1.Items.Add(s);
                        break;
                }


            }
        }

   
    }
}
