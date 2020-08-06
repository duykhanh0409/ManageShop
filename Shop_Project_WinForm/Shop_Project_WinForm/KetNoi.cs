using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Shop_Project_WinForm
{
 public class KetNoi
    {
        private static KetNoi instace;
        private string  conStr= @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLCHQA;Integrated Security=True";
        public static KetNoi Instance
        {
            get
            {
                if (instace == null)
                    instace = new KetNoi();
                return KetNoi.instace;
            }
            private set
            {
                KetNoi.instace = value;
            }
        }
        public DataTable excuteQuery(string query)
        {
            DataTable data = new DataTable();
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            SqlCommand command = new SqlCommand(query,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            conn.Close();
            return data;
          
        }

    }
}
