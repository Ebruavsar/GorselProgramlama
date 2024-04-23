using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _127
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.TextReader bilgioku = System.IO.File.OpenText("C:\\bilgi_kaydı.dat");
                string satir;
                while ((satir = bilgioku.ReadLine()) != null)
                {
                    listBox_adisoyadi.Items.Add(satir);

                    satir = bilgioku.ReadLine();
                    listBox_bolumu.Items.Add(satir);

                    satir = bilgioku.ReadLine();
                    listBox_bolumu.Items.Add(satir);
                }
                bilgioku.Close();
            }
            catch (Exception)
            {
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.TextWriter bilgisayar = System.IO.File.CreateText("C:\\bilgi_kayit.dat");
            for (int i = 0; i < listBox_adisoyadi.Items.Count; i++)
            {
                bilgisayar.WriteLine(listBox_adisoyadi.Items[i]);
                bilgisayar.WriteLine(listBox_bolumu.Items[i]);
                bilgisayar.WriteLine(listBox_babaadi.Items[i]);
            }
            MessageBox.Show("Bilgiler C klasörünün içinde bilgi_kaydı adında dosyaya kaydedildi.");
            bilgisayar.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox_adisoyadi.Items.Add("ebru");
            listBox_babaadi.Items.Add("adem");
            listBox_bolumu.Items.Add("bilgisayar");
            listBox_adisoyadi.Items.Add("ebru");
            listBox_babaadi.Items.Add("adem");
            listBox_bolumu.Items.Add("bilgisayar");
            listBox_adisoyadi.Items.Add("ebru");
            listBox_babaadi.Items.Add("adem");
            listBox_bolumu.Items.Add("bilgisayar");
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            int indis;
            indis = listBox_adisoyadi.SelectedIndex;
            if (indis < 0)
            {
                MessageBox.Show("Silinecek olan elemanı seçiniz.");
            }
            else
            {
                listBox_adisoyadi.Items.Remove(indis);
                listBox_babaadi.Items.RemoveAt(indis);
                listBox_bolumu.Items.RemoveAt(indis);
            }
        }

        private void eleman_tıklanırsa(object sender, EventArgs e)
        {
            int indis;
            indis = (sender as ListBox).SelectedIndex;
            listBox_adisoyadi.SelectedIndex = indis;
           
            listBox_bolumu.SelectedIndex = indis;
            listBox_babaadi.SelectedIndex = indis;
        }
    }
}
