﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45
{
    public partial class Form1 : Form
    {
        decimal sayi1, sayi2, hafıza_deger;
        Boolean sonuclandı;
        string islem;

        private void txt_sayi_giris_KeyPress(object sender, KeyPressEventArgs e)
        {
            //rakam değilse iptal
            if(Char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btn_artieksi_Click(object sender, EventArgs e)
        {
            if (txt_sayi_giris.Text.Length > 0)
            {
                if(txt_sayi_giris.Text.Substring(0,1) == "-")
                {
                    txt_sayi_giris.Text = txt_sayi_giris.Text.Substring(1);
                }
                else
                {
                    txt_sayi_giris.Text="-"+ txt_sayi_giris.Text.Substring(0);
                }
            }
        }

        private void btn_ondalikvirgul_Click(object sender, EventArgs e)
        {
            if(txt_sayi_giris.Text.IndexOf(",") <= 0)
            {
                if (txt_sayi_giris.Text.Length == 0)
                {
                    txt_sayi_giris.Text = "0";
                }
                else
                {
                    txt_sayi_giris.Text = txt_sayi_giris.Text + ",";
                }
            }
            
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            hafıza_deger = 0;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_sayi_giris.Text = "";
        }

        private void btn_gerial_Click(object sender, EventArgs e)
        {
            if (txt_sayi_giris.Text.Length > 0)
            {
                txt_sayi_giris.Text = txt_sayi_giris.Text.Substring(0, txt_sayi_giris.Text.Length - 1);
            }
        }

        private void hafiza_islem(object sender, EventArgs e)
        {
            if(txt_sayi_giris.Text.Length == 0)
            {
                txt_sayi_giris.Text = "0";
            }
            if((sender as Button).Name == "btn_MC")
            {
                hafıza_deger = 0;
                sonuclandı = true;
            }
            if ((sender as Button).Name == "btn_MR")
            {
                txt_sayi_giris.Text =hafıza_deger.ToString();
                sonuclandı = true;
            }
            if ((sender as Button).Name == "btn_Marti")
            {
                hafıza_deger = hafıza_deger +Convert.ToDecimal(txt_sayi_giris.Text);
                sonuclandı = true;
            }
            if ((sender as Button).Name == "btn_MC")
            {
                hafıza_deger = hafıza_deger - Convert.ToDecimal(txt_sayi_giris.Text);
                sonuclandı = true;
            }
        }

        private void dot_islem(object sender, EventArgs e)
        {
            islem = (sender as Button).Name;
            if (txt_sayi_giris.Text.Length == 0)
            {
                txt_sayi_giris.Text = "0";
            }
            sayi1 = Convert.ToDecimal(txt_sayi_giris.Text);
            sonuclandı = true;
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDecimal(txt_sayi_giris.Text);
            decimal islem_sonucu = 0;
            if(islem == "btn_topla")
            {
                islem_sonucu = sayi1+sayi2;
            }
            if (islem == "btn_cikar")
            {
                islem_sonucu = sayi1 - sayi2;
            }
            if (islem == "btn_carp")
            {
                islem_sonucu = sayi1 * sayi2;
            }
            if (islem == "btn_bol")
            {
                islem_sonucu = sayi1 / sayi2;
            }
            sonuclandı = true;
            txt_sayi_giris.Text=islem_sonucu.ToString();
        }

        private void diger_islemler(object sender, EventArgs e)
        {
            if(txt_sayi_giris.Text.Length == 0)
            {
                txt_sayi_giris.Text = "0";
            }
            decimal diger_islemler_sayi = Convert.ToDecimal(txt_sayi_giris.Text);
            decimal sonuc = 0;
            if(((sender as Button).Name == "btn_karekok") && diger_islemler_sayi > 0)
            {
                sonuc = Convert.ToDecimal(Math.Sqrt((double)diger_islemler_sayi));
            }
            if (((sender as Button).Name == "btn_kare"))
            {
                sonuc =diger_islemler_sayi* diger_islemler_sayi;
            }
            if (((sender as Button).Name == "btn_birbolu"))
            {
                sonuc =1/diger_islemler_sayi;
            }
            txt_sayi_giris.Text =sonuc.ToString();
            sonuclandı = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void rakam_girisleri(object sender, EventArgs e)
        {
            if (sonuclandı)
            {
                txt_sayi_giris.Text = (sender as Button).Text;
                sonuclandı = false;
            }
            else
            {
                txt_sayi_giris.Text += (sender as Button).Text;
            }
        }


      
    }
}
