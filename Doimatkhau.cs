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
    public partial class Doimatkhau : Form
    {
        private string role;

        SqlConnection conn;
        public Doimatkhau(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void Doimatkhau_Load(object sender, EventArgs e)
        {
           
        }

        private void btnok_Click(object sender, EventArgs e)
        {
           
        }
    }
}
