using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Globalization;

using app = Microsoft.Office.Interop.Excel.Application;


namespace Shop_Project_WinForm
{
    public partial class cthoadon : Form
    {
        private string MaHD;
        public cthoadon()
        {
            InitializeComponent();
            
        }
        int i;
        public cthoadon(string MaHD)
        {
            this.MaHD = MaHD;
            InitializeComponent();

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
        public void LoatDL()
        {
            string query = "select * from sanpham sp, cthoadon ct where sp.masp = ct.masp and ct.mahd = '" + MaHD + "'";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            dtg1.AutoGenerateColumns = false;
            dtg1.DataSource = data;

        }

        private void cthoadon_Load(object sender, EventArgs e)
        {
            txthanhtien.Enabled = false;
            LoatDL();
            LoadSP();
            cbsp.SelectedIndex = -1;
            if (kiemtratrangthai())
            {
               // btnIn.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
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

        private void cbkt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public bool kiemtra(string masp, string mausac, string kichthuoc)
        {
            string query = "select * from cthoadon where masp ='" + masp + "'and mausac=N'" + mausac + "'and kichthuoc ='" + kichthuoc + "' and mahd=" + MaHD;
            Console.WriteLine(query);
            DataTable data = KetNoi.Instance.excuteQuery(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        public bool ktsoluong(string masp, string mausac, string kichthuoc)
        {
            string query2 = "select soluongton from ctsp where masp ='" + masp + "'and mausac=N'" + mausac + "'and kichthuoc ='" + kichthuoc + "'";
            DataTable data1 = KetNoi.Instance.excuteQuery(query2);
            int slmua = int.Parse(txtslton.Text);
            int slton = int.Parse(data1.Rows[0].ItemArray[0].ToString());
            if (slmua > slton)
            {
                MessageBox.Show("Hàng k đủ");
                return false;
            }
            return true;
        }
        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbsp.Text = dtg1.CurrentRow.Cells[1].Value.ToString();
            cbms.Text = dtg1.CurrentRow.Cells[2].Value.ToString();
            cbkt.Text = dtg1.CurrentRow.Cells[3].Value.ToString();
            //     Console.WriteLine(dtg1.CurrentRow.Cells["tennv"].Value.ToString());
            txtslton.Text = dtg1.CurrentRow.Cells[4].Value.ToString();

            //txgiaban.Text = dtg1.CurrentRow.Cells[5].Value.ToString();
            txthanhtien.Text = dtg1.CurrentRow.Cells[5].Value.ToString();
        }

        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbsp.Text = dtg1.CurrentRow.Cells[1].Value.ToString();
            cbms.Text = dtg1.CurrentRow.Cells[2].Value.ToString();
            cbkt.Text = dtg1.CurrentRow.Cells[3].Value.ToString();
            //     Console.WriteLine(dtg1.CurrentRow.Cells["tennv"].Value.ToString());
            txtslton.Text = dtg1.CurrentRow.Cells[4].Value.ToString();

            //txgiaban.Text = dtg1.CurrentRow.Cells[5].Value.ToString();
            txthanhtien.Text = dtg1.CurrentRow.Cells[5].Value.ToString();
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            if (cbms.SelectedIndex == -1 || cbsp.SelectedIndex == -1 || cbkt.SelectedIndex == -1)
            {
                MessageBox.Show("vui long nhap du thong tin");
                return;
            }
            if (!ktsoluong(cbsp.SelectedValue.ToString(), cbms.Text.Trim(), cbkt.Text.Trim()))
                return;
            if (kiemtra(cbsp.SelectedValue.ToString(), cbms.Text.Trim(), cbkt.Text.Trim()))
            {
                Console.WriteLine(kiemtra(cbsp.SelectedValue.ToString(), cbms.Text.Trim(), cbkt.Text.Trim()));
                string capnhap = "update CTHoaDon set SoLuongBan+=" + int.Parse(txtslton.Text) + " where MaSP='" + cbsp.SelectedValue + "' and mausac=N'" + cbms.Text + "' and kichthuoc='" + cbkt.Text + "'and MaHD='" + MaHD + "'";
                int ThanhTien = 0;

                DataTable data1 = KetNoi.Instance.excuteQuery(capnhap);
                Console.WriteLine(capnhap);
                LoatDL();
                return;

            }
            //else 
            //{
            string query = "insert into CTHoaDon values(" + int.Parse(MaHD) + ",'" + cbsp.SelectedValue.ToString() + "',N'" + cbms.Text.ToString() + "','" + cbkt.Text.ToString() + "'," + int.Parse(txtslton.Text) + "," + 0 + ")";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            MessageBox.Show("Them thanh cong");
            LoatDL();

        }

        private void cbms_Click(object sender, EventArgs e)
        {

        }

        private void cbkt_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel13_Click(object sender, EventArgs e)
        {

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
                    string query = "update CTHoaDon set SoLuongBan='" + txtslton.Text + "'where MaSP='" + cbsp.SelectedValue + "' and mausac=N'" + cbms.Text + "' and kichthuoc='" + cbkt.Text + "' and mahd ='" + MaHD + "'";
                    Console.WriteLine(query);
                    DataTable data = KetNoi.Instance.excuteQuery(query);
                    MessageBox.Show("Sua thanh cong");
                    LoatDL();


                }
                catch
                {
                    MessageBox.Show(" Thêm thất bại");
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
                    string query = "delete CTHoaDon where MaSP='" + cbsp.SelectedValue + "' and mausac=N'" + cbms.Text + "' and kichthuoc='" + cbkt.Text + "'";
                    Console.WriteLine(query);
                    DataTable data = KetNoi.Instance.excuteQuery(query);
                    MessageBox.Show(" Xoa thanh cong");
                    LoatDL();

                }
                catch
                {
                    MessageBox.Show(" Xoa That Bai");

                }
            }
            cthoadon_Load(sender, e);

        }
        public bool kiemtratrangthai()
        {
            string sql = "select thanhtoan from hoadon where mahd = '" + MaHD + "'";
            // DataTable data = KetNoi.Instanceexcutequery(sql);
            DataTable data = KetNoi.Instance.excuteQuery(sql);
            bool trangthai = Convert.ToBoolean(data.Rows[0].ItemArray[0].ToString());
            return trangthai;
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
          
            string querry = "update hoadon set thanhtoan = 1 where MaHD = '" + MaHD + "'";
            DataTable data = KetNoi.Instance.excuteQuery(querry);
            Form2 f = new Form2(MaHD);
            this.Visible = false;
            f.FormClosed += formClose;
            f.Show();
            cthoadon_Load(sender, e);

        }

        private void formClose(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            //string querry = "update hoadon set thanhtoan = 1 where mahd = '" + MaHD + "'";
            //DataTable data = KetNoi.Instance.excuteQuery(querry);
            //Form2 f = new Form2();
            //f.Show();
            //cthoadon_Load(sender, e);

        }

        private void txtslton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void gunaButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveFileDialog openDlg = new SaveFileDialog();
            openDlg.InitialDirectory = @"D:\";
            openDlg.FileName = "*.xlsx";
            openDlg.DefaultExt = "xlsx";
            openDlg.RestoreDirectory = true;
            openDlg.Filter = "|*.xlsx";

            //string path = openDlg.FileName;

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                app obj = new app();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 18;
                obj.StandardFontSize = 13;
                Console.WriteLine(dtg1.RowCount);
                obj.Cells[1, 1] = "SHOP QUAN AO An Bảo";
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

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void txthanhtien_TextChanged(object sender, EventArgs e)
        {

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txthanhtien.Text, System.Globalization.NumberStyles.AllowThousands);
            txthanhtien.Text = String.Format(culture, "{0:N0}", value);
            txthanhtien.Select(txthanhtien.Text.Length, 0);
        }

