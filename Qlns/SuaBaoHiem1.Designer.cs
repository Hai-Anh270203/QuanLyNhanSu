
namespace Qlns
{
    partial class SuaBaoHiem1
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
            this.btnBP = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboMaNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoiCap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTienBaoHiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboMaBaoHiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DateNgayCap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBP
            // 
            this.btnBP.FlatAppearance.BorderSize = 0;
            this.btnBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBP.ForeColor = System.Drawing.Color.White;
            this.btnBP.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnBP.IconColor = System.Drawing.Color.White;
            this.btnBP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBP.IconSize = 34;
            this.btnBP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBP.Location = new System.Drawing.Point(40, 11);
            this.btnBP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBP.Name = "btnBP";
            this.btnBP.Padding = new System.Windows.Forms.Padding(12, 0, 18, 0);
            this.btnBP.Size = new System.Drawing.Size(425, 79);
            this.btnBP.TabIndex = 133;
            this.btnBP.Text = "Sửa bảo hiểm";
            this.btnBP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBP.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(41)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnBP);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1628, 90);
            this.panel1.TabIndex = 145;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::Qlns.Properties.Resources.icon_minimizar;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(1517, 20);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(18, 18);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 149;
            this.btnMin.TabStop = false;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = global::Qlns.Properties.Resources.icon_restaurar;
            this.btnMax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMax.Location = new System.Drawing.Point(1553, 20);
            this.btnMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(18, 18);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 148;
            this.btnMax.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::Qlns.Properties.Resources.icon_cerrar2;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(1587, 20);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 18);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 147;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label23.Location = new System.Drawing.Point(59, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(140, 24);
            this.label23.TabIndex = 124;
            this.label23.Text = "Sửa bảo hiểm";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(27, 66);
            this.label22.MaximumSize = new System.Drawing.Size(0, 2);
            this.label22.MinimumSize = new System.Drawing.Size(0, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1368, 2);
            this.label22.TabIndex = 125;
            this.label22.Text = "label5555555555555555555555555555555555555555555555555555555555555555555555555555" +
    "55555555555555555555555555555555555555555555555555555555555555555555555555555555" +
    "5555555555";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cboMaNhanVien);
            this.panel3.Controls.Add(this.txtGhiChu);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtNoiCap);
            this.panel3.Controls.Add(this.txtTienBaoHiem);
            this.panel3.Controls.Add(this.cboMaBaoHiem);
            this.panel3.Controls.Add(this.DateNgayCap);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Location = new System.Drawing.Point(40, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1496, 468);
            this.panel3.TabIndex = 146;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cboMaNhanVien.BorderRadius = 4;
            this.cboMaNhanVien.BorderThickness = 2;
            this.cboMaNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMaNhanVien.ItemHeight = 30;
            this.cboMaNhanVien.Location = new System.Drawing.Point(230, 178);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(176, 36);
            this.cboMaNhanVien.TabIndex = 182;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderRadius = 4;
            this.txtGhiChu.BorderThickness = 2;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Location = new System.Drawing.Point(1040, 107);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderText = "";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(176, 36);
            this.txtGhiChu.TabIndex = 181;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(888, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 180;
            this.label2.Text = "Ghi chú";
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.BorderRadius = 4;
            this.txtNoiCap.BorderThickness = 2;
            this.txtNoiCap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiCap.DefaultText = "";
            this.txtNoiCap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiCap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiCap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiCap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiCap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoiCap.ForeColor = System.Drawing.Color.Black;
            this.txtNoiCap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiCap.Location = new System.Drawing.Point(661, 178);
            this.txtNoiCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.PasswordChar = '\0';
            this.txtNoiCap.PlaceholderText = "";
            this.txtNoiCap.SelectedText = "";
            this.txtNoiCap.Size = new System.Drawing.Size(176, 36);
            this.txtNoiCap.TabIndex = 179;
            // 
            // txtTienBaoHiem
            // 
            this.txtTienBaoHiem.BorderRadius = 4;
            this.txtTienBaoHiem.BorderThickness = 2;
            this.txtTienBaoHiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienBaoHiem.DefaultText = "";
            this.txtTienBaoHiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienBaoHiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienBaoHiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienBaoHiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienBaoHiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienBaoHiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTienBaoHiem.ForeColor = System.Drawing.Color.Black;
            this.txtTienBaoHiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienBaoHiem.Location = new System.Drawing.Point(230, 107);
            this.txtTienBaoHiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTienBaoHiem.Name = "txtTienBaoHiem";
            this.txtTienBaoHiem.PasswordChar = '\0';
            this.txtTienBaoHiem.PlaceholderText = "";
            this.txtTienBaoHiem.SelectedText = "";
            this.txtTienBaoHiem.Size = new System.Drawing.Size(176, 36);
            this.txtTienBaoHiem.TabIndex = 178;
            // 
            // cboMaBaoHiem
            // 
            this.cboMaBaoHiem.BackColor = System.Drawing.Color.Transparent;
            this.cboMaBaoHiem.BorderRadius = 4;
            this.cboMaBaoHiem.BorderThickness = 2;
            this.cboMaBaoHiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaBaoHiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaBaoHiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaBaoHiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaBaoHiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaBaoHiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMaBaoHiem.ItemHeight = 30;
            this.cboMaBaoHiem.Location = new System.Drawing.Point(661, 107);
            this.cboMaBaoHiem.Name = "cboMaBaoHiem";
            this.cboMaBaoHiem.Size = new System.Drawing.Size(176, 36);
            this.cboMaBaoHiem.TabIndex = 177;
            // 
            // DateNgayCap
            // 
            this.DateNgayCap.Checked = true;
            this.DateNgayCap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(65)))), ((int)(((byte)(182)))));
            this.DateNgayCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNgayCap.ForeColor = System.Drawing.Color.White;
            this.DateNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateNgayCap.Location = new System.Drawing.Point(1033, 171);
            this.DateNgayCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateNgayCap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateNgayCap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateNgayCap.Name = "DateNgayCap";
            this.DateNgayCap.Size = new System.Drawing.Size(238, 43);
            this.DateNgayCap.TabIndex = 176;
            this.DateNgayCap.Value = new System.DateTime(2024, 3, 4, 18, 57, 4, 713);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(85, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 170;
            this.label1.Text = "Tên bảo hiểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(85, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 171;
            this.label3.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label6.Location = new System.Drawing.Point(509, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 172;
            this.label6.Text = "Nơi cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label7.Location = new System.Drawing.Point(509, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 173;
            this.label7.Text = "Mã bảo hiểm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label10.Location = new System.Drawing.Point(888, 184);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 174;
            this.label10.Text = "Ngày cấp";
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 25;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuy.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnHuy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnHuy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnHuy.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnHuy.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuy.IndicateFocus = true;
            this.btnHuy.Location = new System.Drawing.Point(771, 299);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ShadowDecoration.BorderRadius = 5;
            this.btnHuy.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btnHuy.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.btnHuy.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.btnHuy.ShadowDecoration.Depth = 5;
            this.btnHuy.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnHuy.Size = new System.Drawing.Size(250, 76);
            this.btnHuy.TabIndex = 166;
            this.btnHuy.Text = "Hủy ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 25;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnSua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnSua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.btnSua.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnSua.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.IndicateFocus = true;
            this.btnSua.Location = new System.Drawing.Point(374, 299);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.BorderRadius = 5;
            this.btnSua.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.btnSua.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.btnSua.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.btnSua.ShadowDecoration.Depth = 5;
            this.btnSua.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnSua.Size = new System.Drawing.Size(250, 76);
            this.btnSua.TabIndex = 165;
            this.btnSua.Text = "Sửa bảo hiểm";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // SuaBaoHiem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 855);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuaBaoHiem1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaBaoHiem1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2GradientButton btnHuy;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiCap;
        private Guna.UI2.WinForms.Guna2TextBox txtTienBaoHiem;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaBaoHiem;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateNgayCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaNhanVien;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnExit;
    }
}