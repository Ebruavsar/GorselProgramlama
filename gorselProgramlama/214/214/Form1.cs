using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _214
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn sutun;
            DataRow satır;

            sutun = new DataColumn("Sıra No");
            sutun.AutoIncrement = true;
            sutun.AutoIncrementStep = 1;

            dt.Columns.Add(sutun);

            sutun = new DataColumn("Adı Soyadı");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Dogum tarihi");
            dt.Columns.Add(sutun);

            dataGridView1.DataSource = dt;


            satır = dt.NewRow();
            satır["Adı Soyadı"] = "melike";
            satır["Dogum tarihi"] = "01.03.1988";

            dt.Rows.Add(satır);

            satır = dt.NewRow();
            satır["Adı Soyadı"] = "Ebru avşar";
            satır["Dogum tarihi"] = "18.09.2000";

            dt.Rows.Add(satır);

            satır = dt.NewRow();
            satır["Adı Soyadı"] = "burla";
            satır["Dogum tarihi"] = "17.09.1998";


            dt.Rows.Add(satır);

        }
    }
}
