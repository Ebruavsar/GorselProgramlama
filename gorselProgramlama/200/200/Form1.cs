using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Üniversite");
            treeView1.Nodes[0].Nodes.Add("Gazi Üniversitesi");
            treeView1.Nodes[0].Nodes.Add("Boğaziçi Üniversitesi");
            treeView1.Nodes[0].Nodes.Add("Muğla Üniversitesi");
            treeView1.Nodes[0].Nodes.Add("Kocaeli Üniversitesi");
            treeView1.Nodes[0].Nodes.Add("Gazi Üniversitesi");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("Mühendislik Fakl");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Tekonoloji Fakl");

            treeView1.Nodes[0].Nodes[2].Nodes.Add("hukuk Fakl");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("orman Fakl");
            treeView1.Nodes[0].Nodes[2].Nodes.Add("eğitim Fakl");

            TreeNode x, y;
            x = treeView1.Nodes.Add("Kocaali üNiversite");
            x.Nodes.Add("Mühendiislik fakültesi");
            x.Nodes.Add("hukhuk fakültesi");
            x.Nodes.Add("sağlam fakültesi");
            x.Nodes.Add("orman fakültesi");
            x.Nodes.Add("tıp fakültesi");
            
        }
    }
}
