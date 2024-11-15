namespace btl
{
    partial class qltaikhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmatkhau);
            this.groupBox1.Controls.Add(this.txttaikhoan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(38, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(111, 366);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(228, 366);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(349, 366);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.Location = new System.Drawing.Point(161, 415);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnnhaplai.TabIndex = 3;
            this.btnnhaplai.Text = "Nhập lại";
            this.btnnhaplai.UseVisualStyleBackColor = true;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(292, 415);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 3;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(174, 64);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(100, 22);
            this.txttaikhoan.TabIndex = 1;
            this.txttaikhoan.TextChanged += new System.EventHandler(this.txttaikhoan_TextChanged);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(174, 110);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(100, 22);
            this.txtmatkhau.TabIndex = 1;
            this.txtmatkhau.TextChanged += new System.EventHandler(this.txtmatkhau_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tk,
            this.mk});
            this.dataGridView1.Location = new System.Drawing.Point(494, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(294, 191);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tk
            // 
            this.tk.DataPropertyName = "tk";
            this.tk.HeaderText = "Tài Khoản";
            this.tk.MinimumWidth = 6;
            this.tk.Name = "tk";
            this.tk.Width = 125;
            // 
            // mk
            // 
            this.mk.DataPropertyName = "mk";
            this.mk.HeaderText = "Mật Khẩu";
            this.mk.MinimumWidth = 6;
            this.mk.Name = "mk";
            this.mk.Width = 125;
            // 
            // qltaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnnhaplai);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "qltaikhoan";
            this.Text = "qltaikhoan";
            this.Load += new System.EventHandler(this.qltaikhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnnhaplai;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk;
        private System.Windows.Forms.DataGridViewTextBoxColumn mk;
    }
}