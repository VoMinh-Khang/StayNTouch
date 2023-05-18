namespace QLKhachSan
{
    partial class DangNhap
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
            this.labelDangNhap = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.textBoxTenDangNhap = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.buttonDangKy = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.groupBox.Controls.Add(this.labelDangNhap);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox.Location = new System.Drawing.Point(0, -10);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1425, 160);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // labelDangNhap
            // 
            this.labelDangNhap.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDangNhap.Location = new System.Drawing.Point(590, 50);
            this.labelDangNhap.Name = "labelDangNhap";
            this.labelDangNhap.Size = new System.Drawing.Size(300, 50);
            this.labelDangNhap.TabIndex = 0;
            this.labelDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonHuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(1000, 723);
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
            this.labelTenDangNhap.Location = new System.Drawing.Point(418, 303);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(226, 41);
            this.labelTenDangNhap.TabIndex = 14;
            this.labelTenDangNhap.Text = "Tên đăng nhập";
            // 
            // textBoxTenDangNhap
            // 
            this.textBoxTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenDangNhap.Location = new System.Drawing.Point(418, 356);
            this.textBoxTenDangNhap.Multiline = true;
            this.textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            this.textBoxTenDangNhap.Size = new System.Drawing.Size(630, 50);
            this.textBoxTenDangNhap.TabIndex = 15;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMatKhau.Location = new System.Drawing.Point(418, 465);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(152, 41);
            this.labelMatKhau.TabIndex = 16;
            this.labelMatKhau.Text = "Mật khẩu";
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(418, 518);
            this.textBoxMatKhau.Multiline = true;
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.PasswordChar = '*';
            this.textBoxMatKhau.Size = new System.Drawing.Size(630, 50);
            this.textBoxMatKhau.TabIndex = 17;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(172)))));
            this.buttonDangNhap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDangNhap.Location = new System.Drawing.Point(200, 723);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(200, 70);
            this.buttonDangNhap.TabIndex = 18;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = false;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // buttonDangKy
            // 
            this.buttonDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(172)))));
            this.buttonDangKy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDangKy.Location = new System.Drawing.Point(600, 723);
            this.buttonDangKy.Name = "buttonDangKy";
            this.buttonDangKy.Size = new System.Drawing.Size(200, 70);
            this.buttonDangKy.TabIndex = 19;
            this.buttonDangKy.Text = "Đăng ký";
            this.buttonDangKy.UseVisualStyleBackColor = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.buttonDangKy);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.labelMatKhau);
            this.Controls.Add(this.textBoxTenDangNhap);
            this.Controls.Add(this.labelTenDangNhap);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonHuy);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label labelDangNhap;
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.TextBox textBoxTenDangNhap;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Button buttonDangKy;
    }
}

