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
    public partial class HangTon : Form
    {
        public HangTon()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
          //  this.Visible = false;
          //  slton3thang f = new slton3thang();
          ////  f.FormClosed += closeForm;
          //  f.Show();
          //  f.BringToFront();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //quanlytonkho1nam f = new quanlytonkho1nam();
            ////f.FormClosed += closeForm;
            //f.Show();
            //f.BringToFront();
        }

        private void HangTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCHQADataSet9.quanliHangTonKho' table. You can move, or remove it, as needed.
           
            //Form1 f = new Form1();
            ////  f.FormClosed += closeForm;
            //f.Show();
            //f.BringToFront();

            
        }
        private void formClose(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
           
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.quanliHangTonKhoTableAdapter.Fill(this.QLCHQADataSet9.quanliHangTonKho,  dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            //this.reportViewer1.RefreshReport();
           // this.Visible = false;
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            this.quanliHangTonKhoTableAdapter.Fill(this.QLCHQADataSet9.quanliHangTonKho, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
