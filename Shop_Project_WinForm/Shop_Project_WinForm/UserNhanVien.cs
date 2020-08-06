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
    public partial class UserNhanVien : UserControl
    {
        public UserNhanVien()
        {
            InitializeComponent();
            loadDl();
        }
        public void loadDl()
        {
            string query = "select *from NhanVien";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            dtg1.DataSource = data;
        }
        public bool kiemtra(string MaNV)
        {
            string query = "select *from NhanVien where MaNV='" + txmanv.Text + "'";
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
        void setnull()
        {
            txmanv.Text = "";
            txnv.Text = "";
            txchucvu.Text = "";
            txngayvaolm.Text = "";
            txluong.Text = "";
            txsdt.Text = "";
            txgmail.Text = "";

        }


        private void gunaButton10_Click(object sender, EventArgs e)
        {
            txmanv.Enabled = true;
            txchucvu.Enabled = true;
            txluong.Enabled = true;
            txnv.Enabled = true;
            txsdt.Enabled = true;
            setnull();

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
                txmanv.Text = dtg1.Rows[row].Cells[0].Value.ToString();
                txnv.Text = dtg1.Rows[row].Cells[1].Value.ToString();
                txchucvu.Text = dtg1.Rows[row].Cells[2].Value.ToString();
                txngayvaolm.Text = dtg1.Rows[row].Cells[3].Value.ToString();
                txluong.Text = dtg1.Rows[row].Cells[4].Value.ToString();
                txgmail.Text = dtg1.Rows[row].Cells[5].Value.ToString();
                txsdt.Text = dtg1.Rows[row].Cells[6].Value.ToString();




            }
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            txmanv.Enabled = false;

        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            if (txmanv.Text == "" || txnv.Text == "")
            {
                MessageBox.Show(" vui lòng chọn dòng cần xóa");
            }
            try
            {
                string query = "delete NhanVien where MaNV='" + txmanv.Text + "' ";
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
            if (txmanv.Enabled)
            {
                if (txmanv.Text == "" || txnv.Text == "" || txchucvu.Text == "" || txngayvaolm.Text == "" || txsdt.Text == "")
                {
                    MessageBox.Show("vui long nhap du thong tin");
                }
                else
                {
                    if (kiemtra(txmanv.Text) == true)
                    {
                        MessageBox.Show("ma da ton tai");
                        return;
                    }
                    try
                    {
                        string query = "insert into NhanVien values (N'" + txmanv.Text + "',N'" + txnv.Text + "',N'" + txchucvu.Text + "','" + txngayvaolm.Text + "','" + txluong.Text + "','" + txgmail.Text + "','" + txsdt.Text + "')";
                        DataTable data = KetNoi.Instance.excuteQuery(query);
                        MessageBox.Show("them thanh cong");
                        loadDl();
                    }
                    catch
                    {
                        MessageBox.Show("them that bai");
                    }
                }
            }

            else
            {
                if (txnv.Text == "" || txchucvu.Text == "" || txngayvaolm.Text == "" || txluong.Text == "" || txsdt.Text == "")
                {
                    MessageBox.Show("vui long nhap du thong tin");
                }
                else
                {

                    try
                    {
                        string query = "update NhanVien set TenNV= N'" + txnv.Text + "',ChucVu=N'" + txchucvu.Text + "',NgayVaoLam='" + txngayvaolm.Text + "',Luong='" + txluong.Text + "',Gmail=N'" + txgmail.Text + "',SDT='" + txsdt.Text + "' where MaNV='" + txmanv.Text + "'";
                        DataTable data = KetNoi.Instance.excuteQuery(query);
                        MessageBox.Show("Sửa thành công roi nhe ");
                        loadDl();
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }

            }
                }

        private void txluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void panel_nhanvien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        }
    


