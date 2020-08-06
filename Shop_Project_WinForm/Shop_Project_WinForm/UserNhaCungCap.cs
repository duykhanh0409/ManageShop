using System;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using System.Web;

namespace Shop_Project_WinForm
{
    public partial class UserNhaCungCap : UserControl
    {
        int i;
        public UserNhaCungCap()
        {
            InitializeComponent();
            loadDl();
            txmncc.Enabled = false;
            txsdt.Enabled = false;
            txdiachi.Enabled = false;
            txtenncc.Enabled = false;
            txgmail.Enabled = false;
            txmncc.Enabled = true;
            txsdt.Enabled = true;
            txdiachi.Enabled = true;
            txtenncc.Enabled = true;
            txgmail.Enabled = true;
            
        }
        public void loadDl()
        {
            string query = "select *from NhaCungCap";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            dgt1.DataSource = data;
        }
        public bool kiemtra(string MaNV)
        {
            string query = "select *from NhaCungCap where MaNCC='" + txmncc.Text + "'";
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
            txmncc.Text = "";
            txtenncc.Text = "";
            txdiachi.Text = "";
            txsdt.Text = "";
            txgmail.Text = "";
           

        }
        private void gunaButton10_Click(object sender, EventArgs e)
        {
            //int i = 1;
          
            txmncc.Enabled = true;
            txsdt.Enabled = true;
            txdiachi.Enabled = true;
            txtenncc.Enabled = true;
            txgmail.Enabled = true;
            setnull();



        }




        private void dgt1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int row = e.RowIndex;
            if (row< 0)
            {
                return;
            }
            else
            {
                txmncc.Text = dgt1.Rows[row].Cells[0].Value.ToString();
                txtenncc.Text = dgt1.Rows[row].Cells[1].Value.ToString();
                txdiachi.Text = dgt1.Rows[row].Cells[2].Value.ToString();
                txsdt.Text = dgt1.Rows[row].Cells[3].Value.ToString();
                txgmail.Text = dgt1.Rows[row].Cells[4].Value.ToString();






            }
    }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            txmncc.Enabled = false;
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            if (txmncc.Text == "" || txtenncc.Text == "")
            {
                MessageBox.Show(" vui lòng chọn dòng cần xóa");
            }
            try
            {
                string query = "delete NhaCungCap where MaNCC='" + txmncc.Text + "' ";
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
            if (txmncc.Enabled)
            {
                if (txmncc.Text == "" || txtenncc.Text == "" || txsdt.Text == "" || txdiachi.Text == "")
                {
                    MessageBox.Show("vui long nhap du thong tin");
                }
                else
                {
                    if (kiemtra(txmncc.Text) == true)
                    {
                        MessageBox.Show("ma da ton tai");
                        return;
                    }
                    try
                    {
                        string query = "insert into NhaCungCap values (N'" + txmncc.Text + "',N'" + txtenncc.Text + "',N'" + txdiachi.Text + "','" + txsdt.Text + "','" + txgmail.Text + "')";
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
                if (txtenncc.Text == "" || txsdt.Text == "" || txdiachi.Text == "")
                {
                    MessageBox.Show("vui long nhap du thong tin");
                }
                else
                {

                    try
                    {
                        string query = "update NhaCungCap set TenNhaCC= N'" + txtenncc.Text + "',ĐiaChiNCC=N'" + txdiachi.Text + "',SDTNCC='" + txsdt.Text + "',GmailNCC='" + txgmail.Text + "' where MaNCC='" + txmncc.Text + "'";
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

        private void txsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void UserNhaCungCap_Load(object sender, EventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txmncc.Text == "")
            {
                MessageBox.Show(" Chọn thông tin nhé.");
            }
            else
            {
                try
                {
                    string query = "select GmailNCC from NhaCungCap where MaNCC=N'" + txmncc.Text + "'";


                    DataTable data = KetNoi.Instance.excuteQuery(query);
                    string to1 = data.Rows[0][0].ToString();
                    string smtp1 = "smtp.gmail.com";
                    string from1 = "duykhanhlb4999@gmail.com";
                    string body1 = "Thông Tin Hàng Hóa Cần Đặt";
                    string subject1 = "Chúc bạn một ngày may mắn";
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
    }
    }

