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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            if (txten.Text.Trim() == "" && txmk.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không được để trống thông tin");
                return;
            }
            DataTable ds_taikhoan = new KetNoi().excuteQuery("select * from taikhoan where tentaikhoan = '" + txten.Text + "' and matkhau = '" + txmk.Text + "'");
            if (ds_taikhoan.Rows.Count > 0)
            {
                this.Visible = false;
                int id = int.Parse(ds_taikhoan.Rows[0].ItemArray[2].ToString());
                Form1 form = new Form1(id);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai thông tin rồi hãy nhập lại nhé");
            }
        }

        private void txmk_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
