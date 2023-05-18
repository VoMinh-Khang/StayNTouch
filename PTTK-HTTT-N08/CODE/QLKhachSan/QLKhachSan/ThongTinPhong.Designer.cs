namespace QLKhachSan
{
    partial class ThongTinPhong
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
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.labelMaPhong = new System.Windows.Forms.Label();
            this.textBoxTienIch = new System.Windows.Forms.TextBox();
            this.labelTienIch = new System.Windows.Forms.Label();
            this.labelTenPhong = new System.Windows.Forms.Label();
            this.labelThongTinPhong = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelThongTinPhong2 = new System.Windows.Forms.Label();
            this.textBoxMaPhong = new System.Windows.Forms.TextBox();
            this.textBoxTenPhong = new System.Windows.Forms.TextBox();
            this.textBoxTinhTrang = new System.Windows.Forms.TextBox();
            this.labelTinhTrang = new System.Windows.Forms.Label();
            this.textBoxQuyDinh = new System.Windows.Forms.TextBox();
            this.labelQuyDinh = new System.Windows.Forms.Label();
            this.textBoxTenPhong2 = new System.Windows.Forms.TextBox();
            this.textBoxMaSoPhong = new System.Windows.Forms.TextBox();
            this.labelTimKiemThongTin = new System.Windows.Forms.Label();
            this.labelMaSoPhong = new System.Windows.Forms.Label();
            this.labelTenPhong2 = new System.Windows.Forms.Label();
            this.dataGridViewTimKiemThongTin = new System.Windows.Forms.DataGridView();
            this.buttonDatPhong = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(110)))));
            this.buttonQuayLai.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(1202, 400);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(200, 70);
            this.buttonQuayLai.TabIndex = 13;
            this.buttonQuayLai.Text = "Quay lại";
            this.buttonQuayLai.UseVisualStyleBackColor = false;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(172)))));
            this.buttonTimKiem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonTimKiem.Location = new System.Drawing.Point(1202, 200);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(200, 70);
            this.buttonTimKiem.TabIndex = 19;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // labelMaPhong
            // 
            this.labelMaPhong.AutoSize = true;
            this.labelMaPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaPhong.Location = new System.Drawing.Point(60, 300);
            this.labelMaPhong.Name = "labelMaPhong";
            this.labelMaPhong.Size = new System.Drawing.Size(163, 41);
            this.labelMaPhong.TabIndex = 26;
            this.labelMaPhong.Text = "Mã phòng";
            // 
            // textBoxTienIch
            // 
            this.textBoxTienIch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTienIch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTienIch.Location = new System.Drawing.Point(60, 750);
            this.textBoxTienIch.Multiline = true;
            this.textBoxTienIch.Name = "textBoxTienIch";
            this.textBoxTienIch.Size = new System.Drawing.Size(500, 100);
            this.textBoxTienIch.TabIndex = 25;
            // 
            // labelTienIch
            // 
            this.labelTienIch.AutoSize = true;
            this.labelTienIch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTienIch.Location = new System.Drawing.Point(60, 700);
            this.labelTienIch.Name = "labelTienIch";
            this.labelTienIch.Size = new System.Drawing.Size(128, 41);
            this.labelTienIch.TabIndex = 24;
            this.labelTienIch.Text = "Tiện ích";
            // 
            // labelTenPhong
            // 
            this.labelTenPhong.AutoSize = true;
            this.labelTenPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenPhong.Location = new System.Drawing.Point(60, 400);
            this.labelTenPhong.Name = "labelTenPhong";
            this.labelTenPhong.Size = new System.Drawing.Size(167, 41);
            this.labelTenPhong.TabIndex = 22;
            this.labelTenPhong.Text = "Tên phòng";
            // 
            // labelThongTinPhong
            // 
            this.labelThongTinPhong.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinPhong.Location = new System.Drawing.Point(530, 50);
            this.labelThongTinPhong.Name = "labelThongTinPhong";
            this.labelThongTinPhong.Size = new System.Drawing.Size(450, 50);
            this.labelThongTinPhong.TabIndex = 0;
            this.labelThongTinPhong.Text = "THÔNG TIN PHÒNG";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.groupBox.Controls.Add(this.labelThongTinPhong);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox.Location = new System.Drawing.Point(0, -10);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1425, 160);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // labelThongTinPhong2
            // 
            this.labelThongTinPhong2.AutoSize = true;
            this.labelThongTinPhong2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThongTinPhong2.ForeColor = System.Drawing.Color.Red;
            this.labelThongTinPhong2.Location = new System.Drawing.Point(60, 200);
            this.labelThongTinPhong2.Name = "labelThongTinPhong2";
            this.labelThongTinPhong2.Size = new System.Drawing.Size(256, 41);
            this.labelThongTinPhong2.TabIndex = 27;
            this.labelThongTinPhong2.Text = "Thông tin phòng";
            // 
            // textBoxMaPhong
            // 
            this.textBoxMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMaPhong.Location = new System.Drawing.Point(240, 294);
            this.textBoxMaPhong.Multiline = true;
            this.textBoxMaPhong.Name = "textBoxMaPhong";
            this.textBoxMaPhong.Size = new System.Drawing.Size(300, 47);
            this.textBoxMaPhong.TabIndex = 28;
            // 
            // textBoxTenPhong
            // 
            this.textBoxTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenPhong.Location = new System.Drawing.Point(240, 394);
            this.textBoxTenPhong.Multiline = true;
            this.textBoxTenPhong.Name = "textBoxTenPhong";
            this.textBoxTenPhong.Size = new System.Drawing.Size(300, 47);
            this.textBoxTenPhong.TabIndex = 29;
            // 
            // textBoxTinhTrang
            // 
            this.textBoxTinhTrang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTinhTrang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTinhTrang.Location = new System.Drawing.Point(240, 494);
            this.textBoxTinhTrang.Multiline = true;
            this.textBoxTinhTrang.Name = "textBoxTinhTrang";
            this.textBoxTinhTrang.Size = new System.Drawing.Size(300, 47);
            this.textBoxTinhTrang.TabIndex = 31;
            // 
            // labelTinhTrang
            // 
            this.labelTinhTrang.AutoSize = true;
            this.labelTinhTrang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTinhTrang.Location = new System.Drawing.Point(60, 500);
            this.labelTinhTrang.Name = "labelTinhTrang";
            this.labelTinhTrang.Size = new System.Drawing.Size(166, 41);
            this.labelTinhTrang.TabIndex = 30;
            this.labelTinhTrang.Text = "Tình trạng";
            // 
            // textBoxQuyDinh
            // 
            this.textBoxQuyDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuyDinh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxQuyDinh.Location = new System.Drawing.Point(240, 594);
            this.textBoxQuyDinh.Multiline = true;
            this.textBoxQuyDinh.Name = "textBoxQuyDinh";
            this.textBoxQuyDinh.Size = new System.Drawing.Size(300, 47);
            this.textBoxQuyDinh.TabIndex = 33;
            // 
            // labelQuyDinh
            // 
            this.labelQuyDinh.AutoSize = true;
            this.labelQuyDinh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelQuyDinh.Location = new System.Drawing.Point(61, 600);
            this.labelQuyDinh.Name = "labelQuyDinh";
            this.labelQuyDinh.Size = new System.Drawing.Size(147, 41);
            this.labelQuyDinh.TabIndex = 32;
            this.labelQuyDinh.Text = "Quy định";
            // 
            // textBoxTenPhong2
            // 
            this.textBoxTenPhong2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenPhong2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenPhong2.Location = new System.Drawing.Point(878, 394);
            this.textBoxTenPhong2.Multiline = true;
            this.textBoxTenPhong2.Name = "textBoxTenPhong2";
            this.textBoxTenPhong2.Size = new System.Drawing.Size(300, 47);
            this.textBoxTenPhong2.TabIndex = 38;
            // 
            // textBoxMaSoPhong
            // 
            this.textBoxMaSoPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaSoPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMaSoPhong.Location = new System.Drawing.Point(878, 294);
            this.textBoxMaSoPhong.Multiline = true;
            this.textBoxMaSoPhong.Name = "textBoxMaSoPhong";
            this.textBoxMaSoPhong.Size = new System.Drawing.Size(300, 47);
            this.textBoxMaSoPhong.TabIndex = 37;
            // 
            // labelTimKiemThongTin
            // 
            this.labelTimKiemThongTin.AutoSize = true;
            this.labelTimKiemThongTin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTimKiemThongTin.ForeColor = System.Drawing.Color.Red;
            this.labelTimKiemThongTin.Location = new System.Drawing.Point(670, 200);
            this.labelTimKiemThongTin.Name = "labelTimKiemThongTin";
            this.labelTimKiemThongTin.Size = new System.Drawing.Size(289, 41);
            this.labelTimKiemThongTin.TabIndex = 36;
            this.labelTimKiemThongTin.Text = "Tìm kiếm thông tin";
            // 
            // labelMaSoPhong
            // 
            this.labelMaSoPhong.AutoSize = true;
            this.labelMaSoPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaSoPhong.Location = new System.Drawing.Point(670, 300);
            this.labelMaSoPhong.Name = "labelMaSoPhong";
            this.labelMaSoPhong.Size = new System.Drawing.Size(202, 41);
            this.labelMaSoPhong.TabIndex = 35;
            this.labelMaSoPhong.Text = "Mã số phòng";
            // 
            // labelTenPhong2
            // 
            this.labelTenPhong2.AutoSize = true;
            this.labelTenPhong2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenPhong2.Location = new System.Drawing.Point(670, 400);
            this.labelTenPhong2.Name = "labelTenPhong2";
            this.labelTenPhong2.Size = new System.Drawing.Size(167, 41);
            this.labelTenPhong2.TabIndex = 34;
            this.labelTenPhong2.Text = "Tên phòng";
            // 
            // dataGridViewTimKiemThongTin
            // 
            this.dataGridViewTimKiemThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiemThongTin.Location = new System.Drawing.Point(665, 494);
            this.dataGridViewTimKiemThongTin.Name = "dataGridViewTimKiemThongTin";
            this.dataGridViewTimKiemThongTin.RowHeadersWidth = 51;
            this.dataGridViewTimKiemThongTin.RowTemplate.Height = 24;
            this.dataGridViewTimKiemThongTin.Size = new System.Drawing.Size(760, 485);
            this.dataGridViewTimKiemThongTin.TabIndex = 39;
            // 
            // buttonDatPhong
            // 
            this.buttonDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(172)))));
            this.buttonDatPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDatPhong.Location = new System.Drawing.Point(1202, 300);
            this.buttonDatPhong.Name = "buttonDatPhong";
            this.buttonDatPhong.Size = new System.Drawing.Size(200, 70);
            this.buttonDatPhong.TabIndex = 40;
            this.buttonDatPhong.Text = "Đặt phòng";
            this.buttonDatPhong.UseVisualStyleBackColor = false;
            // 
            // ThongTinPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.buttonDatPhong);
            this.Controls.Add(this.dataGridViewTimKiemThongTin);
            this.Controls.Add(this.textBoxTenPhong2);
            this.Controls.Add(this.textBoxMaSoPhong);
            this.Controls.Add(this.labelTimKiemThongTin);
            this.Controls.Add(this.labelMaSoPhong);
            this.Controls.Add(this.labelTenPhong2);
            this.Controls.Add(this.textBoxQuyDinh);
            this.Controls.Add(this.labelQuyDinh);
            this.Controls.Add(this.textBoxTinhTrang);
            this.Controls.Add(this.labelTinhTrang);
            this.Controls.Add(this.textBoxTenPhong);
            this.Controls.Add(this.textBoxMaPhong);
            this.Controls.Add(this.labelThongTinPhong2);
            this.Controls.Add(this.labelMaPhong);
            this.Controls.Add(this.textBoxTienIch);
            this.Controls.Add(this.labelTienIch);
            this.Controls.Add(this.labelTenPhong);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonQuayLai);
            this.Name = "ThongTinPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinPhong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Label labelMaPhong;
        private System.Windows.Forms.TextBox textBoxTienIch;
        private System.Windows.Forms.Label labelTienIch;
        private System.Windows.Forms.Label labelTenPhong;
        private System.Windows.Forms.Label labelThongTinPhong;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelThongTinPhong2;
        private System.Windows.Forms.TextBox textBoxMaPhong;
        private System.Windows.Forms.TextBox textBoxTenPhong;
        private System.Windows.Forms.TextBox textBoxTinhTrang;
        private System.Windows.Forms.Label labelTinhTrang;
        private System.Windows.Forms.TextBox textBoxQuyDinh;
        private System.Windows.Forms.Label labelQuyDinh;
        private System.Windows.Forms.TextBox textBoxTenPhong2;
        private System.Windows.Forms.TextBox textBoxMaSoPhong;
        private System.Windows.Forms.Label labelTimKiemThongTin;
        private System.Windows.Forms.Label labelMaSoPhong;
        private System.Windows.Forms.Label labelTenPhong2;
        private System.Windows.Forms.DataGridView dataGridViewTimKiemThongTin;
        private System.Windows.Forms.Button buttonDatPhong;
    }
}

