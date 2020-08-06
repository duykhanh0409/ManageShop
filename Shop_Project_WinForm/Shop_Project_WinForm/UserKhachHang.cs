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

namespace Shop_Project_WinForm
{
    public partial class UserKhachHang : UserControl
    {
        public UserKhachHang()
        {
            InitializeComponent();
            loadDl();
            txmkh.Enabled = false;
        }
        public void loadDl()
        {
            string query = "select *from KhachHang";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            dtg1.DataSource = data;
        }
        void setnull()
        {
            txmkh.Text = "";
            txtkh.Text = "";
            txngaysinh.Text = "";
            txsdt.Text = "";
            txgmail.Text = "";

        }
        public bool kiemtra(string MaKH)
        {
            string query = "select *from KhachHang where MaKH='" + txmkh.Text + "'";
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
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
                txmkh.Text = dtg1.Rows[row].Cells["MaKH"].Value.ToString();

                txtkh.Text = dtg1.Rows[row].Cells["TenKH"].Value.ToString();
                txngaysinh.Text = dtg1.Rows[row].Cells["NgaySinh"].Value.ToString();
                txsdt.Text = dtg1.Rows[row].Cells["SDT"].Value.ToString();
                txgmail.Text = dtg1.Rows[row].Cells["GmailKH"].Value.ToString();
                





            }
            //int row = e.RowIndex;
            //if (row >= 0)
            //{
            //    //MessageBox.Show(dtg1.Rows[row].Cells["MaKH"].Value.ToString());
            //    txmkh.Text = dtg1.Rows[row].Cells["MaKH"].Value.ToString();
            //    txtkh.Text = dtg1.Rows[row].Cells["TenKH"].Value.ToString();

            //    txsdt.Text = dtg1.Rows[row].Cells["sdt"].Value.ToString();
            //    txgmail.Text = dtg1.Rows[row].Cells["gmail"].Value.ToString();
            //    txngaysinh.Text = dtg1.Rows[row].Cells["NgaySinh"].Value.ToString();
            //}


            //}
        }

        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            txmkh.Enabled = true;
            txgmail.Enabled = true;
            txsdt.Enabled = true;
            txngaysinh.Enabled = true;
            txtkh.Enabled = true;
            setnull();
            
           
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            txmkh.Enabled = false;
            
        }

        private void UserKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txmkh.Enabled)
            {
                if ( txtkh.Text == "")
                {
                    MessageBox.Show("vui long nhap du thong tin");
                }
                else
                {
                    if (kiemtra(txmkh.Text) == true)
                    {
                        MessageBox.Show("ma da ton tai");
                        return;
                    }
                    try
                    {
                        string query = "insert into KhachHang values (N'" + txtkh.Text + "','" + txngaysinh.Text + "','" + txsdt.Text + "','" + txgmail.Text + "')";
                        DataTable data = KetNoi.Instance.excuteQuery(query);
                        MessageBox.Show("Thêm thanh cong");
                        loadDl();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm that bai");
                    }
                }
            }
            else
            {
                if (txtkh.Text == "" || txsdt.Text == "")
                {
                    MessageBox.Show("vui long nhap du thong tin");
                }
                else
                {

                       try
                      {
                    string query = "update KhachHang set TenKH= N'" + txtkh.Text + "',SDT='" + txsdt.Text + "',GmailKH=N'" + txgmail.Text + "',NgaySinh='" + txngaysinh.Text + "' where MaKH='" + txmkh.Text + "'";
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

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            string query = " delete KhachHang where MaKH='" + txmkh.Text + "'";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            MessageBox.Show(" xóa thành công");
            loadDl();
        }

        private void txsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (txmkh.Text == "")
            {
                MessageBox.Show(" Chọn thông tin nhé.");
            }
            else
            {
                try
                {
                    string query = "select GmailKH from KhachHang where MaKH=N'"+txmkh.Text+"'";


                    DataTable data = KetNoi.Instance.excuteQuery(query);
                    string to1 = data.Rows[0][0].ToString();
                    string smtp1 = "smtp.gmail.com";
                    string from1 = "duykhanhlb4999@gmail.com";
                    string body1 = "cảm ơn bạn đã mua hàng";
                    string subject1 = "Cảm ơn khách hàng";
                    string username1 = "duykhanhlb4999@gmail.com";
                    string password1 = "nguyenngocduykhanh";
                    MailMessage mail = new MailMessage(from1, to1, subject1, body1);
                    mail.Attachments.Add(new Attachment(attachment1.Text));
                    SmtpClient client = new SmtpClient(smtp1);
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential(username1, password1);
                    client.EnableSsl = true;
                    client.Send(mail);
                    MessageBox.Show("Mail send", "success", MessageBoxButtons.OK);
                    string pass = "1";
                    //Form1 f = new Form1(pass);
                }
                catch
                {
                    MessageBox.Show(" Gửi không thành công ");
                }


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                string picPath = open.FileName.ToString();
                attachment1.Text = picPath;
            }
        }
    }
    }
   

