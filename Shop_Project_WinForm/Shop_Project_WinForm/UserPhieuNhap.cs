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
using System.Globalization;


namespace Shop_Project_WinForm
{
    public partial class UserPhieuNhap : UserControl
    {
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLCHQA;Integrated Security=True";
        public UserPhieuNhap()
        {

            InitializeComponent();
            // loadDl();
        }
        int i;
        public void LoatDL()
        {
            string query = "select * from PhieuNhap hd, NhanVien nv,NhaCungCap kh  where hd.MaNV = nv.MaNV and hd.MaNCC=kh.MaNCC";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            dtg1.AutoGenerateColumns = false;
            dtg1.DataSource = data;


        }

        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public bool kiemtra(string MaPN)
        {
            string query = "select *from PhieuNhap where MaPN='" + txmapn.Text + "'";
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
            //   txmanv.Text = "";
            txmapn.Text = "";
            txngaylap.Text = "";
            txtongtien.Text = "";
            // txmncc.Text = "";


        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            i = 1;
            txmapn.Enabled = false;
            txtongtien.Enabled = false;
            txtinhtrang.Enabled = false;
          
        }

            private void gunaButton9_Click(object sender, EventArgs e)
        {
            int i = 2;
            txmapn.Enabled = false;
            txtongtien.Enabled = false;
            txtinhtrang.Enabled = false;
            
          
        }
        public void LoadNV()
        {
            string query = "select*from NhanVien";
            DataTable nhanvien = KetNoi.Instance.excuteQuery(query);
            cbmnv.DataSource = nhanvien;
            cbmnv.ValueMember = "MaNV";
            cbmnv.DisplayMember = "TenNV";
        }
        public void LoadNCC()
        {
            string query = "select*from NhaCungCap";
            DataTable nhanvien = KetNoi.Instance.excuteQuery(query);
            cbtenncc.DataSource = nhanvien;
            cbtenncc.ValueMember = "MaNCC";
            cbtenncc.DisplayMember = "TenNhaCC";
        }

        private void UserPhieuNhap_Load(object sender, EventArgs e)
        {
            LoatDL();
            LoadNV();
            LoadNCC();
            txmapn.ReadOnly = true;
            txmapn.Enabled = false;
            txtinhtrang.Enabled = false;
            txtongtien.Enabled = false;
            txtongtien.ReadOnly = true;
            if (txtinhtrang.Text == "Đã thanh toan")
            {
                btthem.Enabled = false;
                btxoa.Enabled = false;
                btsua.Enabled = false;
            }




        }
        private void formclose(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            LoatDL();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtg1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txmapn.Text = dtg1.CurrentRow.Cells["mapn"].Value.ToString();
            txngaylap.Value = Convert.ToDateTime(dtg1.CurrentRow.Cells["ngaylappn"].Value.ToString());
            cbmnv.Text = dtg1.CurrentRow.Cells["tennv"].Value.ToString();
            cbtenncc.Text = dtg1.CurrentRow.Cells["tennhacc"].Value.ToString();
            txtongtien.Text = dtg1.CurrentRow.Cells["tongtiennhap"].Value.ToString();
          //  txtinhtrang.Text = dtg1.CurrentRow.Cells["tinhtrang"].Value.ToString();
            string a = dtg1.CurrentRow.Cells[3].Value.ToString();
            if (a == "True")
            {
                txtinhtrang.Text = " Đã thanh toan";
                //btsua.Enabled = false;
                //btxoa.Enabled = false;
                //btthem.Enabled = false;


            }
            else if (a == "False")
            {

                txtinhtrang.Text = "Chua thanh toan";
                //btsua.Enabled = true;
                //btxoa.Enabled = true;

            }

            if (e.ColumnIndex == 6)
            {
                this.Visible = false;
                string mapn = dtg1.CurrentRow.Cells["mapn"].Value.ToString();
                chitietphieunhapcs ct = new chitietphieunhapcs(mapn);
                ct.FormClosed += formclose;
                ct.ShowDialog();
            }

        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            if (txmapn.Text == "")
            {
                MessageBox.Show(" vui long chon dong can xoa");
                return;
            }
            else
            {
                try
                {
                    string query = "delete PhieuNhap where MaPN='" + txmapn.Text + "'";
                    DataTable data = KetNoi.Instance.excuteQuery(query);
                    MessageBox.Show(" Xoa thanh cong");
                    LoatDL();

                }
                catch
                {
                    MessageBox.Show(" Xoa That Bai");

                }
            }
        }

        private void txtinhtrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                string querry = "insert into PhieuNhap values(@ngaylap, @tongtiennhap,@tinhtrang,@mancc,@manv)";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                SqlCommand command = new SqlCommand(querry, conn);
                command.Parameters.AddWithValue("@ngaylap", txngaylap.Value.ToString("yyyy/MM/dd"));
                command.Parameters.AddWithValue("@tongtiennhap", 0);
                command.Parameters.AddWithValue("@tinhtrang", false);
                command.Parameters.AddWithValue("@mancc", cbtenncc.SelectedValue.ToString());
                command.Parameters.AddWithValue("@manv", cbmnv.SelectedValue.ToString());


                //command.Parameters.AddWithValue("@tongtiennhap", 0);
                //command.Parameters.AddWithValue("@tinhtrang", false);
                int a = command.ExecuteNonQuery();
                if (a > 0)
                {
                    UserPhieuNhap_Load(sender, e);
                    MessageBox.Show("thêm thanh cong");
                }
                conn.Close();
            }
            else if(i==2)
            {
                try
                {
                    if (cbtenncc.Text == "" || cbmnv.Text == "")
                    {
                        MessageBox.Show("vui long nhap du thong tin");
                    }
                    else
                    {
                        string query = "update PhieuNhap set NgayLapPN= '" + txngaylap.Text + "',TongTienNhap=" + txtongtien.Text + ",TinhTrang='" + txtinhtrang.Text + "',MaNCC='" + cbtenncc.SelectedValue.ToString() + "',MaNV =N'" + cbmnv.SelectedValue.ToString() + "'  where MaPN='" + txmapn.Text + "'";
                        DataTable data = KetNoi.Instance.excuteQuery(query);
                        MessageBox.Show("Sua thanh cong");
                        LoatDL();
                    }
                }
                catch
                {
                    MessageBox.Show(" Sửa thất bại");
                }
            }
        }

        private void txtongtien_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtongtien.Text, System.Globalization.NumberStyles.AllowThousands);
            txtongtien.Text = String.Format(culture, "{0:N0}", value);
            txtongtien.Select(txtongtien.Text.Length, 0);
        }
    }
}
