namespace QLKhachSan
{
    partial class ThemTaiKhoan
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
            this.labelThemTaiKhoan = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.groupBox.Controls.Add(this.labelThemTaiKhoan);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox.Location = new System.Drawing.Point(0, -10);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1425, 160);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // labelThemTaiKhoan
            // 
            this.labelThemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThemTaiKhoan.Location = new System.Drawing.Point(550, 50);
            this.labelThemTaiKhoan.Name = "labelThemTaiKhoan";
            this.labelThemTaiKhoan.Size = new System.Drawing.Size(400, 50);
            this.labelThemTaiKhoan.TabIndex = 0;
            this.labelThemTaiKhoan.Text = "THÊM TÀI KHOẢN";
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonHuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(1000, 750);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(200, 70);
            this.buttonHuy.TabIndex = 13;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelUsername.Location = new System.Drawing.Point(420, 200);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(158, 41);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxUsername.Location = new System.Drawing.Point(420, 250);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(630, 50);
            this.textBoxUsername.TabIndex = 15;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMatKhau.Location = new System.Drawing.Point(420, 370);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(152, 41);
            this.labelMatKhau.TabIndex = 16;
            this.labelMatKhau.Text = "Mật khẩu";
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(420, 420);
            this.textBoxMatKhau.Multiline = true;
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.PasswordChar = '*';
            this.textBoxMatKhau.Size = new System.Drawing.Size(630, 50);
            this.textBoxMatKhau.TabIndex = 17;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(172)))));
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThem.Location = new System.Drawing.Point(600, 750);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(200, 70);
            this.buttonThem.TabIndex = 19;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            // 
            // textBoxType
            // 
            this.textBoxType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxType.Location = new System.Drawing.Point(420, 590);
            this.textBoxType.Multiline = true;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(630, 50);
            this.textBoxType.TabIndex = 21;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelType.Location = new System.Drawing.Point(420, 540);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(86, 41);
            this.labelType.TabIndex = 20;
            this.labelType.Text = "Type";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonQuayLai.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonQuayLai.Location = new System.Drawing.Point(200, 750);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(200, 70);
            this.buttonQuayLai.TabIndex = 18;
            this.buttonQuayLai.Text = "Quay lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.labelMatKhau);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonHuy);
            this.Name = "ThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemTaiKhoan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label labelThemTaiKhoan;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonQuayLai;
    }
}

