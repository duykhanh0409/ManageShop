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
    public partial class bieudo : Form
    {
        private string query;
        public bieudo(string queRy)
        {
            this.query = queRy;
            InitializeComponent();
            loadBieuDo();
        }

        public string Query { get => query; set => query = value; }
        void loadBieuDo()
        {
            DataTable data = KetNoi.Instance.excuteQuery(Query);
            foreach(DataRow row in data.Rows)
            {
                chart1.Series["Doanh Thu"].Points.AddXY(row["ngaylap"], decimal.Parse(row["tongtien"].ToString()));
            }
        }
        private void chart1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
