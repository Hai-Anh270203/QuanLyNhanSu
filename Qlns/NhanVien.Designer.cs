namespace Qlns
{
    partial class NhanVien
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tadNhanVien = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.PAnh = new System.Windows.Forms.PictureBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DGVNhanVien = new System.Windows.Forms.DataGridView();
            this.tabQLBH = new System.Windows.Forms.TabPage();
            this.tabQLTV = new System.Windows.Forms.TabPage();
            this.jl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuongDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVD = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tadNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tadNhanVien);
            this.tabControl1.Controls.Add(this.tabQLBH);
            this.tabControl1.Controls.Add(this.tabQLTV);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1473, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // tadNhanVien
            // 
            this.tadNhanVien.Controls.Add(this.label1);
            this.tadNhanVien.Controls.Add(this.PAnh);
            this.tadNhanVien.Controls.Add(this.btnXuatExcel);
            this.tadNhanVien.Controls.Add(this.btnLamMoi);
            this.tadNhanVien.Controls.Add(this.btnSua);
            this.tadNhanVien.Controls.Add(this.btnXoa);
            this.tadNhanVien.Controls.Add(this.button1);
            this.tadNhanVien.Controls.Add(this.DGVNhanVien);
            this.tadNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tadNhanVien.Name = "tadNhanVien";
            this.tadNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tadNhanVien.Size = new System.Drawing.Size(1465, 409);
            this.tadNhanVien.TabIndex = 0;
            this.tadNhanVien.Text = "Nhân viên";
            this.tadNhanVien.UseVisualStyleBackColor = true;
            this.tadNhanVien.Click += new System.EventHandler(this.tadNhanVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1300, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ảnh nhân viên";
            // 
            // PAnh
            // 
            this.PAnh.Location = new System.Drawing.Point(1284, 32);
            this.PAnh.Name = "PAnh";
            this.PAnh.Size = new System.Drawing.Size(114, 142);
            this.PAnh.TabIndex = 6;
            this.PAnh.TabStop = false;
            this.PAnh.Click += new System.EventHandler(this.PAnh_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(804, 365);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(75, 23);
            this.btnXuatExcel.TabIndex = 5;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(641, 365);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(481, 366);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa nhân sự";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(313, 366);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa nhân sự";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm nhân sự";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGVNhanVien
            // 
            this.DGVNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jl,
            this.NgayBatDau,
            this.DuongDa,
            this.MNV,
            this.HT,
            this.NS,
            this.GT,
            this.E,
            this.DC,
            this.DV,
            this.HV,
            this.nameCMND,
            this.TCD,
            this.LoaiHopDong,
            this.TienLuong,
            this.TCT,
            this.NgayKetThuc});
            this.DGVNhanVien.Location = new System.Drawing.Point(51, 32);
            this.DGVNhanVien.Name = "DGVNhanVien";
            this.DGVNhanVien.Size = new System.Drawing.Size(1193, 315);
            this.DGVNhanVien.TabIndex = 0;
            this.DGVNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNhanVien_CellClick);
            this.DGVNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNhanVien_CellContentClick);
            // 
            // tabQLBH
            // 
            this.tabQLBH.Location = new System.Drawing.Point(4, 22);
            this.tabQLBH.Name = "tabQLBH";
            this.tabQLBH.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLBH.Size = new System.Drawing.Size(1465, 409);
            this.tabQLBH.TabIndex = 1;
            this.tabQLBH.Text = "Quản lý bảo hiểm";
            this.tabQLBH.UseVisualStyleBackColor = true;
            // 
            // tabQLTV
            // 
            this.tabQLTV.Location = new System.Drawing.Point(4, 22);
            this.tabQLTV.Name = "tabQLTV";
            this.tabQLTV.Size = new System.Drawing.Size(1465, 409);
            this.tabQLTV.TabIndex = 2;
            this.tabQLTV.Text = "Quản lý thử thôi việc";
            this.tabQLTV.UseVisualStyleBackColor = true;
            // 
            // jl
            // 
            this.jl.DataPropertyName = "IdUser";
            this.jl.HeaderText = "IdUser";
            this.jl.Name = "jl";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            // 
            // DuongDa
            // 
            this.DuongDa.DataPropertyName = "DuongDan";
            this.DuongDa.HeaderText = "Dường dẫn";
            this.DuongDa.Name = "DuongDa";
            // 
            // MNV
            // 
            this.MNV.DataPropertyName = "MaNhanVien";
            this.MNV.HeaderText = "Mã nhân viên";
            this.MNV.Name = "MNV";
            // 
            // HT
            // 
            this.HT.DataPropertyName = "HoTen";
            this.HT.HeaderText = "Họ và tên";
            this.HT.Name = "HT";
            // 
            // NS
            // 
            this.NS.DataPropertyName = "NgaySinh";
            this.NS.HeaderText = "Ngày sinh";
            this.NS.Name = "NS";
            // 
            // GT
            // 
            this.GT.DataPropertyName = "GioiTinh";
            this.GT.HeaderText = "Giới tính";
            this.GT.Name = "GT";
            // 
            // E
            // 
            this.E.DataPropertyName = "Email";
            this.E.HeaderText = "Email";
            this.E.Name = "E";
            // 
            // DC
            // 
            this.DC.DataPropertyName = "DiaChi";
            this.DC.HeaderText = "Địa chỉ";
            this.DC.Name = "DC";
            // 
            // DV
            // 
            this.DV.DataPropertyName = "DangVien";
            this.DV.HeaderText = "Đảng viên";
            this.DV.Name = "DV";
            // 
            // HV
            // 
            this.HV.DataPropertyName = "HocVan";
            this.HV.HeaderText = "Học vấn";
            this.HV.Name = "HV";
            // 
            // nameCMND
            // 
            this.nameCMND.DataPropertyName = "CMND";
            this.nameCMND.HeaderText = "CMND";
            this.nameCMND.Name = "nameCMND";
            // 
            // TCD
            // 
            this.TCD.DataPropertyName = "TenChucDanh";
            this.TCD.HeaderText = "Chức danh";
            this.TCD.Name = "TCD";
            // 
            // LoaiHopDong
            // 
            this.LoaiHopDong.DataPropertyName = "LoaiHopDong";
            this.LoaiHopDong.HeaderText = "Loại hợp đồng";
            this.LoaiHopDong.Name = "LoaiHopDong";
            // 
            // TienLuong
            // 
            this.TienLuong.DataPropertyName = "IdTienLuong";
            this.TienLuong.HeaderText = "Mã tiền lương";
            this.TienLuong.Name = "TienLuong";
            // 
            // TCT
            // 
            this.TCT.DataPropertyName = "TenCongTac";
            this.TCT.HeaderText = "Công tác";
            this.TCT.Name = "TCT";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // DGVD
            // 
            this.DGVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVD.Location = new System.Drawing.Point(572, 535);
            this.DGVD.Name = "DGVD";
            this.DGVD.Size = new System.Drawing.Size(240, 150);
            this.DGVD.TabIndex = 2;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 799);
            this.Controls.Add(this.DGVD);
            this.Controls.Add(this.tabControl1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tadNhanVien.ResumeLayout(false);
            this.tadNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tadNhanVien;
        private System.Windows.Forms.TabPage tabQLBH;
        private System.Windows.Forms.DataGridView DGVNhanVien;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabQLTV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn jl;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuongDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridView DGVD;
    }
}