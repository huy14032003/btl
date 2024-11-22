namespace QLSV
{
    partial class doimk
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_doi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_nlmk = new System.Windows.Forms.TextBox();
            this.txt_mkm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_mkc = new System.Windows.Forms.TextBox();
            this.txt_ttk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(431, 368);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Đóng";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_doi
            // 
            this.btn_doi.Location = new System.Drawing.Point(290, 368);
            this.btn_doi.Name = "btn_doi";
            this.btn_doi.Size = new System.Drawing.Size(75, 23);
            this.btn_doi.TabIndex = 8;
            this.btn_doi.Text = "Đổi";
            this.btn_doi.UseVisualStyleBackColor = true;
            this.btn_doi.Click += new System.EventHandler(this.btn_doi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_nlmk);
            this.groupBox3.Controls.Add(this.txt_mkm);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(431, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 119);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mật khẩu mới ";
            // 
            // txt_nlmk
            // 
            this.txt_nlmk.Location = new System.Drawing.Point(151, 69);
            this.txt_nlmk.Name = "txt_nlmk";
            this.txt_nlmk.Size = new System.Drawing.Size(100, 22);
            this.txt_nlmk.TabIndex = 5;
            // 
            // txt_mkm
            // 
            this.txt_mkm.Location = new System.Drawing.Point(151, 16);
            this.txt_mkm.Name = "txt_mkm";
            this.txt_mkm.Size = new System.Drawing.Size(100, 22);
            this.txt_mkm.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu mới";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_mkc);
            this.groupBox2.Controls.Add(this.txt_ttk);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 119);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản cũ";
            // 
            // txt_mkc
            // 
            this.txt_mkc.Location = new System.Drawing.Point(116, 69);
            this.txt_mkc.Name = "txt_mkc";
            this.txt_mkc.Size = new System.Drawing.Size(100, 22);
            this.txt_mkc.TabIndex = 3;
            // 
            // txt_ttk
            // 
            this.txt_ttk.Location = new System.Drawing.Point(116, 22);
            this.txt_ttk.Name = "txt_ttk";
            this.txt_ttk.Size = new System.Drawing.Size(100, 22);
            this.txt_ttk.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên tài khoản ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // doimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_doi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "doimk";
            this.Text = "doimk";
            this.Load += new System.EventHandler(this.doimk_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_doi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_nlmk;
        private System.Windows.Forms.TextBox txt_mkm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_mkc;
        private System.Windows.Forms.TextBox txt_ttk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}