using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Project_WinForm
{
    public partial class UserSanPham : UserControl
    {
        public UserSanPham()
        {
            InitializeComponent();
            LoatDL();
            LoadNhom();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public void LoadNhom()
        {
            string query = "select*from nhomsanpham";
            DataTable nhomsp = KetNoi.Instance.excuteQuery(query);
            cbNhom.DataSource = nhomsp;
            cbNhom.ValueMember = "MaNhom";
            cbNhom.DisplayMember = "TenNhom";
        }

        public void LoatDL()
        {
            string query = "select * from sanpham sp, nhomsanpham nsp where sp.manhom = nsp.manhom";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            dtg1.AutoGenerateColumns = false;
            dtg1.DataSource = data;


        }
        public bool kiemtra(string MaSP)
        {
            string query = "select *from sanpham where masp='" + MaSP + "'";
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
        private string fileImage = "";

        private void UserSanPham_Load(object sender, EventArgs e)
        {
            
        }

        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txmsp.Text = dtg1.CurrentRow.Cells[0].Value.ToString();
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            else
            {
                // txmsp.Text = dtg1.Rows[row].Cells[0].Value.ToString();
                txtensp.Text = dtg1.Rows[row].Cells[1].Value.ToString();
                cbNhom.Text = dtg1.Rows[row].Cells[2].Value.ToString();
                string image = dtg1.Rows[row].Cells[3].Value.ToString();
                if (image != "")
                {
                    Image image1 = new Bitmap(@image);
                   // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BackgroundImage = image1;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    fileImage = image;
                   
                }
                else
                {
                    pictureBox1.BackgroundImage = null;
                    fileImage = "";
                }

                int column = e.ColumnIndex;
                if (column == 4)
                {
                   chitietsanpham ct = new chitietsanpham (txmsp.Text);
                    ct.ShowDialog();
                }
                //txmausac.Text = dtg1.Rows[row].Cells[4].Value.ToString();
                //txkichthuoc.Text = dtg1.Rows[row].Cells[5].Value.ToString();
                //txslt.Text = dtg1.Rows[row].Cells[6].Value.ToString();




            }
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            txmsp.Enabled = true;
            setnull();
           
        }
        void setnull()
        {
            txmsp.Text = "";
            txtensp.Text = "";
            cbNhom.Text = "";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                OpenFileDialog dialog = new OpenFileDialog();
                if (DialogResult.OK == dialog.ShowDialog())
                {
                    dialog.Filter = "insert image (*)|*";
                    fileImage = dialog.FileName;
                    Image image = new Bitmap(fileImage);
                    pictureBox1.BackgroundImage = image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            txmsp.Enabled = false;
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            if (txmsp.Text == "")
            {
                MessageBox.Show(" vui long chon dong can xoa");
            }
            else
            {
                try
                {
                    string query = "delete SanPham where MaSP='" + txmsp.Text + "'";
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

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //if (DialogResult.OK == dialog.ShowDialog())
            //{
            //    dialog.Filter = "insert image (*)|*";
            //    fileImage = dialog.FileName;
            //    Image image = new Bitmap(fileImage);
            //    pictureBox1.BackgroundImage = image;
            //}

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            //if (txtensp.Text == "")
            //{
            //    MessageBox.Show(" Nhập Tên Sản Phẩm Cần tìm");

            //}
            //else
            //{
            //    try
            //    {
            //        string query = " Select* from CTSP where MaSP='" + txmsp.Text + "'and TenSP like N'%"+txtensp.Text+ "'";
            //        DataTable data = KetNoi.Instance.excuteQuery(query);
            //        LoatDL();
            //    }
            //    catch
            //    {

            //    }
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //if (txtensp.Text == "")
            //{
            //    MessageBox.Show(" Nhập Tên Sản Phẩm Cần tìm");

            //}
          //  else
           // {
                try
                {
                    string query = " Select* from CTSP where MaSP='" + txmsp.Text + "'and TenSP like N'%" + txtensp.Text + "'";
                    DataTable data = KetNoi.Instance.excuteQuery(query);
                    LoatDL();
                }
                catch
                {

                }
          //  }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txmsp.Enabled)
            {


                if (txmsp.Text == "" || txtensp.Text == "" || cbNhom.SelectedIndex == -1)
                {
                    MessageBox.Show("vui long nhap du thong tin");
                    return;
                }

                if (kiemtra(txmsp.Text) == true)
                {
                    MessageBox.Show("ma da ton tai");
                    return;
                }
                string query = "insert into sanpham values('" + txmsp.Text + "','" + txtensp.Text + "','" + cbNhom.SelectedValue.ToString() + "','" + fileImage + "')";
                DataTable data = KetNoi.Instance.excuteQuery(query);
                MessageBox.Show("Them thanh cong");
                LoatDL();
            }
            else
            {
                if (txtensp.Text == "" || txtensp.Text == "" || cbNhom.Text == "")
                {
                    MessageBox.Show("vui long nhap du thong tin");
                }
                else
                {


                    try
                    {
                        string query = "update SanPham set TenSP= N'" + txtensp.Text + "',MaNhom=N'" + cbNhom.SelectedValue.ToString() + "',HinhSP='" + fileImage + "' where MaSP='" + txmsp.Text + "'";
                        DataTable data = KetNoi.Instance.excuteQuery(query);
                        MessageBox.Show("Sua thanh cong");
                        LoatDL();
                    }
                    catch
                    {
                        MessageBox.Show("Sua that bai");
                    }
                }
            }
        }

        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                dialog.Filter = "insert image (*)|*";
                fileImage = dialog.FileName;
                Image image = new Bitmap(fileImage);
              
                pictureBox1.BackgroundImage = image;
            
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
      
        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }
        public void seachData(string valuaToFind)
        {
            string query = " select *from SanPham sp, NhomSanPham nsp where sp.MaNhom=nsp.MaNhom and  CONCAT (sp.MaSP,sp.TenSP ,nsp.TenNhom) like '%" + valuaToFind + "%'";
            DataTable data = KetNoi.Instance.excuteQuery(query);
            dtg1.DataSource = data;
            
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            seachData(txttim.Text);
        }

        private void cbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        //public void loadKichThuoc(string masp)
        //{
        //    cbKichThuoc.ResetText();
        //    string query = "select MaSP,kichthuoc from CTSP ctsp where masp = '"+masp+"'";
        //    DataTable data = KetNoi.Instance.excuteQuery(query);
        //    cbKichThuoc.ValueMember = "MaSP";
        //    cbKichThuoc.DisplayMember = "kichthuoc";
        //    cbKichThuoc.DataSource = data;
        //}
        //public void loadMauSac(string msp)
        //{
        //    cbMauSac.ResetText();
        //    string query = "select MaSP,mausac from CTSP ctsp where masp = '" + masp + "'";
        //    DataTable data = KetNoi.Instance.excuteQuery(query);
        //    cbMauSac.ValueMember = "MaSP";
        //    cbMauSac.DisplayMember = "mausac";
        //    cbMauSac.DataSource = data;
        //}
        //private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string masp = dtg1.CurrentRow.Cells["MaSP"].Value.ToString();
        //    txmsp.Text = masp;
        //    txtensp.Text = dtg1.CurrentRow.Cells["TenSP"].Value.ToString();
        //    txtMaNhom.Text = dtg1.CurrentRow.Cells["manhom"].Value.ToString();
        //    loadKichThuoc(masp);
        //    loadMauSac(masp);
        //}
    }
}
