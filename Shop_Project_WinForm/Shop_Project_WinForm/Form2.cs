using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Project_WinForm
{
    public partial class Form2 : Form
    {
        string mahd;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine(mahd);
            // TODO: This line of code loads data into the 'QLCHQADataSet5.thongtin' table. You can move, or remove it, as needed.
            this.thongtinTableAdapter.Fill(this.QLCHQADataSet5.thongtin, int.Parse(mahd));
            // TODO: This line of code loads data into the 'QLCHQADataSet5.thongtin' table. You can move, or remove it, as needed.
            //this.thongtinTableAdapter.Fill(this.QLCHQADataSet5.thongtin,int.Parse(mahd));
            // TODO: This line of code loads data into the 'QLCHQADataSet.CTHoaDon' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
