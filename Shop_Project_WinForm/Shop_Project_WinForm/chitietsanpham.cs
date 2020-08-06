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
    public partial class chitietsanpham : Form
    {
        private string MaSanPham;
        public chitietsanpham()
        {
            InitializeComponent();
        }
        public chitietsanpham(string masp)
        {
            this.MaSanPham = masp;
            InitializeComponent();
            //    txtMasp.ReadOnly = true;
            txtsoluongton.Enabled = false;

        }
        private void LoadDuLieu()
        {
            string query = "select * from sanpham sp, ctsp ct where sp.masp = ct.masp and sp.masp = '" + MaSanPham + "'";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.DataSource = data;
        }

        private void chitietsanpham_Load(object sender, EventArgs e)
        {
            LoadDuLieu();

        }
        public bool kiemtra(string masp, string mausac, string kichthuoc)
        {
            string query = "select * from ctsp where masp ='" + MaSanPham + "'and mausac=N'" + mausac + "'and kichthuoc ='" + kichthuoc + "'";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            int dem = 0;
            Console.WriteLine(query);
            foreach (DataRow item in data.Rows)
            {
                dem++;
            }
            if (dem > 0)
                return true;
            return false;
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            else
            {
                txtMasp.Text = dgvChiTiet.Rows[row].Cells[0].Value.ToString();
                txtmasac.Text = dgvChiTiet.Rows[row].Cells[1].Value.ToString();
                txtkichthuoc.Text = dgvChiTiet.Rows[row].Cells[2].Value.ToString();
                txtGiaBan.Text = dgvChiTiet.Rows[row].Cells[3].Value.ToString();
                txtsoluongton.Text = dgvChiTiet.Rows[row].Cells[4].Value.ToString();


            }

        }
        void setNull()
        {
           
            txtkichthuoc.Text = "";
            txtmasac.Text = "";
            txtsoluongton.Text = "";
            txtGiaBan.Text = "";
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {

            if (txtMasp.Text == "" || txtmasac.Text == "" || txtkichthuoc.Text == "" || txtGiaBan.Text == "")
            {
                MessageBox.Show(" Vui long nhap day du thong tin");
                return;
            }
            if (kiemtra(txtMasp.Text.Trim(), txtmasac.Text.Trim(), txtkichthuoc.Text.Trim()))
            {
                MessageBox.Show("Ma trung Nhe");
                return;
            }

            try
            {
                string query = "insert into CTSP values('" + txtMasp.Text + "',N'" + txtmasac.Text + "',N'" + txtkichthuoc.Text + "','" + txtGiaBan.Text + "','"+txtsoluongton.Text+"')";
                DataTable data = KetNoi.Instance.excuteQuery(query);
                MessageBox.Show("Them thanh cong");
                setNull();
                LoadDuLieu();

            }
            catch
            {
                MessageBox.Show(" Them that bai");
            }
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            if (txtmasac.Text == "" || txtkichthuoc.Text == "" || txtMasp.Text == "")
            {
                MessageBox.Show("Chon dong can xoa");
                return;
            }
            else
            {



                try
                {
                    string query = "delete CTSP  where MaSP='" + txtMasp.Text + "'and MauSac=N'" + txtmasac.Text + "'";
                    DataTable data = KetNoi.Instance.excuteQuery(query);
                    MessageBox.Show("Xoa thanh cong");
                    setNull();
                    LoadDuLieu();
                }
                catch
                {
                    MessageBox.Show(" xoa that bai");

                }
            }
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            if (txtmasac.Text == "" || txtkichthuoc.Text == "" || txtGiaBan.Text == "")
            {
                MessageBox.Show(" Vui long nhap day du thong tin nhe");
                return;

            }
            else
            {


                try
                {
                    string query = "update CTSP set  SoLuongTon='" + txtsoluongton.Text + "',GiaBan='"+txtGiaBan.Text+"' where MaSP='" + txtMasp.Text + "'and MauSac=N'" + txtmasac.Text + "'and KichThuoc=N'" + txtkichthuoc.Text + "'";
                    DataTable data = KetNoi.Instance.excuteQuery(query);
                    MessageBox.Show("Sua thanh cong");
                    setNull();
                    LoadDuLieu();
                }
                catch
                {
                    MessageBox.Show(" Sua That Bai");

                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            setNull();
        }

        private void txtsoluongton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
