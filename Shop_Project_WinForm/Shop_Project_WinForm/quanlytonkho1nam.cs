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
    public partial class quanlytonkho1nam : Form
    {
        public quanlytonkho1nam()
        {
            InitializeComponent();
        }

        private void quanlytonkho1nam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCHQADataSet8.quanlihangtonnam' table. You can move, or remove it, as needed.
            this.quanlihangtonnamTableAdapter.Fill(this.QLCHQADataSet8.quanlihangtonnam);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            HangTon f = new HangTon();
            //  f.FormClosed += closeForm;
            f.Show();
            f.BringToFront();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
