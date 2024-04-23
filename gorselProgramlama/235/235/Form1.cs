using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _235
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] partiler = new string[20];
        int[] oylar = new int[20];
        int sıra_no, toplam_oy;
        private void button1_Click(object sender, EventArgs e)
        {
            if(sıra_no == 20)
            {
                MessageBox.Show("En çok 20 parti olabilir");
            }
            try
            {
                oylar[sıra_no] = Convert.ToInt32(textBox2.Text);
            }
            catch {
                MessageBox.Show("oy saysında hata var");
                return;
            }
            partiler[sıra_no] = textBox1.Text;
            toplam_oy += oylar[sıra_no];
            sıra_no++;

            Graphics gr;
            gr = this.CreateGraphics();

            int baslangıc_acısı = 0, yay_acısı = 0;
            Color renk;
            System.Drawing.Drawing2D.HatchBrush fırca;
            Random r =new Random();

            for(int i = 0;i<sıra_no;i++)
            {
                yay_acısı = 360 * oylar[i] / toplam_oy;
                renk = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                fırca = new System.Drawing.Drawing2D.HatchBrush((System.Drawing.Drawing2D.HatchStyle)r.Next(50), renk);

                gr.FillPie(fırca, 0, 80, 200, 200, baslangıc_acısı, yay_acısı);

                gr.FillRectangle(fırca, 210, 80 + i * 20, 18, 18);

                gr.DrawString(partiler[i] + " = " + oylar[i].ToString(), new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Red), 230, 80 + i * 20);

                baslangıc_acısı += yay_acısı;
            }
        }
    }
}
