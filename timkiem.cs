using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl
{
    public partial class timkiem : Form
    {
        private string table;
        public timkiem(string table)
        {
            InitializeComponent();
            this.table = table; 
        }

        private void timkiem_Load(object sender, EventArgs e)
        {
            switch (table)
            {
                case "khoa":
                    label1.Text = "Tìm Kiếm Khoa";

                    break;

                case "giaovien":
                    label1.Text = "Tìm Kiếm Giáo Viên";
                    break;

                case "sinhvien":
                    label1.Text = "Tìm Kiếm Sinh Viên";
                    break;

                case "chinhsach":
                    label1.Text = "Tìm Kiếm Chính Sách";
                    break;

                case "monhoc":
                    label1.Text = "Tìm Kiếm Môn Học";
                    break;

                case "lop":
                    label1.Text = "Tìm Kiếm Lớp";

                    break;

                default:
                    label1.Text = "Tìm kiếm";

                    break;
            }
            load(table);
            combo(table);

        }
       
        public void load(string table)
        {

            using (SqlConnection con = Database.OpenConnection())
            {
                string sql = $"select*from {table}";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void combo(string table)
        {
            using (SqlConnection con = Database.OpenConnection())
            {
                try
                {
                    // Câu truy vấn lấy thông tin cột
                    string sql = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}'";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Tạo ánh xạ giữa tên cột và nhãn hiển thị
                    Dictionary<string, string> columnDisplayNames = new Dictionary<string, string>()
            {
                { "magv", "Mã Giáo Viên" },
                { "tengv", "Tên Giáo Viên" },
                { "ngaysinh", "Ngày Sinh" },
                { "gioitinh", "Giới Tính" },
                { "sdt", "Số Điện Thoại" },
                { "diachi", "Địa Chỉ" },
                { "masv", "Mã Sinh Viên" },
                { "tensv", "Tên Sinh Viên" },
                { "macs", "Mã Chính Sách" },
                { "malop", "Mã Lớp" },
                { "tenlop", "Tên Lớp" },
                { "makhoa", "Mã Khoa" },
                { "tenkhoa", "Tên Khoa" },
                { "tencs", "Tên Chính Sách" },
                { "chedo", "Chế độ" },
                { "mamh", "Mã Môn Học" },
                { "tenmh", "Tên Môn Học" },
                { "sotiet", "Số Tiết" },
               


                // Thêm ánh xạ khác nếu cần
            };

                    // Xóa dữ liệu cũ trong ComboBox
                    cb1.Items.Clear();

                    // Thêm tên cột (hoặc nhãn hiển thị) vào ComboBox
                    while (reader.Read())
                    {
                        string columnName = reader["COLUMN_NAME"].ToString();

                        // Kiểm tra xem tên cột có trong ánh xạ không
                        if (columnDisplayNames.ContainsKey(columnName))
                        {
                            cb1.Items.Add(columnDisplayNames[columnName]); // Thêm nhãn hiển thị
                        }
                        else
                        {
                            cb1.Items.Add(columnName); // Nếu không có ánh xạ, thêm tên cột gốc
                        }
                    }

                    reader.Close();

                    // Đặt mục đầu tiên làm mặc định (nếu có dữ liệu)
                    if (cb1.Items.Count > 0)
                    {
                        cb1.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void search()
        {
            string keyword = txt1.Text.Trim(); // Lấy từ khóa tìm kiếm từ TextBox
            string selectedField = cb1.SelectedItem?.ToString(); // Lấy trường được chọn từ ComboBox

            if (string.IsNullOrEmpty(keyword) || string.IsNullOrEmpty(selectedField))
            {
                MessageBox.Show("Vui lòng nhập từ khóa và chọn trường tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ánh xạ tên hiển thị về tên cột gốc trong bảng
            Dictionary<string, string> columnMappings = new Dictionary<string, string>()
    {
        { "Mã Giáo Viên", "magv" },
        { "Tên Giáo Viên", "tengv" },
        { "Ngày Sinh", "ngaysinh" },
        { "Giới Tính", "gioitinh" },
        { "Số Điện Thoại", "sdt" },
        { "Địa Chỉ", "diachi" },
        { "Mã Sinh Viên", "masv" },
        { "Tên Sinh Viên", "tensv" },
        { "Mã Chính Sách", "macs" },
        { "Mã Lớp", "malop" },
        { "Tên Lớp", "tenlop" },
        { "Mã Khoa", "makhoa" },
        { "Tên Khoa", "tenkhoa" },
        { "Tên Chính Sách", "tencs" },
        { "Chế độ", "chedo" },
        { "Mã Môn Học", "mamh" },
        { "Tên Môn Học", "tenmh" },
        { "Số Tiết", "sotiet" },
    };

            // Lấy tên cột gốc tương ứng với nhãn hiển thị
            if (!columnMappings.TryGetValue(selectedField, out string columnName))
            {
                MessageBox.Show("Trường tìm kiếm không hợp lệ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = Database.OpenConnection())
            {
                try
                {
                    // Câu truy vấn tìm kiếm
                    string sql = $"SELECT * FROM {table} WHERE {columnName} LIKE @keyword";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    // Gán dữ liệu tìm kiếm lên GridView
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
