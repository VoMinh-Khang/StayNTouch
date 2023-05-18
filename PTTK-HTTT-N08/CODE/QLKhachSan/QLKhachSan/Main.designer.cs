namespace ATBMHTTT
{
    partial class Main
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.buttonThongTinDichVu = new System.Windows.Forms.Button();
            this.buttonLichSuDatPhong = new System.Windows.Forms.Button();
            this.buttonThongTinCaNhan = new System.Windows.Forms.Button();
            this.buttonThongTinPhong = new System.Windows.Forms.Button();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.labelNguyenVanA = new System.Windows.Forms.Label();
            this.labelKhachHang = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.panelMenu.Controls.Add(this.buttonDangXuat);
            this.panelMenu.Controls.Add(this.buttonThongTinDichVu);
            this.panelMenu.Controls.Add(this.buttonLichSuDatPhong);
            this.panelMenu.Controls.Add(this.buttonThongTinCaNhan);
            this.panelMenu.Controls.Add(this.buttonThongTinPhong);
            this.panelMenu.Controls.Add(this.panelUsername);
            this.panelMenu.Location = new System.Drawing.Point(0, -10);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(337, 990);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonDangXuat.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDangXuat.Location = new System.Drawing.Point(-5, 784);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(352, 94);
            this.buttonDangXuat.TabIndex = 16;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // buttonThongTinDichVu
            // 
            this.buttonThongTinDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonThongTinDichVu.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThongTinDichVu.Location = new System.Drawing.Point(-5, 649);
            this.buttonThongTinDichVu.Name = "buttonThongTinDichVu";
            this.buttonThongTinDichVu.Size = new System.Drawing.Size(352, 94);
            this.buttonThongTinDichVu.TabIndex = 15;
            this.buttonThongTinDichVu.Text = "Thông tin dịch vụ";
            this.buttonThongTinDichVu.UseVisualStyleBackColor = false;
            this.buttonThongTinDichVu.Click += new System.EventHandler(this.buttonQuanLyQuyen_Click);
            // 
            // buttonLichSuDatPhong
            // 
            this.buttonLichSuDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonLichSuDatPhong.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonLichSuDatPhong.Location = new System.Drawing.Point(-5, 514);
            this.buttonLichSuDatPhong.Name = "buttonLichSuDatPhong";
            this.buttonLichSuDatPhong.Size = new System.Drawing.Size(352, 94);
            this.buttonLichSuDatPhong.TabIndex = 14;
            this.buttonLichSuDatPhong.Text = "Lịch sử đặt phòng";
            this.buttonLichSuDatPhong.UseVisualStyleBackColor = false;
            this.buttonLichSuDatPhong.Click += new System.EventHandler(this.buttonQuanLyUserRole_Click);
            // 
            // buttonThongTinCaNhan
            // 
            this.buttonThongTinCaNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonThongTinCaNhan.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThongTinCaNhan.Location = new System.Drawing.Point(-5, 379);
            this.buttonThongTinCaNhan.Name = "buttonThongTinCaNhan";
            this.buttonThongTinCaNhan.Size = new System.Drawing.Size(352, 94);
            this.buttonThongTinCaNhan.TabIndex = 13;
            this.buttonThongTinCaNhan.Text = "Thông tin cá nhân";
            this.buttonThongTinCaNhan.UseVisualStyleBackColor = false;
            this.buttonThongTinCaNhan.Click += new System.EventHandler(this.buttonThongTinQuyen_Click);
            // 
            // buttonThongTinPhong
            // 
            this.buttonThongTinPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(189)))));
            this.buttonThongTinPhong.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongTinPhong.Location = new System.Drawing.Point(-5, 244);
            this.buttonThongTinPhong.Name = "buttonThongTinPhong";
            this.buttonThongTinPhong.Size = new System.Drawing.Size(352, 94);
            this.buttonThongTinPhong.TabIndex = 12;
            this.buttonThongTinPhong.Text = "Thông tin phòng";
            this.buttonThongTinPhong.UseVisualStyleBackColor = false;
            this.buttonThongTinPhong.Click += new System.EventHandler(this.buttonThongTinUser_Click);
            // 
            // panelUsername
            // 
            this.panelUsername.Controls.Add(this.labelNguyenVanA);
            this.panelUsername.Controls.Add(this.labelKhachHang);
            this.panelUsername.Location = new System.Drawing.Point(0, 0);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(337, 160);
            this.panelUsername.TabIndex = 0;
            this.panelUsername.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUsername_Paint);
            // 
            // labelNguyenVanA
            // 
            this.labelNguyenVanA.AutoSize = true;
            this.labelNguyenVanA.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNguyenVanA.Location = new System.Drawing.Point(48, 93);
            this.labelNguyenVanA.Name = "labelNguyenVanA";
            this.labelNguyenVanA.Size = new System.Drawing.Size(241, 45);
            this.labelNguyenVanA.TabIndex = 3;
            this.labelNguyenVanA.Text = "Nguyễn Văn A";
            // 
            // labelKhachHang
            // 
            this.labelKhachHang.AutoSize = true;
            this.labelKhachHang.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelKhachHang.Location = new System.Drawing.Point(60, 23);
            this.labelKhachHang.Name = "labelKhachHang";
            this.labelKhachHang.Size = new System.Drawing.Size(226, 45);
            this.labelKhachHang.TabIndex = 2;
            this.labelKhachHang.Text = "KHÁCH HÀNG";
            this.labelKhachHang.Click += new System.EventHandler(this.labelAdmin_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelChildForm.Location = new System.Drawing.Point(338, -10);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1085, 990);
            this.panelChildForm.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonDangXuat;
        private System.Windows.Forms.Button buttonThongTinDichVu;
        private System.Windows.Forms.Button buttonLichSuDatPhong;
        private System.Windows.Forms.Button buttonThongTinCaNhan;
        private System.Windows.Forms.Button buttonThongTinPhong;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Label labelNguyenVanA;
        private System.Windows.Forms.Label labelKhachHang;
        private System.Windows.Forms.Panel panelChildForm;
    }
}