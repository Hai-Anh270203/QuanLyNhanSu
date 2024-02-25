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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DGVNhanVien = new System.Windows.Forms.DataGridView();
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
            this.tabQLBH = new System.Windows.Forms.TabPage();
            this.tabQLTV = new System.Windows.Forms.TabPage();
            this.PAnh = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tadNhanVien.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tadNhanVien);
            this.tabControl1.Controls.Add(this.tabQLBH);
            this.tabControl1.Controls.Add(this.tabQLTV);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1673, 936);
            this.tabControl1.TabIndex = 1;
            // 
            // tadNhanVien
            // 
            this.tadNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tadNhanVien.Controls.Add(this.button2);
            this.tadNhanVien.Controls.Add(this.txtTenNhanVien);
            this.tadNhanVien.Controls.Add(this.label4);
            this.tadNhanVien.Controls.Add(this.txtMaNhanVien);
            this.tadNhanVien.Controls.Add(this.label3);
            this.tadNhanVien.Controls.Add(this.panel1);
            this.tadNhanVien.Controls.Add(this.label1);
            this.tadNhanVien.Controls.Add(this.PAnh);
            this.tadNhanVien.Controls.Add(this.btnXuatExcel);
            this.tadNhanVien.Controls.Add(this.btnLamMoi);
            this.tadNhanVien.Controls.Add(this.btnSua);
            this.tadNhanVien.Controls.Add(this.btnXoa);
            this.tadNhanVien.Controls.Add(this.button1);
            this.tadNhanVien.Controls.Add(this.DGVNhanVien);
            this.tadNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tadNhanVien.Location = new System.Drawing.Point(4, 38);
            this.tadNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tadNhanVien.Name = "tadNhanVien";
            this.tadNhanVien.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tadNhanVien.Size = new System.Drawing.Size(1665, 894);
            this.tadNhanVien.TabIndex = 0;
            this.tadNhanVien.Text = "Nhân viên";
            this.tadNhanVien.Click += new System.EventHandler(this.tadNhanVien_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(203)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1999, 65);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thông tin chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1472, 451);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ảnh nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXuatExcel.Location = new System.Drawing.Point(1124, 684);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(152, 56);
            this.btnXuatExcel.TabIndex = 5;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.BackColorChanged += new System.EventHandler(this.btnXuatExcel_BackColorChanged);
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(882, 684);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(138, 56);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.BackColorChanged += new System.EventHandler(this.btnXuatExcel_BackColorChanged);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(626, 683);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(167, 57);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa nhân sự";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.BackColorChanged += new System.EventHandler(this.btnXuatExcel_BackColorChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(373, 683);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 57);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa nhân sự";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.BackColorChanged += new System.EventHandler(this.btnXuatExcel_BackColorChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(133, 682);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm nhân sự";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.BackColorChanged += new System.EventHandler(this.btnXuatExcel_BackColorChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGVNhanVien
            // 
            this.DGVNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.DGVNhanVien.Location = new System.Drawing.Point(37, 218);
            this.DGVNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVNhanVien.Name = "DGVNhanVien";
            this.DGVNhanVien.RowHeadersWidth = 10;
            this.DGVNhanVien.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVNhanVien.RowTemplate.Height = 10;
            this.DGVNhanVien.Size = new System.Drawing.Size(1386, 412);
            this.DGVNhanVien.TabIndex = 0;
            this.DGVNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNhanVien_CellClick);
            this.DGVNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVNhanVien_CellContentClick);
            // 
            // jl
            // 
            this.jl.DataPropertyName = "IdUser";
            this.jl.HeaderText = "IdUser";
            this.jl.MinimumWidth = 8;
            this.jl.Name = "jl";
            this.jl.Width = 80;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.MinimumWidth = 8;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Width = 150;
            // 
            // DuongDa
            // 
            this.DuongDa.DataPropertyName = "DuongDan";
            this.DuongDa.HeaderText = "Dường dẫn";
            this.DuongDa.MinimumWidth = 8;
            this.DuongDa.Name = "DuongDa";
            this.DuongDa.Width = 150;
            // 
            // MNV
            // 
            this.MNV.DataPropertyName = "MaNhanVien";
            this.MNV.HeaderText = "Mã nhân viên";
            this.MNV.MinimumWidth = 8;
            this.MNV.Name = "MNV";
            this.MNV.Width = 150;
            // 
            // HT
            // 
            this.HT.DataPropertyName = "HoTen";
            this.HT.HeaderText = "Họ và tên";
            this.HT.MinimumWidth = 8;
            this.HT.Name = "HT";
            this.HT.Width = 150;
            // 
            // NS
            // 
            this.NS.DataPropertyName = "NgaySinh";
            this.NS.HeaderText = "Ngày sinh";
            this.NS.MinimumWidth = 8;
            this.NS.Name = "NS";
            this.NS.Width = 150;
            // 
            // GT
            // 
            this.GT.DataPropertyName = "GioiTinh";
            this.GT.HeaderText = "Giới tính";
            this.GT.MinimumWidth = 8;
            this.GT.Name = "GT";
            this.GT.Width = 150;
            // 
            // E
            // 
            this.E.DataPropertyName = "Email";
            this.E.HeaderText = "Email";
            this.E.MinimumWidth = 8;
            this.E.Name = "E";
            this.E.Width = 150;
            // 
            // DC
            // 
            this.DC.DataPropertyName = "DiaChi";
            this.DC.HeaderText = "Địa chỉ";
            this.DC.MinimumWidth = 8;
            this.DC.Name = "DC";
            this.DC.Width = 150;
            // 
            // DV
            // 
            this.DV.DataPropertyName = "DangVien";
            this.DV.HeaderText = "Đảng viên";
            this.DV.MinimumWidth = 8;
            this.DV.Name = "DV";
            this.DV.Width = 150;
            // 
            // HV
            // 
            this.HV.DataPropertyName = "HocVan";
            this.HV.HeaderText = "Học vấn";
            this.HV.MinimumWidth = 8;
            this.HV.Name = "HV";
            this.HV.Width = 150;
            // 
            // nameCMND
            // 
            this.nameCMND.DataPropertyName = "CMND";
            this.nameCMND.HeaderText = "CMND";
            this.nameCMND.MinimumWidth = 8;
            this.nameCMND.Name = "nameCMND";
            this.nameCMND.Width = 150;
            // 
            // TCD
            // 
            this.TCD.DataPropertyName = "TenChucDanh";
            this.TCD.HeaderText = "Chức danh";
            this.TCD.MinimumWidth = 8;
            this.TCD.Name = "TCD";
            this.TCD.Width = 150;
            // 
            // LoaiHopDong
            // 
            this.LoaiHopDong.DataPropertyName = "LoaiHopDong";
            this.LoaiHopDong.HeaderText = "Loại hợp đồng";
            this.LoaiHopDong.MinimumWidth = 8;
            this.LoaiHopDong.Name = "LoaiHopDong";
            this.LoaiHopDong.Width = 150;
            // 
            // TienLuong
            // 
            this.TienLuong.DataPropertyName = "IdTienLuong";
            this.TienLuong.HeaderText = "Mã tiền lương";
            this.TienLuong.MinimumWidth = 8;
            this.TienLuong.Name = "TienLuong";
            this.TienLuong.Width = 150;
            // 
            // TCT
            // 
            this.TCT.DataPropertyName = "TenCongTac";
            this.TCT.HeaderText = "Công tác";
            this.TCT.MinimumWidth = 8;
            this.TCT.Name = "TCT";
            this.TCT.Width = 150;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.MinimumWidth = 8;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Width = 150;
            // 
            // tabQLBH
            // 
            this.tabQLBH.Location = new System.Drawing.Point(4, 38);
            this.tabQLBH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQLBH.Name = "tabQLBH";
            this.tabQLBH.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQLBH.Size = new System.Drawing.Size(1665, 894);
            this.tabQLBH.TabIndex = 1;
            this.tabQLBH.Text = "Quản lý bảo hiểm";
            this.tabQLBH.UseVisualStyleBackColor = true;
            // 
            // tabQLTV
            // 
            this.tabQLTV.Location = new System.Drawing.Point(4, 38);
            this.tabQLTV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQLTV.Name = "tabQLTV";
            this.tabQLTV.Size = new System.Drawing.Size(1665, 894);
            this.tabQLTV.TabIndex = 2;
            this.tabQLTV.Text = "Quản lý thử thôi việc";
            this.tabQLTV.UseVisualStyleBackColor = true;
            // 
            // PAnh
            // 
            this.PAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(242)))));
            this.PAnh.Location = new System.Drawing.Point(1457, 218);
            this.PAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PAnh.Name = "PAnh";
            this.PAnh.Size = new System.Drawing.Size(179, 207);
            this.PAnh.TabIndex = 6;
            this.PAnh.TabStop = false;
            this.PAnh.Click += new System.EventHandler(this.PAnh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã nhân viên:";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNhanVien.Location = new System.Drawing.Point(199, 136);
            this.txtMaNhanVien.Multiline = true;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(274, 38);
            this.txtMaNhanVien.TabIndex = 10;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNhanVien.Location = new System.Drawing.Point(789, 133);
            this.txtTenNhanVien.Multiline = true;
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(375, 38);
            this.txtTenNhanVien.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên nhân viên:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1286, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 65);
            this.button2.TabIndex = 13;
            this.button2.Text = "lọc";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1673, 936);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tadNhanVien.ResumeLayout(false);
            this.tadNhanVien.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PAnh)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}