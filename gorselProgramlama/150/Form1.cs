using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Format = DateTimePickerFormat.Short;

            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;

            dateTimePicker3.ShowCheckBox = true;

            listBox1.Font = new Font("Courier New", 10, FontStyle.Regular);

        }
        Boolean mezun_oldu;

        private void button1_Click(object sender, EventArgs e)
        {
            String ogrenci_ad, ogreci_babaad, ogrencidogumyer;
            DateTime dogum_tarihi, kayıt_tarihi, mezuniyet_tarihi;

            ogrenci_ad =textBox1.Text;
            ogreci_babaad =textBox2.Text;
            ogrencidogumyer =textBox3.Text;

            dogum_tarihi = dateTimePicker1.Value;
            kayıt_tarihi=dateTimePicker2.Value;
            mezuniyet_tarihi=dateTimePicker3 .Value;

            if (dateTimePicker3.Checked)
            {
                mezun_oldu = true;
            }
            else {
                mezun_oldu = false;
            }

            if (dogum_tarihi>=kayıt_tarihi)
            {
                MessageBox.Show("dogum tarihi veya kayıttarihi yanlış girilmiş.");
                return;
            }
            if (mezun_oldu)
            {
                if (kayıt_tarihi> mezuniyet_tarihi)
                {
                    MessageBox.Show("kayıt veya mezuniyet tarihi yanlış girilmiş");
                    return;
                }
            }
            listBox1.Items.Add(ogrenci_ad+ogreci_babaad.PadLeft(10)+ogrencidogumyer.PadLeft(10)+dogum_tarihi.ToShortDateString().PadLeft(15)
                +kayıt_tarihi.ToShortDateString().PadLeft(15)+mezuniyet_tarihi.ToShortDateString().PadLeft(15));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
