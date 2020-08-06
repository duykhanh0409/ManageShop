using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using app = Microsoft.Office.Interop.Excel.Application;

namespace Shop_Project_WinForm
{
    public partial class chitietphieunhapcs : Form
    {
        private string MaPN;
        public chitietphieunhapcs()
        {
            InitializeComponent();
         //   LoatDL();
        }
        public chitietphieunhapcs(string MaPN)
        {
            InitializeComponent();
            this.MaPN = MaPN;
        }
        public void LoatDL()
        {
            string query = "select * from sanpham sp, ctnsp ct where sp.masp = ct.masp and ct.mapn = '" + MaPN + "'";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            dtg1.AutoGenerateColumns = false;
            dtg1.DataSource = data;

        }
        private void LoadSP()
        {
            string query = "select*from SanPham";
            DataTable nhanvien = KetNoi.Instance.excuteQuery(query);
            cbsp.DataSource = nhanvien;
            cbsp.ValueMember = "MaSP";
            cbsp.DisplayMember = "TenSP";
        }
        private void Loadkichthuoc(string masp)
        {


            string query = "select*from ctsp where masp='" + masp + "'";
            DataTable nhanvien = KetNoi.Instance.excuteQuery(query);
            cbkt.DataSource = nhanvien;
            cbkt.ValueMember = "MaSP";
            cbkt.DisplayMember = "kichthuoc";

        }
        private void Loadmausac(string masp)
        {

            string query = "select*from ctsp where masp=N'" + masp + "'";
            DataTable nhanvien = KetNoi.Instance.excuteQuery(query);
            cbms.DataSource = nhanvien;
            cbms.ValueMember = "MaSP";
            cbms.DisplayMember = "MauSac";

        }

        private void chitietphieunhapcs_Load(object sender, EventArgs e)
        {
            txthanhtien.Enabled = false;
            LoatDL();
            LoadSP();
            cbsp.SelectedIndex = -1;
            if (kiemtratrangthai())
            {
                // btnIn.Enabled = false;
                btnThem.Enabled = false;
                btnxoa.Enabled = false;
                btnsua.Enabled = false;
            }
        }

        private void gunaLabel14_Click(object sender, EventArgs e)
        {

        }

