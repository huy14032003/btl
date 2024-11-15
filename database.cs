using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl
{
    internal class Database
    {
        private static string connectionString = "Data Source=DESKTOP-ITKOE36;Initial Catalog=qlysinhvien;Integrated Security=True;";
        private static SqlConnection conn;
        public static SqlConnection OpenConnection()
        {
            conn = new SqlConnection(connectionString); // Khởi tạo biến conn
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi mở kết nối: " + ex.Message);
                conn = null;
            }
            return conn;
        }

        public static void CloseConnection()
        {
            if (conn != null)
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
                conn.Dispose();
            }
        }
    }
}
