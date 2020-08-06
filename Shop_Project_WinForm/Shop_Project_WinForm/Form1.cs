using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Shop_Project_WinForm
{
    public partial class Form1 : Form
    {
        int id;
       
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           userHome1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            userNhanVien1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            userKhachHang1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            userSanPham1.BringToFront();
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           userDanhMucSP2.BringToFront();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            userPhieuNhap1.BringToFront();
            userPhieuNhap1.LoadNV();
            userPhieuNhap1.LoadNCC();
            
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            userNhaCungCap1.BringToFront();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userHoaDon1.form = this;
            if (id==2)
            {
                guna2Button4.Enabled = false;
                guna2Button6.Enabled = false;
                guna2Button12.Enabled = false;
                
            }
            
        }
        public int count = 2;
        private void guna2Button13_Click(object sender, EventArgs e)
        {
            userHoaDon1.form = this;
            userHoaDon1.BringToFront();
            userHoaDon1.LoadKh();
            userHoaDon1.LoadNV();
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 f = new Form3();
            f.FormClosed += closeForm;
            f.Show();
            f.BringToFront();
            
            
        }

        private void closeForm(object sender, FormClosedEventArgs e)
        {
            // throw new NotImplementedException();
            this.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string a = DateTime.Now.ToLongTimeString() + " ";
            label1.Text = a += DateTime.Now.ToLongDateString();
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HangTon f = new HangTon();
            f.FormClosed += closeForm;
            f.Show();
            f.BringToFront();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/duykhanh4999");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/#inbox");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int a = 1, x = 210, y = 60;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/duykhanh4999");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/#inbox");
        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            //this.Visible = false;
            //FormLogin f = new FormLogin();
            //f.FormClosed += closeForm;
            //f.Show();
            //f.BringToFront();
        }

        private void guna2Button8_Click_2(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin f = new FormLogin();
            f.FormClosed += closeForm;
            f.Show();
            f.BringToFront();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                title.Location = new Point(x, y);
                if (x >= 532)
                {
                    a = -1;
                }
                if (x <= 210)
                {
                    a = 1;
                }

            }
            catch { 

            }
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