        private void cbsp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbsp.SelectedIndex > -1)
            {
                Loadkichthuoc(cbsp.SelectedValue.ToString());
                Loadmausac(cbsp.SelectedValue.ToString());
                cbms.SelectedIndex = -1;
                cbkt.SelectedIndex = -1;
            }
        }

        private void cbms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbms.SelectedIndex > -1)
            {
                string query = "select*from ctsp where masp='" + cbsp.SelectedValue.ToString() + "' and mausac=N'" + cbms.Text.ToString() + "'";
                DataTable nhanvien = KetNoi.Instance.excuteQuery(query);
                cbkt.DataSource = nhanvien;
                cbkt.ValueMember = "MaSP";
                cbkt.DisplayMember = "kichthuoc";

            }
        }

        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbsp.Text = dtg1.CurrentRow.Cells[1].Value.ToString();
            cbms.Text = dtg1.CurrentRow.Cells[2].Value.ToString();
            cbkt.Text = dtg1.CurrentRow.Cells[3].Value.ToString();
            //     Console.WriteLine(dtg1.CurrentRow.Cells["tennv"].Value.ToString());
            txtslton.Text = dtg1.CurrentRow.Cells[4].Value.ToString();

            txgianhap.Text = dtg1.CurrentRow.Cells[5].Value.ToString();
            txthanhtien.Text = dtg1.CurrentRow.Cells[6].Value.ToString();

        }

        private void cbsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbsp.SelectedIndex > -1)
            {
                Loadkichthuoc(cbsp.SelectedValue.ToString());
                Loadmausac(cbsp.SelectedValue.ToString());
                cbms.SelectedIndex = -1;
                cbkt.SelectedIndex = -1;
            }
        }
        public bool kiemtra(string masp, string mausac, string kichthuoc)
        {
            string query = "select * from ctnsp where masp ='" + masp + "'and mausac=N'" + mausac + "'and kichthuoc ='" + kichthuoc + "' and mapn=" + MaPN;
            Console.WriteLine(query);
            DataTable data = KetNoi.Instance.excuteQuery(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        //public bool ktsoluong(string masp, string mausac, string kichthuoc)
        //{
        //    string query2 = "select soluongton from ctsp where masp ='" + masp + "'and mausac=N'" + mausac + "'and kichthuoc ='" + kichthuoc + "'";
        //    DataTable data1 = KetNoi.Instance.excuteQuery(query2);
        //    int slmua = int.Parse(txtslton.Text);
        //    int slton = int.Parse(data1.Rows[0].ItemArray[0].ToString());
        //    if (slmua > slton)
        //    {
        //        MessageBox.Show("Hàng k đủ");
        //        return false;
        //    }
        //    return true;
        //}

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            if (cbms.SelectedIndex == -1 || cbsp.SelectedIndex == -1 || cbkt.SelectedIndex == -1)
            {
                MessageBox.Show("vui long nhap du thong tin");
                return;
            }
            //if (!ktsoluong(cbsp.SelectedValue.ToString(), cbms.Text.Trim(), cbkt.Text.Trim()))
            //    return;
            if (kiemtra(cbsp.SelectedValue.ToString(), cbms.Text.Trim(), cbkt.Text.Trim()))
            {
                Console.WriteLine(kiemtra(cbsp.SelectedValue.ToString(), cbms.Text.Trim(), cbkt.Text.Trim()));
                string capnhap = "update CTNSP set SLNhap+=" + int.Parse(txtslton.Text) + " where MaSP='" + cbsp.SelectedValue + "' and mausac=N'" + cbms.Text + "' and kichthuoc='" + cbkt.Text + "'and MaPN='"+MaPN+"'";
                DataTable data1 = KetNoi.Instance.excuteQuery(capnhap);
                Console.WriteLine(capnhap);
                LoatDL();
                return;

            }
            //else 
            //{
            string query = "insert into CTNSP values(" + int.Parse(MaPN) + ",'" + cbsp.SelectedValue.ToString() + "',N'" + cbms.Text.ToString() + "','" + cbkt.Text.ToString() + "'," + int.Parse(txgianhap.Text) + "," + int.Parse(txtslton.Text) + "," + 0 + ")";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            MessageBox.Show("Them thanh cong");
            LoatDL();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            if (txtslton.Text == "")
            {
                MessageBox.Show(" chọn thông tin cần sửa");
            }
            else
            {
                try
                {
                    string query = "update CTNSP set SLNhap='" + txtslton.Text + "'where MaSP='" + cbsp.SelectedValue + "' and mausac=N'" + cbms.Text + "' and kichthuoc='" + cbkt.Text + "'and MaPN='"+MaPN+"'";
                    DataTable data = KetNoi.Instance.excuteQuery(query);
                    MessageBox.Show("Sua thanh cong");
                    LoatDL();


                }
                catch
                {
                    MessageBox.Show(" Sửa thất bại");
                }
            }
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            if (cbsp.Text == "")
            {
                MessageBox.Show(" vui long chon dong can xoa");
                return;
            }
            else
            {
                try
                {
                    string query = "delete CTNSP where MaSP='" + cbsp.SelectedValue + "' and mausac=N'" + cbms.Text + "' and kichthuoc='" + cbkt.Text + "'and MaPN='"+MaPN+"'";
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

        private void txtslton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txgianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        public bool kiemtratrangthai()
        {
            string sql = "select TinhTrang from PhieuNhap where mapn = '" + MaPN + "'";
            // DataTable data = KetNoi.Instanceexcutequery(sql);
            DataTable data = KetNoi.Instance.excuteQuery(sql);
            bool trangthai = Convert.ToBoolean(data.Rows[0].ItemArray[0].ToString());
            return trangthai;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string querry = "update PhieuNhap set TinhTrang = 1 where MaPN = '" + MaPN + "'";
            DataTable data = KetNoi.Instance.excuteQuery(querry);
        }

        private void txthanhtien_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txthanhtien.Text, System.Globalization.NumberStyles.AllowThousands);
            txthanhtien.Text = String.Format(culture, "{0:N0}", value);
            txthanhtien.Select(txthanhtien.Text.Length, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveFileDialog openDlg = new SaveFileDialog();
            openDlg.InitialDirectory = @"D:\";
            openDlg.FileName = "*.xlsx";
            openDlg.DefaultExt = "xlsx";
            openDlg.RestoreDirectory = true;
            openDlg.Filter = "|*.xlsx";

            //string path = openDlg.FileName

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 18;
                obj.StandardFontSize = 13;
                Console.WriteLine(dtg1.RowCount);
                obj.Cells[1, 1] = "SHOP QUAN ÁO AN BẢO";
                obj.Cells[2, 1] = "380 Lê Văn Việt Quận 9 tp.Hồ chí Minh";
                obj.Cells[3, 1] = "Số điện thoại: 0338269042";
                obj.Cells[5, 3] = "THÔNG TIN HÓA ĐƠN";

                obj.Rows[1].Font.Bold = true;
                obj.Rows[2].Font.Bold = true;
                obj.Rows[3].Font.Bold = true;
                obj.Rows[5].Font.Bold = true;
                obj.Rows[6].Font.Bold = true;
                if (dtg1.Rows.Count > 0)
                {
                    for (int i = 1; i < dtg1.Columns.Count + 1; i++)
                    {
                        obj.Cells[6, i] = dtg1.Columns[i - 1].HeaderText;

                    }
                    for (int i = 0; i < dtg1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtg1.Columns.Count; j++)
                        {
                            if (dtg1.Rows[i].Cells[j].Value != null)
                            {
                                obj.Cells[7 + i, j + 1] = dtg1.Rows[i].Cells[j].Value.ToString();

                            }
                            else
                            {
                                obj.Cells[i + 7, j + 1] = "";
                            }
                        }
                    }
                    obj.ActiveWorkbook.SaveAs(openDlg.FileName);
                    //obj.ActiveWorkbook.SaveAs(); 
                    obj.ActiveWorkbook.Saved = true;
                    MessageBox.Show(" xuat thah cong");
                }
            }
        }
    }
}
    

