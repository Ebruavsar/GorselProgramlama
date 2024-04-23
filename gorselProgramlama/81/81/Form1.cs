using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _81
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics elips;
        int x, y;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                elips = this.CreateGraphics();
                elips.DrawEllipse(new Pen(Color.Green), x - Math.Abs(x - e.X) / 2,
                                                        y - Math.Abs(y - e.Y) / 2,
                                                        Math.Abs(x - e.X),
                                                        Math.Abs(y - e.Y));
                elips.Dispose();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            if (e.Button == MouseButtons.Right)
            {
                elips = this.CreateGraphics();
                elips.Clear(Color.Gray);
                elips.Dispose();
            }
        }
    }
}
