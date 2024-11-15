namespace btl
{
    partial class btnexit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregis = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btninfor = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // btnregis
            // 
            this.btnregis.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregis.Location = new System.Drawing.Point(184, 235);
            this.btnregis.Name = "btnregis";
            this.btnregis.Size = new System.Drawing.Size(141, 40);
            this.btnregis.TabIndex = 1;
            this.btnregis.Text = "Đăng Ký";
            this.btnregis.UseVisualStyleBackColor = true;
            this.btnregis.Click += new System.EventHandler(this.btnregis_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(184, 153);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(141, 40);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "Đăng Nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btninfor
            // 
            this.btninfor.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninfor.Location = new System.Drawing.Point(597, 153);
            this.btninfor.Name = "btninfor";
            this.btninfor.Size = new System.Drawing.Size(141, 40);
            this.btninfor.TabIndex = 1;
            this.btninfor.Text = "Thông Tin";
            this.btninfor.UseVisualStyleBackColor = true;
            this.btninfor.Click += new System.EventHandler(this.btninfor_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(597, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 40);
            this.button4.TabIndex = 1;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trường Đại Học Quốc Tế";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnexit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btninfor);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnregis);
            this.Controls.Add(this.label1);
            this.Name = "btnexit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregis;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btninfor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

