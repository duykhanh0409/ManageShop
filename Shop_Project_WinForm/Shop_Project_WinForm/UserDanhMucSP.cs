using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shop_Project_WinForm
{
    public partial class UserDanhMucSP : UserControl
    {
        public UserDanhMucSP()
        {
            InitializeComponent();
            loadDl();
        }
        public void loadDl()
        {
            string query = "select *from NhomSanPham";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            dtg1.DataSource = data;
        }
       void setnull()
        {
            txtennhom.Text = "";
            txmanhom.Text = "";
        }
        public bool kiemtra(string MaNhom)
        {
            string query = "select *from NhomSanPham where MaNhom='" + txmanhom.Text + "'";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            int dem = 0;
            foreach (DataRow item in data.Rows)
            {
                dem++;
            }
            if (dem > 0)
                return true;
            return false;
        }
        private void UserDanhMucSP_Load(object sender, EventArgs e)
        {

        }

        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            else
            {
                txmanhom.Text = dtg1.Rows[row].Cells[0].Value.ToString();
                txtennhom.Text = dtg1.Rows[row].Cells[1].Value.ToString();
               




            }
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            txmanhom.Enabled = true;
            txtennhom.Enabled = true;
           
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            txmanhom.Enabled = false;
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            if (txmanhom.Text == "" || txtennhom.Text == "")
            {
                MessageBox.Show(" vui lòng chọn dòng cần xóa");
            }
            try
            {
                string query = "delete NhomSanPham where MaNhom='" + txmanhom.Text + "' ";
                DataTable data = KetNoi.Instance.excuteQuery(query);
                MessageBox.Show("Xóa Thành Công");
                loadDl();

            }
            catch
            {
                MessageBox.Show(" Xóa thất bại");
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txmanhom.Enabled)
            {


                if (txmanhom.Text == "" || txtennhom.Text == "")
                {
                    MessageBox.Show("vui long nhap du thong tin");
                }
                else
                {
                    if (kiemtra(txmanhom.Text) == true)
                    {
                        MessageBox.Show("ma da ton tai");
                        return;
                    }
                    try
                    {
                        string query = "insert into NhomSanPham values ('" + txmanhom.Text + "',N'" + txtennhom.Text + "')";
                        DataTable data = KetNoi.Instance.excuteQuery(query);
                        MessageBox.Show("Thêm thanh cong");
                        loadDl();
                        setnull();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm that bai");
                    }
                }
            }
            else
            {
                if (txtennhom.Text == "")
                {
                    MessageBox.Show("vui long nhap du thong tin");
                }
                else
                {

                    try
                    {
                        string query = "update NhomSanPham set TenNhom= N'" + txtennhom.Text + "' where MaNhom='" + txmanhom.Text + "'";
                        DataTable data = KetNoi.Instance.excuteQuery(query);
                        MessageBox.Show("Sửa thành công");
                        loadDl();
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }
    }
    }

