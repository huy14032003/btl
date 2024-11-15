using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl
{
    public partial class qlysv : Form
    {
        private string role; // Biến lưu vai trò người dùng

        public qlysv( string role )
        {
            InitializeComponent();
           
            this.role = role;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
       
        private void qlysv_Load(object sender, EventArgs e)
        {

            // Sử dụng Application.StartupPath để lấy đường dẫn tương đối
            string imagePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\Images\456.jpg");
            panel1.BackgroundImage = Image.FromFile(imagePath); // Đặt hình nền cho panel1
            panel1.BackgroundImageLayout = ImageLayout.Stretch;

            timer1.Interval = 1000; // Đặt khoảng thời gian là 1 giây
            timer1.Tick += timer1_Tick; // Gán sự kiện Tick cho Timer
            timer1.Start();



            switch (role)
            {
                case "admin":
                    ts_btnquanlytaikhoanadmin.Visible = true;
                    ts_qlytaikhoantruongkhoa.Visible = true;
                    ts_qlytaikhoangiaovien.Visible = true;
                    ts_qlytaikhoanuser.Visible = true;
                    break;

                case "truongkhoa":
                    ts_btnquanlytaikhoanadmin.Visible = false;
                    ts_qlytaikhoantruongkhoa.Visible = false; // Trưởng khoa có quyền quản lý tài khoản của trưởng khoa
                    ts_qlytaikhoangiaovien.Visible = true; // Trưởng khoa có quyền quản lý tài khoản giáo viên
                    ts_qlytaikhoanuser.Visible = true; // Trưởng khoa có quyền quản lý tài khoản người dùng
                    break;

                case "giaovien":
                    ts_btnquanlytaikhoanadmin.Visible = false;
                    ts_qlytaikhoantruongkhoa.Visible = false;
                    ts_qlytaikhoangiaovien.Visible = false;
                    ts_qlytaikhoanuser.Visible = true; // Giáo viên chỉ có quyền quản lý tài khoản người dùng
                    break;

                case "user":
                    ts_btnquanlytaikhoanadmin.Visible = false;
                    ts_qlytaikhoantruongkhoa.Visible = false;
                    ts_qlytaikhoangiaovien.Visible = false;
                    ts_qlytaikhoanuser.Visible = false; // Người dùng không có quyền quản lý tài khoản
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void ts_btnquanlytaikhoanadmin_Click(object sender, EventArgs e)
        {
            if (role == "admin")
            {
                qltaikhoan f = new qltaikhoan(role);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào mục này.");
            }

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login f=new login();
            this.Hide();
            f.ShowDialog(); 
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f=new login();
            f.ShowDialog();
            this.Show();
        }

        private void ts_qlytaikhoangiaovien_Click(object sender, EventArgs e)
        {
            if (role == "admin" || role == "truongkhoa")
            {
                qltaikhoan f = new qltaikhoan(role);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào mục này.");
            }
        }

        private void ts_qlytaikhoantruongkhoa_Click(object sender, EventArgs e)
        {
            if (role == "admin")
            {
                qltaikhoan f = new qltaikhoan(role);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào mục này.");
            }

        }

        private void ts_qlytaikhoanuser_Click(object sender, EventArgs e)
        {
            if (role == "admin" || role == "truongkhoa" || role == "giaovien")
            {
                qltaikhoan f = new qltaikhoan(role);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào mục này.");
            }
        }

        private void ts_khoa_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item != ts_thoat) // Nếu không phải "ts_thoat"
                {
                    item.Enabled = false; // Vô hiệu hóa item
                }
            }
        }

        private void ngônNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        
            private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5; 
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        { 
            this.Opacity = 1; 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Left += 10;

            // Kiểm tra nếu label2 đã chạy hết màn hình bên trái
            if (label2.Right > this.Width)
            {
                // Đặt lại label2 ở phía bên phải của form
                label2.Left = -label2.Width;
            }
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("khoa","View");
          
            thongTinForm.ShowDialog();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("giaovien", "View");

            thongTinForm.ShowDialog();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("lop", "View");

            thongTinForm.ShowDialog();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("sinhvien", "View");

            thongTinForm.ShowDialog();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("monhoc", "View");

            thongTinForm.ShowDialog();
        }

        private void chínhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("chinhsach", "View");

            thongTinForm.ShowDialog();
        }

        private void khoaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("khoa", "edit");

            thongTinForm.ShowDialog();
           
        }

        private void giáoViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("giaovien", "edit");

            thongTinForm.ShowDialog();
        }

        private void lớpToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            thongtin thongTinForm = new thongtin("lop", "edit");

            thongTinForm.ShowDialog();
        }

        private void sinhViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("sinhvien", "edit");

            thongTinForm.ShowDialog();
        }

        private void mộnHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("monhoc", "edit");

            thongTinForm.ShowDialog();
        }

        private void chínhSáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            thongtin thongTinForm = new thongtin("chinhsach", "edit");

            thongTinForm.ShowDialog();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
