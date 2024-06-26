﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _169
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 1000;

            openFileDialog1.ShowHelp = true;
            openFileDialog1.Filter = "Resim dosylar|*.gif;*.jpeg;*.jpg;*.png;*.bmp";
            openFileDialog1.Title = "Gösterilecek resimleri seçiniz";
            openFileDialog1.Multiselect = true;

            openFileDialog2.ShowHelp = true;
            openFileDialog2.Filter = "Geçici dosyalar|*.bmp;*.~*|" + "Bütün dosyalar|*.*";
            openFileDialog2.Title = "Silinecek dosyaları seçiniz";
            openFileDialog2.Multiselect = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                timer1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                DialogResult c;
                c = MessageBox.Show("Seçtiğiniz bütün dosyalar silinecektir.", "Silme işlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (c == DialogResult.OK)
                {
                    for (int i = 0; i < openFileDialog2.FileName.Length; i++)
                    {
                        try
                        {
                            System.IO.FileInfo dosya = new System.IO.FileInfo(openFileDialog2.FileNames[i]);
                            dosya.Delete();
                        }
                        catch
                        {
                            MessageBox.Show(openFileDialog2.FileNames[i] + "Bu dosya silinemedi");
                        }
                    }
                }
            }

        }
        int say = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            say++;
            say = say % openFileDialog1.FileNames.Length;
            try
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[say]);
            }
            catch
            {
                MessageBox.Show(openFileDialog1.FileNames[say] + "dosya geçersizdir");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Gösterilecek resimleri seçiniz. Birden fazla resim seçebilmek için Ctrl tuşuna basılı tutarak istediğiniz resmi seçiniz");
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Silinecek dosyaları seçiniz. Birden fazla resim seçebilmek için Ctrl tuşuna basılı tutarak istediğiniz resmi seçiniz");
        }
    }
}
