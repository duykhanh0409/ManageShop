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
using System.Web;
using System.Net.Mail;
using System.Globalization;

namespace Shop_Project_WinForm
{
    public partial class UserHoaDon : UserControl
    {
        public Form1 form;
        
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLCHQA;Integrated Security=True";
       
        public UserHoaDon()
        {
            InitializeComponent();
          
            

        }
       
        int i;

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }
        public void LoatDL()
        {
            string query = "select * from HoaDon hd, NhanVien nv,KhachHang kh  where hd.MaNV = nv.MaNV and hd.MaKH=kh.MaKH";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            dtg1.AutoGenerateColumns = false;
            dtg1.DataSource = data;
            txmhd.Enabled = false;
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
        public void LoadKh()
        {
            string query = "select*from KhachHang";
            DataTable nhanvien = KetNoi.Instance.excuteQuery(query);
           
            cbtenkh.DataSource = nhanvien;
            cbtenkh.ValueMember = "MaKH";
            cbtenkh.DisplayMember = "MaKH";
          
        
    }
        //public bool kiemtratrangthai()
        //{
        //    string sql = "select thanhtoan from hoadon where mahd = '" + txmhd.Text + "'";
        //    // DataTable data = KetNoi.Instanceexcutequery(sql);
        //    DataTable data = KetNoi.Instance.excuteQuery(sql);
        //    bool trangthai = Convert.ToBoolean(data.Rows[0].ItemArray[0].ToString());
        //    return trangthai;
        //}
        private void UserHoaDon_Load(object sender, EventArgs e)
        {
            cbtenkh.SelectedIndex = -1;
            cbmnv.SelectedIndex = -1;
            txtinhtrang.ReadOnly = true;
            txmhd.ReadOnly = true;
            LoadNV();
            LoadKh();
            LoatDL();
            txtongtien.ReadOnly = true;
            txtongtien.Enabled = false;
            txtinhtrang.Enabled = false;
            if (txtinhtrang.Text == "Đã thanh toan")
            {
                btsua.Enabled = false;
                btxoa.Enabled = false;
               // btthem.Enabled = false;
            }
        

        }
        private void formclose(object sender, FormClosedEventArgs e)
        {
            form.Visible = true;
            LoatDL();
        }
       
       
        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txmhd.Text = dtg1.CurrentRow.Cells["mahd"].Value.ToString();
            txngaylap.Value = Convert.ToDateTime(dtg1.CurrentRow.Cells["ngaylap"].Value.ToString());
            cbmnv.Text = dtg1.CurrentRow.Cells["tennv"].Value.ToString();
            cbtenkh.Text = dtg1.CurrentRow.Cells["MaKh"].Value.ToString();
            txtongtien.Text = dtg1.CurrentRow.Cells["tongtien"].Value.ToString();
            //  txtinhtrang.Text = dtg1.CurrentRow.Cells["thanhtoan"].Value.ToString();
            string a  = dtg1.CurrentRow.Cells[1].Value.ToString();
            if (a =="True")
            {
                txtinhtrang.Text = " Đã thanh toan";
                btsua.Enabled = false;
                btxoa.Enabled = false;
                //btthem.Enabled = false;


            }
            else if (a== "False")
            {
            
                txtinhtrang.Text = "Chua thanh toan";
                btsua.Enabled = true;
                btxoa.Enabled = true;

            }

            if (e.ColumnIndex == 6)
            {
                form.Visible = false;
                string mahd = dtg1.CurrentRow.Cells["mahd"].Value.ToString();
                cthoadon ct = new cthoadon(mahd);
                ct.FormClosed += formclose;
                ct.ShowDialog();
            }
            

           
        }
        void setnull()
        {
            txmhd.Text = "";
            txngaylap.Text = "";
            txtinhtrang.Text = "";
            txtongtien.Text = "";
            cbtenkh.Text = "";
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            i = 1;
            txmhd.Enabled = false;
            txngaylap.Enabled = true;
            txtongtien.Enabled = false;
            txtinhtrang.Enabled = false;
            cbmnv.Enabled = true;
            cbtenkh.Enabled = true;
            setnull();
            
          
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            i = 2;
            txmhd.Enabled = false;
            txngaylap.Enabled = true;
            txtongtien.Enabled = false;
            txtinhtrang.Enabled = false;
            cbmnv.Enabled = true;
            cbtenkh.Enabled = true;


        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            if (txmhd.Text == "")
            {
                MessageBox.Show(" vui long chon dong can xoa");
                return;
            }
            else
            {
                try
                {
                    string query = "delete HoaDon where MaHD='" + txmhd.Text + "'";
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

        private void cbtenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtinhtrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbmnv_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                string querry = "insert into hoadon values(@ngaylap,@manv,@makh,@tongtien,@trangthai)";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                SqlCommand command = new SqlCommand(querry, conn);
                command.Parameters.AddWithValue("@manv", cbmnv.SelectedValue.ToString());
                command.Parameters.AddWithValue("@ngaylap", txngaylap.Value.ToString("yyyy/MM/dd"));
                command.Parameters.AddWithValue("@makh", cbtenkh.SelectedValue.ToString());
                command.Parameters.AddWithValue("@tongtien", 0);
                command.Parameters.AddWithValue("@trangthai", false);
                int a = command.ExecuteNonQuery();
                if (a > 0)
                {
                    UserHoaDon_Load(sender, e);
                    MessageBox.Show("thêm thanh cong");
                }
                conn.Close();
            }
            else if(i==2)
            {
                if (cbtenkh.Text == "" || cbmnv.Text == "")
                {
                    MessageBox.Show("vui long nhap du thong tin");
                }
                else
                {
                    string query = "update HoaDon set NgayLap= '" + txngaylap.Text + "',MaNV=N'" + cbmnv.SelectedValue.ToString() + "'," +
                        "MaKH='" + cbtenkh.SelectedValue.ToString() + "',TongTien='" + txtongtien.Text + "'  where MaHD='" + txmhd.Text + "'";
                    DataTable data = KetNoi.Instance.excuteQuery(query);
                    MessageBox.Show("Sua thanh cong");
                    LoatDL();
                }
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //if (txmhd.Text == "")
            //{
            //    MessageBox.Show(" Chọn thông tin nhé.");
            //}
            //else
            //{
            //    try
            //    {
            //        string query = "select GmailKH from KhachHang where MaKH=N'" + cbtenkh.SelectedValue.ToString() + "'";


            //        DataTable data = KetNoi.Instance.excuteQuery(query);
            //        string to1 = data.Rows[0][0].ToString();
            //        string smtp1 = "smtp.gmail.com";
            //        string from1 = "duykhanhlb4999@gmail.com";
            //        string body1 = "cảm ơn bạn đã mua hàng";
            //        string subject1 = "Cảm ơn khách hàng";
            //        string username1 = "duykhanhlb4999@gmail.com";
            //        string password1 = "nguyenngocduykhanh";
            //        MailMessage mail = new MailMessage(from1, to1, subject1, body1);
            //        mail.Attachments.Add(new Attachment(attachment1.Text));
            //        SmtpClient client = new SmtpClient(smtp1);
            //        client.Port = 587;
            //        client.Credentials = new System.Net.NetworkCredential(username1, password1);
            //        client.EnableSsl = true;
            //        client.Send(mail);
            //        MessageBox.Show("Mail send", "success", MessageBoxButtons.OK);
            //        string pass = "1";
            //        //Form1 f = new Form1(pass);
            //    }
            //    catch
            //    {
            //        MessageBox.Show(" Gửi không thành công ");
            //    }


            //}

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    string picPath = open.FileName.ToString();
            //    attachment1.Text = picPath;
            //}
        }

        private void txtongtien_TextChanged(object sender, EventArgs e)
        {

            //System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            //decimal value = decimal.Parse(txtongtien.Text, System.Globalization.NumberStyles.AllowThousands);
            //txtongtien.Text = String.Format(culture, "{0:N0}", value);
            //txtongtien.Select(txtongtien.Text.Length, 0);
        }
    }
}

