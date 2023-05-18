namespace QLKhachSan
{
    partial class ChinhSuaTaiKhoan
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
            this.labelChinhSuaTaiKhoan = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.dataGridViewChinhSuaTaiKhoan = new System.Windows.Forms.DataGridView();
            this.textBoxTypeShow = new System.Windows.Forms.TextBox();
            this.labelTypeShow = new System.Windows.Forms.Label();
            this.textBoxUsernameShow = new System.Windows.Forms.TextBox();
            this.labelUsernameShow = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChinhSuaTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.groupBox.Controls.Add(this.labelChinhSuaTaiKhoan);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox.Location = new System.Drawing.Point(0, -10);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1425, 160);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // labelChinhSuaTaiKhoan
            // 
            this.labelChinhSuaTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelChinhSuaTaiKhoan.Location = new System.Drawing.Point(490, 50);
            this.labelChinhSuaTaiKhoan.Name = "labelChinhSuaTaiKhoan";
            this.labelChinhSuaTaiKhoan.Size = new System.Drawing.Size(500, 50);
            this.labelChinhSuaTaiKhoan.TabIndex = 0;
            this.labelChinhSuaTaiKhoan.Text = "CHỈNH SỬA TÀI KHOẢN";
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonHuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(1150, 830);
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
            this.labelUsername.Location = new System.Drawing.Point(105, 200);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(158, 41);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxUsername.Location = new System.Drawing.Point(105, 250);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(500, 50);
            this.textBoxUsername.TabIndex = 15;
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMatKhau.Location = new System.Drawing.Point(575, 680);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(152, 41);
            this.labelMatKhau.TabIndex = 16;
            this.labelMatKhau.Text = "Mật khẩu";
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(575, 730);
            this.textBoxMatKhau.Multiline = true;
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(300, 50);
            this.textBoxMatKhau.TabIndex = 17;
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(172)))));
            this.buttonCapNhat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCapNhat.Location = new System.Drawing.Point(800, 830);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(200, 70);
            this.buttonCapNhat.TabIndex = 19;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            // 
            // textBoxType
            // 
            this.textBoxType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxType.Location = new System.Drawing.Point(810, 250);
            this.textBoxType.Multiline = true;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(500, 50);
            this.textBoxType.TabIndex = 21;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelType.Location = new System.Drawing.Point(810, 200);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(86, 41);
            this.labelType.TabIndex = 20;
            this.labelType.Text = "Type";
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonQuayLai.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonQuayLai.Location = new System.Drawing.Point(100, 830);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(200, 70);
            this.buttonQuayLai.TabIndex = 18;
            this.buttonQuayLai.Text = "Quay lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(172)))));
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTimKiem.Location = new System.Drawing.Point(450, 830);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(200, 70);
            this.buttonTimKiem.TabIndex = 22;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // dataGridViewChinhSuaTaiKhoan
            // 
            this.dataGridViewChinhSuaTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChinhSuaTaiKhoan.Location = new System.Drawing.Point(0, 350);
            this.dataGridViewChinhSuaTaiKhoan.Name = "dataGridViewChinhSuaTaiKhoan";
            this.dataGridViewChinhSuaTaiKhoan.RowHeadersWidth = 51;
            this.dataGridViewChinhSuaTaiKhoan.RowTemplate.Height = 24;
            this.dataGridViewChinhSuaTaiKhoan.Size = new System.Drawing.Size(1425, 300);
            this.dataGridViewChinhSuaTaiKhoan.TabIndex = 23;
            // 
            // textBoxTypeShow
            // 
            this.textBoxTypeShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTypeShow.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTypeShow.Location = new System.Drawing.Point(1050, 730);
            this.textBoxTypeShow.Multiline = true;
            this.textBoxTypeShow.Name = "textBoxTypeShow";
            this.textBoxTypeShow.Size = new System.Drawing.Size(300, 50);
            this.textBoxTypeShow.TabIndex = 27;
            // 
            // labelTypeShow
            // 
            this.labelTypeShow.AutoSize = true;
            this.labelTypeShow.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTypeShow.Location = new System.Drawing.Point(1050, 680);
            this.labelTypeShow.Name = "labelTypeShow";
            this.labelTypeShow.Size = new System.Drawing.Size(86, 41);
            this.labelTypeShow.TabIndex = 26;
            this.labelTypeShow.Text = "Type";
            // 
            // textBoxUsernameShow
            // 
            this.textBoxUsernameShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsernameShow.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxUsernameShow.Location = new System.Drawing.Point(100, 730);
            this.textBoxUsernameShow.Multiline = true;
            this.textBoxUsernameShow.Name = "textBoxUsernameShow";
            this.textBoxUsernameShow.Size = new System.Drawing.Size(300, 50);
            this.textBoxUsernameShow.TabIndex = 25;
            // 
            // labelUsernameShow
            // 
            this.labelUsernameShow.AutoSize = true;
            this.labelUsernameShow.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelUsernameShow.Location = new System.Drawing.Point(100, 680);
            this.labelUsernameShow.Name = "labelUsernameShow";
            this.labelUsernameShow.Size = new System.Drawing.Size(158, 41);
            this.labelUsernameShow.TabIndex = 24;
            this.labelUsernameShow.Text = "Username";
            // 
            // ChinhSuaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.textBoxTypeShow);
            this.Controls.Add(this.labelTypeShow);
            this.Controls.Add(this.textBoxUsernameShow);
            this.Controls.Add(this.labelUsernameShow);
            this.Controls.Add(this.dataGridViewChinhSuaTaiKhoan);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.buttonCapNhat);
            this.Controls.Add(this.buttonQuayLai);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.labelMatKhau);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonHuy);
            this.Name = "ChinhSuaTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChinhSuaTaiKhoan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChinhSuaTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label labelChinhSuaTaiKhoan;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewChinhSuaTaiKhoan;
        private System.Windows.Forms.TextBox textBoxTypeShow;
        private System.Windows.Forms.Label labelTypeShow;
        private System.Windows.Forms.TextBox textBoxUsernameShow;
        private System.Windows.Forms.Label labelUsernameShow;
    }
}

