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
    public partial class qltaikhoan : Form
    {
        private string role;
      
        SqlConnection conn;
        public qltaikhoan(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void qltaikhoan_Load(object sender, EventArgs e)
        {

            switch (role)
            {
                case "admin":label1.Text= "QUẢN LÝ TÀI KHOẢN ADMIN"; break;
                    case "user":label1.Text= "QUẢN LÝ TÀI KHOẢN USER"; break;
                    case "giaovien":label1.Text= "QUẢN LÝ TÀI KHOẢN GIÁO VIÊN"; break;
                    case "truongkhoa":label1.Text= "QUẢN LÝ TÀI KHOẢN GIÁO VIÊN"; break;
                   

            }
            load();
        }
        public void load()
        {
            string query = "";
            switch (role)
            {
                case "admin":
                    query = "SELECT * FROM admin UNION SELECT * FROM users UNION SELECT * FROM gv UNION SELECT * FROM truongkhoa";
                    break;
                case "truongkhoa":
                    query = "SELECT * FROM gv UNION SELECT * FROM users";
                    break;
                case "giaovien":
                    query = "SELECT * FROM users";
                    break;
                case "user":
                    query = "SELECT * FROM users";
                    break;

               
            }
            using (SqlConnection conn = Database.OpenConnection())
            {
                if (conn == null) return;
                SqlDataAdapter da=new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }    
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị vào các TextBox
                txttaikhoan.Text = selectedRow.Cells["tk"].Value.ToString(); // Cột "tk" (tài khoản)
                txtmatkhau.Text = selectedRow.Cells["mk"].Value.ToString(); // Cột "mk" (mật khẩu)
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (role)
            {
                case "admin":
                    query = "INSERT INTO admin (tk, mk) VALUES (@tk, @mk)";
                    break;
                case "user":
                    query = "INSERT INTO users (tk, mk) VALUES (@tk, @mk)";
                    break;
                case "giaovien":
                    query = "INSERT INTO gv (tk, mk) VALUES (@tk, @mk)";
                    break;
                case "truongkhoa":
                    query = "INSERT INTO truongkhoa (tk, mk) VALUES (@tk, @mk)";
                    break;
                
            }

            if (!string.IsNullOrEmpty(query))
            {
                using (SqlConnection conn = Database.OpenConnection())
                {
                    if (conn == null) return;

                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@tk", txttaikhoan.Text);
                        cmd.Parameters.AddWithValue("@mk", txtmatkhau.Text);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Thêm tài khoản thành công!");
                            load(); // Cập nhật lại danh sách sau khi thêm
                        }
                        else
                        {
                            MessageBox.Show("Thêm tài khoản thất bại.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vai trò không hợp lệ, không thể thêm tài khoản.");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (role)
            {
                case "admin":
                    query = "UPDATE admin SET mk = @mk WHERE tk = @tk";
                    break;
                case "user":
                    query = "UPDATE users SET mk = @mk WHERE tk = @tk";
                    break;
                case "giaovien":
                    query = "UPDATE gv SET mk = @mk WHERE tk = @tk";
                    break;
                case "truongkhoa":
                    query = "UPDATE gv SET mk = @mk WHERE tk = @tk";
                    break;

            }

            if (!string.IsNullOrEmpty(query))
            {
                using (SqlConnection conn = Database.OpenConnection())
                {

                    if (conn == null) return;
                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@tk", txttaikhoan.Text.Trim());
                        cmd.Parameters.AddWithValue("@mk", txtmatkhau.Text.Trim());
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật tài khoản thành công!");
                            load(); // Cập nhật lại danh sách sau khi cập nhật
                        }
                        else
                        
                            MessageBox.Show("Cập nhật tài khoản thất bại hoặc tài khoản không tồn tại.");
                     }


                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                    }
                
         
                

                }
             

            }

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtmatkhau.Text = "";
            txttaikhoan.Text = "";
            txtmatkhau.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string query = "";
            switch (role)
            {
                case "admin":
                    query = "DELETE FROM admin WHERE tk = @tk;";
                    break;
                case "user":
                    query = "DELETE FROM users WHERE tk = @tk;";
                    break;
                case "giaovien":
                    query = "DELETE FROM gv WHERE tk = @tk;";
                    break;
                case "truongkhoa":
                    query = "DELETE FROM truongkhoa WHERE tk = @tk;";
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                using (SqlConnection conn = Database.OpenConnection())
                {
                    if (conn == null) return;

                    try
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@tk", txttaikhoan.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa tài khoản thành công!");
                            load(); // Cập nhật lại danh sách sau khi xóa
                        }
                        else
                        {
                            MessageBox.Show("Xóa tài khoản thất bại hoặc tài khoản không tồn tại.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                    }
                }
            }
        }
    }
}
