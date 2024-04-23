using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _237_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image resim = Image.FromFile("C:\\Users\\ebrua\\Desktop\\201001077-EbruAvsar-NÖ\\Ekran görüntüsü 2024-04-17 182733.png");

            System.Drawing.Drawing2D.GraphicsPath p = new System.Drawing.Drawing2D.GraphicsPath();
            
            //alan

            //p.AddEllipse(0, 0, resim.Width, resim.Height);
            //e.Graphics.SetClip(p);
            //e.Graphics.DrawImage(resim, 0, 0);

            ////200 derecelik bir daileyi silme
            
            //p.AddPie(0, 0, resim.Width, resim.Height,30,200);
            //e.Graphics.SetClip(p);
            //e.Graphics.DrawImage(resim, 0, 0);

            //açı

            e.Graphics.RotateTransform(315);
            e.Graphics.DrawImage(resim, -120, 120);
        }
    }
}