        private void gunaButton2_Click(object sender, EventArgs e)

        {

            string querry = "update hoadon set thanhtoan = 1 where MaHD = '" + MaHD + "'";
            DataTable data = KetNoi.Instance.excuteQuery(querry);

            string endpoint = "https://test-payment.momo.vn/gw_payment/transactionProcessor";
            string partnerCode = "MOMOGYDM20200710";
            string accessKey = "NOKj7ynHSggRg93Q";
            string serectkey = "NAGP9J3tNFn1rg2OoQMc8oEQnRLr4M92";
            string orderInfo = "";
            string returnUrl = "https://momo.vn/return";
            string notifyurl = "https://momo.vn/notify";
            int tongTien = 0;
            string thongtin = "";
            for (int i = 0; i < dtg1.RowCount - 1; i++)
            {
                thongtin = thongtin + (string)dtg1[1, i].Value.ToString() + "/" + (string)dtg1[2, i].Value.ToString() + "/" + (string)dtg1[3, i].Value.ToString() + ".";
                tongTien += (int)dtg1[5, i].Value;

            }

            string amount = tongTien.ToString();
            orderInfo = thongtin.ToString();





            // MessageBox.Show(testValue2.ToString());


            string orderid = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";

            //Before sign HMAC SHA256 signature
            string rawHash = "partnerCode=" +
                partnerCode + "&accessKey=" +
                accessKey + "&requestId=" +
                requestId + "&amount=" +
                amount + "&orderId=" +
                orderid + "&orderInfo=" +
                orderInfo + "&returnUrl=" +
                returnUrl + "&notifyUrl=" +
                notifyurl + "&extraData=" +
                extraData;

            //log.Debug("rawHash = " + rawHash);




            Momopay crypto = new Momopay();
            //sign signature SHA256
            string signature = crypto.signSHA256(rawHash, serectkey);
            // log.Debug("Signature = " + signature);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "accessKey", accessKey },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderid },
                { "orderInfo", orderInfo },
                { "returnUrl", returnUrl },
                { "notifyUrl", notifyurl },
                { "extraData", extraData },
                { "requestType", "captureMoMoWallet" },
                { "signature", signature }

            };
            //   log.Debug("Json request to MoMo: " + message.ToString());
            string responseFromMomo = Pay.sendPaymentRequest(endpoint, message.ToString());

            JObject jmessage = JObject.Parse(responseFromMomo);
            //log.Debug("Return from MoMo: " + jmessage.ToString());
            DialogResult result = MessageBox.Show(responseFromMomo, "Open in browser", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //yes...
                System.Diagnostics.Process.Start(jmessage.GetValue("payUrl").ToString());
            }
            else if (result == DialogResult.Cancel)
            {
                //no...
            }
        }
    }
}
    


