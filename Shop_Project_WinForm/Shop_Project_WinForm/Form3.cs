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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCHQADataSet2.ds_hoadon' table. You can move, or remove it, as needed.
          //  this.ds_hoadonTableAdapter.Fill(this.QLCHQADataSet2.ds_hoadon);
            // TODO: This line of code loads data into the 'QLCHQADataSet3.ds_hoadon' table. You can move, or remove it, as needed.
            // this.ds_hoadonTableAdapter.Fill(this.QLCHQADataSet3.ds_hoadon,dat);
            // TODO: This line of code loads data into the 'QLCHQADataSet2.ds_hoadon' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.ds_hoadonTableAdapter.Fill(this.QLCHQADataSet2.ds_hoadon, dtpktunngay.Value, dtpkdenngay.Value);

            //this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string query = "select CONVERT(nvarchar(30), NgayLap,23)as NgayLap,sum(TongTien)as TongTien from HoaDon where NgayLap between N'"+dtpktunngay.Text+"' and N'"+dtpkdenngay.Text+"' group by NgayLap";
            //bieudo bd = new bieudo(query);
            //this.Hide();
            //bd.ShowDialog();
            //this.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.ds_hoadonTableAdapter.Fill(this.QLCHQADataSet2.ds_hoadon, dtpktunngay.Value, dtpkdenngay.Value);

            this.reportViewer1.RefreshReport();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string query = "select CONVERT(nvarchar(30), NgayLap,23)as NgayLap,sum(TongTien)as TongTien from HoaDon where NgayLap between N'" + dtpktunngay.Text + "' and N'" + dtpkdenngay.Text + "' group by NgayLap";
            bieudo bd = new bieudo(query);
            this.Hide();
            bd.ShowDialog();
            this.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ds_hoadonBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
