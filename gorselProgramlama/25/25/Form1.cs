using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[][] jaggeddizi = new int[3][];
            jaggeddizi[0] = new int[2];
            jaggeddizi[1] = new int[5];
            jaggeddizi[2] = new int[4];
            int a = Convert.ToInt32(vc.InputBox("Satır sayısını giriniz", "", "", 100, 100));
            int[][] jaggeddizi1 = new int[a][];
            for (int i = 0; i < a; i++)
            {
                string satir = "";
                jaggeddizi[i] = new int[Convert.ToInt32(vc.InputBox(i + 1 + ". satırın sütun sayısını giriniz.", "", "", 100, 100))];
                for (int j = 0; j < jaggeddizi1[i].Length; j++)
                {
                    jaggeddizi[i][j] = Convert.ToInt32(vc.InputBox(j + 1 + ". sütunun degerlerini giriniz.", "", "", 100, 100));
                    satir = satir + "\t" + jaggeddizi1[i][j].ToString();
                }
                listBox1.Items.Add(satir);

            }
        }
    }
}
