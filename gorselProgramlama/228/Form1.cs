using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _228
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte k, c;
            long i, boyut;
            button1.Enabled = false;
            openFileDialog1.Title = "Açılacak dosyayı seçin";
            saveFileDialog1.Title = "Oluşturulacak dosyayı yazın";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = "Orjinal dosya: " + openFileDialog1.FileName;
                    System.IO.FileStream fs1 = new System.IO.FileStream(openFileDialog1.FileName, System.IO.FileMode.Open);
                    System.IO.BinaryReader dosya1 = new System.IO.BinaryReader(fs1);
                    label2.Text = "Oluşturulan dosya: " + saveFileDialog1.FileName;
                    System.IO.FileStream fs2 = new System.IO.FileStream(saveFileDialog1.FileName, System.IO.FileMode.CreateNew);
                    System.IO.BinaryWriter dosya2 = new System.IO.BinaryWriter(fs2);
                    boyut = (new System.IO.FileInfo(openFileDialog1.FileName)).Length;
                    progressBar1.Maximum = (int)boyut / 100;
                    label3.Text = "Dosya boyutu: " + boyut.ToString();
                    for (i = 0; i < boyut; i++)
                    {
                        c = dosya1.ReadByte();
                        if ((i % 3) == 0)
                        {
                            k = (byte)~c;
                        }
                        else
                        {
                            k = c;
                        }
                        if (k == 0)
                        {
                            progressBar1.Value = (int)i / 100;
                            Application.DoEvents();
                        }
                        dosya2.Write(k);
                    }
                    dosya1.Close();
                    dosya2.Close();
                    fs1.Close();
                    fs2.Close();

                }
            }
            button1.Enabled = true;
        }
    }
}
