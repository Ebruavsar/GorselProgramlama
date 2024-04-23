using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _204
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("adı soyası", -1, HorizontalAlignment.Left);
            listView1.Columns.Add("üniversitesi", -1, HorizontalAlignment.Left);
            listView1.Columns.Add("bölümü", -1, HorizontalAlignment.Left);

            listView1.Items.Add("Uğur");
            listView1.Items[0].SubItems.Add("Muğla Üni");
            listView1.Items[0].SubItems.Add("Bilgisayar müh");

            listView1.Items.Add("Kenan");
            listView1.Items[1].SubItems.Add("ODTÜ");
            listView1.Items[1].SubItems.Add("Endüstri Müh.");

            listView1.Items.Add("Zeynep");
            listView1.Items[2].SubItems.Add("Düzce Üni");
            listView1.Items[2].SubItems.Add("tercümanlık");

            listView1.Items.Add("ebru");
            listView1.Items[3].SubItems.Add("Düzce Üni");
            listView1.Items[3].SubItems.Add("bilgisayar mühendisliği");

            listView1.View = View.Details;
            listView1.Sorting = SortOrder.Ascending;
        }
    }
}
