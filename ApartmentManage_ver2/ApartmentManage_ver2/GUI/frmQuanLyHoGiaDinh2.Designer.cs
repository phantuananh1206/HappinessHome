﻿namespace ApartmentManage_ver2.GUI
{
    partial class frmQuanLyHoGiaDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHoGiaDinh));
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongTV = new System.Windows.Forms.TextBox();
            this.txtMaHoGD = new System.Windows.Forms.TextBox();
            this.txtTenChuHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbDanhSachHoGiaDinh = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachHoGiaDinh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChiTietThanhVien = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.cbMaHoGiaDinh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.erpKiemTraLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbThongTin.SuspendLayout();
            this.grbDanhSachHoGiaDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoGiaDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ HỘ GIA ĐÌNH";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtSoCMND);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.txtSoLuongTV);
            this.grbThongTin.Controls.Add(this.txtMaHoGD);
            this.grbThongTin.Controls.Add(this.txtTenChuHo);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTin.Location = new System.Drawing.Point(44, 65);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(614, 119);
            this.grbThongTin.TabIndex = 2;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin hộ gia đình";
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSoCMND.Location = new System.Drawing.Point(455, 29);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(121, 24);
            this.txtSoCMND.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(302, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số CMND";
            // 
            // txtSoLuongTV
            // 
            this.txtSoLuongTV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSoLuongTV.Location = new System.Drawing.Point(455, 61);
            this.txtSoLuongTV.Name = "txtSoLuongTV";
            this.txtSoLuongTV.Size = new System.Drawing.Size(121, 24);
            this.txtSoLuongTV.TabIndex = 19;
            // 
            // txtMaHoGD
            // 
            this.txtMaHoGD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMaHoGD.Location = new System.Drawing.Point(145, 29);
            this.txtMaHoGD.Name = "txtMaHoGD";
            this.txtMaHoGD.Size = new System.Drawing.Size(121, 24);
            this.txtMaHoGD.TabIndex = 17;
            // 
            // txtTenChuHo
            // 
            this.txtTenChuHo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTenChuHo.Location = new System.Drawing.Point(145, 61);
            this.txtTenChuHo.Name = "txtTenChuHo";
            this.txtTenChuHo.Size = new System.Drawing.Size(121, 24);
            this.txtTenChuHo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã hộ gia đình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(17, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên chủ hộ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(302, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Số lượng thành viên";
            // 
            // grbDanhSachHoGiaDinh
            // 
            this.grbDanhSachHoGiaDinh.Controls.Add(this.dgvDanhSachHoGiaDinh);
            this.grbDanhSachHoGiaDinh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grbDanhSachHoGiaDinh.Location = new System.Drawing.Point(44, 200);
            this.grbDanhSachHoGiaDinh.Name = "grbDanhSachHoGiaDinh";
            this.grbDanhSachHoGiaDinh.Size = new System.Drawing.Size(614, 200);
            this.grbDanhSachHoGiaDinh.TabIndex = 3;
            this.grbDanhSachHoGiaDinh.TabStop = false;
            this.grbDanhSachHoGiaDinh.Text = "Danh sách hộ gia đình";
            // 
            // dgvDanhSachHoGiaDinh
            // 
            this.dgvDanhSachHoGiaDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHoGiaDinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.clSoCMND,
            this.clSoThanhVien,
            this.clChiTietThanhVien});
            this.dgvDanhSachHoGiaDinh.Location = new System.Drawing.Point(0, 24);
            this.dgvDanhSachHoGiaDinh.Name = "dgvDanhSachHoGiaDinh";
            this.dgvDanhSachHoGiaDinh.Size = new System.Drawing.Size(614, 150);
            this.dgvDanhSachHoGiaDinh.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHOGD";
            this.Column1.HeaderText = "Mã hộ gia đình";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENCHUHO";
            this.Column2.HeaderText = "Tên chủ hộ";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // clSoCMND
            // 
            this.clSoCMND.DataPropertyName = "SOCMND";
            this.clSoCMND.HeaderText = "Số CMND";
            this.clSoCMND.Name = "clSoCMND";
            // 
            // clSoThanhVien
            // 
            this.clSoThanhVien.DataPropertyName = "SOLUONGTV";
            this.clSoThanhVien.HeaderText = "Số lượng thành viên";
            this.clSoThanhVien.Name = "clSoThanhVien";
            this.clSoThanhVien.Width = 130;
            // 
            // clChiTietThanhVien
            // 
            this.clChiTietThanhVien.DataPropertyName = "CHITIET";
            this.clChiTietThanhVien.HeaderText = "Chi tiết thành viên";
            this.clChiTietThanhVien.Name = "clChiTietThanhVien";
            this.clChiTietThanhVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clChiTietThanhVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clChiTietThanhVien.Width = 120;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(606, 442);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(81, 41);
            this.btnDong.TabIndex = 27;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cbMaHoGiaDinh
            // 
            this.cbMaHoGiaDinh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaHoGiaDinh.FormattingEnabled = true;
            this.cbMaHoGiaDinh.Location = new System.Drawing.Point(301, 460);
            this.cbMaHoGiaDinh.Name = "cbMaHoGiaDinh";
            this.cbMaHoGiaDinh.Size = new System.Drawing.Size(112, 21);
            this.cbMaHoGiaDinh.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(312, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mã hộ gia đình";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThi.Image")));
            this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThi.Location = new System.Drawing.Point(506, 442);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(94, 41);
            this.btnHienThi.TabIndex = 24;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(419, 442);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(81, 41);
            this.btnTim.TabIndex = 23;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(122, 442);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 41);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(214, 440);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 41);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(33, 442);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 41);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // erpKiemTraLoi
            // 
            this.erpKiemTraLoi.ContainerControl = this;
            // 
            // frmQuanLyHoGiaDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 506);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.grbDanhSachHoGiaDinh);
            this.Controls.Add(this.cbMaHoGiaDinh);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Name = "frmQuanLyHoGiaDinh";
            this.Text = "Quản lý hộ gia đình";
            this.Load += new System.EventHandler(this.frmQuanLyHoGiaDinh_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbDanhSachHoGiaDinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoGiaDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpKiemTraLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuongTV;
        private System.Windows.Forms.TextBox txtMaHoGD;
        private System.Windows.Forms.TextBox txtTenChuHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbDanhSachHoGiaDinh;
        private System.Windows.Forms.DataGridView dgvDanhSachHoGiaDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoThanhVien;
        private System.Windows.Forms.DataGridViewLinkColumn clChiTietThanhVien;
        public System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cbMaHoGiaDinh;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ErrorProvider erpKiemTraLoi;
    }
}