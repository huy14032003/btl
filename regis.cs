using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace btl
{
    public partial class regis : Form
    {
        public regis()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string user=txtuser.Text;
            string pass=txtpass.Text;
            string cfpass=txtconfirmpass.Text;
            if (pass != cfpass)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(user=="" ||pass==""&&cfpass=="" )
            {
                MessageBox.Show("chua nhập đủ");
            }
            else
            {
                if (ktra(user, pass))
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form đăng ký
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Gọi phương thức đăng ký
           

        }
        public bool ktra(string username, string password)
        {
            using(SqlConnection conn = Database.OpenConnection())
            {
                if (conn == null)
                    return false; // Không thể kết nối
                string query = "SELECT COUNT(*) FROM [users] WHERE tk = @username ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                int userExists = (int)cmd.ExecuteScalar();

                if (userExists > 0)
                {
                    return false; // Tên đăng nhập đã tồn tại
                }
                string registerQuery = "INSERT INTO [users] (tk, mk) VALUES (@username, @password)";
                SqlCommand registerCmd = new SqlCommand(registerQuery, conn);
                registerCmd.Parameters.AddWithValue("@username", username);
                registerCmd.Parameters.AddWithValue("@password", password);

                // Thực thi câu lệnh thêm
                registerCmd.ExecuteNonQuery();
            }
            return true;
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Nếu nhấn phím Enter
            {
                txtpass.Focus(); // Chuyển đến txtPass
                e.Handled = true; // Ngăn chặn âm thanh "ding"
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Nếu nhấn phím Enter
            {
                txtconfirmpass.Focus(); // Chuyển đến txtPass
                e.Handled = true; // Ngăn chặn âm thanh "ding"
            }
        }

        private void txtconfirmpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Nếu nhấn phím Enter
            {
                btnok.PerformClick(); // Chuyển đến txtPass
                e.Handled = true; // Ngăn chặn âm thanh "ding"
            }
        }

        private void regis_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
