﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _97
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 cocuk_form = new Form2();
            cocuk_form.MdiParent = this;
            cocuk_form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form2 cocuk_form = new Form2();
            cocuk_form.MdiParent = this;
            cocuk_form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 cocuk_form = new Form2();
            cocuk_form.MdiParent = this;
            cocuk_form.Show();
        }
    }
}
