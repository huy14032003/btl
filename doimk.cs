using btl;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV
{
    public partial class doimk : Form
    {
        public doimk()
        {
            InitializeComponent();
        }

        private void btn_doi_Click(object sender, EventArgs e)
        {
            string username = txt_ttk.Text.Trim(); // Tên tài khoản
            string currentPassword = txt_mkc.Text.Trim(); // Mật khẩu cũ
            string newPassword = txt_mkm.Text.Trim(); // Mật khẩu mới
            string confirmPassword = txt_nlmk.Text.Trim(); // Nhập lại mật khẩu mới

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản.", "Nhập liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txt_ttk.Focus();
                return;
            }

            if (string.IsNullOrEmpty(currentPassword))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ.", "Nhập liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txt_mkc.Focus();
                return;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới.", "Nhập liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txt_mkm.Focus();
                return;
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu mới.", "Nhập liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txt_nlmk.Focus();
                return;
            }

            // Kiểm tra mật khẩu mới và mật khẩu nhập lại có khớp không
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txt_nlmk.Clear();
                txt_nlmk.Focus();
                return;
            }

            try
            {
                using (SqlConnection mycon = Database.OpenConnection())
                {
                

                    // Danh sách các bảng cần kiểm tra
                    string[] tables = { "admin", "gv", "nguoidung", "truongkhoa" };
                    bool userFound = false;

                    foreach (string table in tables)
                    {
                        // Kiểm tra tài khoản và mật khẩu trong từng bảng
                        string checkUserQuery = $"SELECT COUNT(*) FROM {table} WHERE tk = @username AND mk = @currentPassword";
                        SqlCommand cmd = new SqlCommand(checkUserQuery, mycon);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@currentPassword", currentPassword);

                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                           
                            // Nếu tài khoản hợp lệ, tiến hành đổi mật khẩu
                            string updatePasswordQuery = $"UPDATE {table} SET mk = @newPassword WHERE tk = @username";
                            SqlCommand updateCmd = new SqlCommand(updatePasswordQuery, mycon);
                            updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                            updateCmd.Parameters.AddWithValue("@username", username);

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Bạn đã thay đổi mật khẩu thành công cho tài khoản trong bảng {table}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_ttk.Clear();
                                txt_mkc.Clear();
                                txt_mkm.Clear();
                                txt_nlmk.Clear();
                                userFound = true;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    if (!userFound)
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txt_mkc.Clear();
                        txt_mkc.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void doimk_Load(object sender, EventArgs e)
        {

        }
    }
}
