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
    public partial class btnexit : Form
    {
        public btnexit()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

           login f= new login();
            this.Hide();
            f.ShowDialog();
            this.Close();
          
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            regis f=new regis();
            this.Hide(); 
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btninfor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hrloo","thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Left += 5;

            // Kiểm tra nếu label2 đã chạy hết màn hình bên trái
            if (label2.Right > this.Width)
            {
                // Đặt lại label2 ở phía bên phải của form
                label2.Left = -label2.Width;
            }
        }
    }
}
