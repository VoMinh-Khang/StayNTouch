namespace QLKhachSan
{
    partial class DangKy
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelDangKy = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.textBoxTenDangNhap = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.buttonDangKy = new System.Windows.Forms.Button();
            this.textBoxHoChieu = new System.Windows.Forms.TextBox();
            this.labelHoChieu = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxHoVaTen = new System.Windows.Forms.TextBox();
            this.labelHoVaTen = new System.Windows.Forms.Label();
            this.textBoxCMND = new System.Windows.Forms.TextBox();
            this.labelCMND = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.labelSDT = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.groupBox.Controls.Add(this.labelDangKy);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox.Location = new System.Drawing.Point(0, -10);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1425, 160);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // labelDangKy
            // 
            this.labelDangKy.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDangKy.Location = new System.Drawing.Point(610, 50);
            this.labelDangKy.Name = "labelDangKy";
            this.labelDangKy.Size = new System.Drawing.Size(250, 50);
            this.labelDangKy.TabIndex = 0;
            this.labelDangKy.Text = "ĐĂNG KÝ";
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonHuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(820, 830);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(200, 70);
            this.buttonHuy.TabIndex = 13;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // labelTenDangNhap
            // 
            this.labelTenDangNhap.AutoSize = true;
            this.labelTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenDangNhap.Location = new System.Drawing.Point(820, 500);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(226, 41);
            this.labelTenDangNhap.TabIndex = 14;
            this.labelTenDangNhap.Text = "Tên đăng nhập";
            // 
            // textBoxTenDangNhap
            // 
            this.textBoxTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenDangNhap.Location = new System.Drawing.Point(820, 555);
            this.textBoxTenDangNhap.Multiline = true;
            this.textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            this.textBoxTenDangNhap.Size = new System.Drawing.Size(500, 50);
            this.textBoxTenDangNhap.TabIndex = 15;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMatKhau.Location = new System.Drawing.Point(820, 660);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(152, 41);
            this.labelMatKhau.TabIndex = 16;
            this.labelMatKhau.Text = "Mật khẩu";
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(820, 715);
            this.textBoxMatKhau.Multiline = true;
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.PasswordChar = '*';
            this.textBoxMatKhau.Size = new System.Drawing.Size(500, 50);
            this.textBoxMatKhau.TabIndex = 17;
            // 
            // buttonDangKy
            // 
            this.buttonDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(172)))));
            this.buttonDangKy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDangKy.Location = new System.Drawing.Point(405, 830);
            this.buttonDangKy.Name = "buttonDangKy";
            this.buttonDangKy.Size = new System.Drawing.Size(200, 70);
            this.buttonDangKy.TabIndex = 19;
            this.buttonDangKy.Text = "Đăng ký";
            this.buttonDangKy.UseVisualStyleBackColor = false;
            // 
            // textBoxHoChieu
            // 
            this.textBoxHoChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHoChieu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxHoChieu.Location = new System.Drawing.Point(820, 395);
            this.textBoxHoChieu.Multiline = true;
            this.textBoxHoChieu.Name = "textBoxHoChieu";
            this.textBoxHoChieu.Size = new System.Drawing.Size(500, 50);
            this.textBoxHoChieu.TabIndex = 23;
            // 
            // labelHoChieu
            // 
            this.labelHoChieu.AutoSize = true;
            this.labelHoChieu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHoChieu.Location = new System.Drawing.Point(820, 340);
            this.labelHoChieu.Name = "labelHoChieu";
            this.labelHoChieu.Size = new System.Drawing.Size(142, 41);
            this.labelHoChieu.TabIndex = 22;
            this.labelHoChieu.Text = "Hộ chiếu";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxEmail.Location = new System.Drawing.Point(820, 235);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(500, 50);
            this.textBoxEmail.TabIndex = 21;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelEmail.Location = new System.Drawing.Point(820, 180);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(95, 41);
            this.labelEmail.TabIndex = 20;
            this.labelEmail.Text = "Email";
            // 
            // textBoxHoVaTen
            // 
            this.textBoxHoVaTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHoVaTen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxHoVaTen.Location = new System.Drawing.Point(105, 395);
            this.textBoxHoVaTen.Multiline = true;
            this.textBoxHoVaTen.Name = "textBoxHoVaTen";
            this.textBoxHoVaTen.Size = new System.Drawing.Size(500, 50);
            this.textBoxHoVaTen.TabIndex = 31;
            // 
            // labelHoVaTen
            // 
            this.labelHoVaTen.AutoSize = true;
            this.labelHoVaTen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHoVaTen.Location = new System.Drawing.Point(105, 340);
            this.labelHoVaTen.Name = "labelHoVaTen";
            this.labelHoVaTen.Size = new System.Drawing.Size(153, 41);
            this.labelHoVaTen.TabIndex = 30;
            this.labelHoVaTen.Text = "Họ và tên";
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCMND.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxCMND.Location = new System.Drawing.Point(105, 235);
            this.textBoxCMND.Multiline = true;
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.Size = new System.Drawing.Size(500, 50);
            this.textBoxCMND.TabIndex = 29;
            // 
            // labelCMND
            // 
            this.labelCMND.AutoSize = true;
            this.labelCMND.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelCMND.Location = new System.Drawing.Point(105, 180);
            this.labelCMND.Name = "labelCMND";
            this.labelCMND.Size = new System.Drawing.Size(112, 41);
            this.labelCMND.TabIndex = 28;
            this.labelCMND.Text = "CMND";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSDT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxSDT.Location = new System.Drawing.Point(105, 715);
            this.textBoxSDT.Multiline = true;
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(500, 50);
            this.textBoxSDT.TabIndex = 27;
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelSDT.Location = new System.Drawing.Point(105, 660);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(75, 41);
            this.labelSDT.TabIndex = 26;
            this.labelSDT.Text = "SĐT";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiaChi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxDiaChi.Location = new System.Drawing.Point(105, 555);
            this.textBoxDiaChi.Multiline = true;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(500, 50);
            this.textBoxDiaChi.TabIndex = 25;
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDiaChi.Location = new System.Drawing.Point(105, 500);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(114, 41);
            this.labelDiaChi.TabIndex = 24;
            this.labelDiaChi.Text = "Địa chỉ";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.textBoxHoVaTen);
            this.Controls.Add(this.labelHoVaTen);
            this.Controls.Add(this.textBoxCMND);
            this.Controls.Add(this.labelCMND);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.labelSDT);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.textBoxHoChieu);
            this.Controls.Add(this.labelHoChieu);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonDangKy);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.labelMatKhau);
            this.Controls.Add(this.textBoxTenDangNhap);
            this.Controls.Add(this.labelTenDangNhap);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonHuy);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label labelDangKy;
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.TextBox textBoxTenDangNhap;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Button buttonDangKy;
        private System.Windows.Forms.TextBox textBoxHoChieu;
        private System.Windows.Forms.Label labelHoChieu;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxHoVaTen;
        private System.Windows.Forms.Label labelHoVaTen;
        private System.Windows.Forms.TextBox textBoxCMND;
        private System.Windows.Forms.Label labelCMND;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label labelDiaChi;
    }
}

