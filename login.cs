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

namespace btl
{
    public partial class login : Form
    {
        private int attemptCount = 0;
        public login()
        {
            InitializeComponent();
            txtuser.Focus();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Chưa nhập thông tin đăng nhập!");
                return;
            }

            var (isValid, role) = ktra(username, password);
            if (isValid)
            {
                MessageBox.Show("Đăng nhập thành công!");
                attemptCount = 0;

                if (role == "admin")
                {
                    qlysv f = new qlysv(role); // Form quản lý tài khoản cho admin
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (role == "user")
                {
                    qlysv f = new qlysv(role); // Form quản lý tài khoản cho admin
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (role == "truongkhoa")
                {
                    qlysv f = new qlysv(role); // Form quản lý tài khoản cho admin
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (role == "giaovien")
                {
                    qlysv f = new qlysv(role); // Form quản lý tài khoản cho admin
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                attemptCount++;
                if (attemptCount >= 3)
                {
                    MessageBox.Show("Bạn đã nhập sai quá 3 lần! Vui lòng thử lại sau.");
                    btnok.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Lần thử " + attemptCount + "/3.");
                }
            }

        }
        public (bool, string) ktra(string username, string password)
        {
            using (SqlConnection conn = Database.OpenConnection())
            {
                if (conn == null)
                    return (false, null); // Không thể kết nối

                // Kiểm tra bảng admin
                string queryAdmin = "SELECT COUNT(*) FROM [admin] WHERE tk = @username AND mk = @password";
                SqlCommand cmdAdmin = new SqlCommand(queryAdmin, conn);
                cmdAdmin.Parameters.AddWithValue("@username", username);
                cmdAdmin.Parameters.AddWithValue("@password", password);
                if ((int)cmdAdmin.ExecuteScalar() > 0)
                    return (true, "admin");


                //trưởng khoa
                string querytk = "SELECT COUNT(*) FROM [truongkhoa] WHERE tk = @username AND mk = @password";
                SqlCommand cmdtk = new SqlCommand(querytk, conn);
                cmdtk.Parameters.AddWithValue("@username", username);
                cmdtk.Parameters.AddWithValue("@password", password);
                if ((int)cmdtk.ExecuteScalar() > 0)
                    return (true, "truongkhoa");

         


                // Kiểm tra bảng users
                string queryUser = "SELECT COUNT(*) FROM [users] WHERE tk = @username AND mk = @password";
                SqlCommand cmdUser = new SqlCommand(queryUser, conn);
                cmdUser.Parameters.AddWithValue("@username", username);
                cmdUser.Parameters.AddWithValue("@password", password);
                if ((int)cmdUser.ExecuteScalar() > 0)
                    return (true, "user");

                // Kiểm tra bảng gv
                string queryGV = "SELECT COUNT(*) FROM [gv] WHERE tk = @username AND mk = @password";
                SqlCommand cmdGV = new SqlCommand(queryGV, conn);
                cmdGV.Parameters.AddWithValue("@username", username);
                cmdGV.Parameters.AddWithValue("@password", password);
                if ((int)cmdGV.ExecuteScalar() > 0)
                    return (true, "giaovien");

                return (false, null); // Không khớp với bảng nào


            
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

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
                btnok.PerformClick(); // Chuyển đến txtPass
                e.Handled = true; // Ngăn chặn âm thanh "ding"
            }
        }

        private void btncanel_Click(object sender, EventArgs e)
        {
            btnexit f=new btnexit();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
