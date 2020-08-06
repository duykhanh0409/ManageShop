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
    public partial class slton3thang : Form
    {
        public slton3thang()
        {
            InitializeComponent();
        }

        private void slton3thang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCHQADataSet6.quanlihangton' table. You can move, or remove it, as needed.
            this.quanlihangtonTableAdapter.Fill(this.QLCHQADataSet6.quanlihangton);

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
    }
}
