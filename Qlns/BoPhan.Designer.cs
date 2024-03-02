namespace Qlns
{
    partial class BoPhan
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
            this.tabChucDanh = new System.Windows.Forms.TabPage();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoaCD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSuaCD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThemCD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cboMaChucDanh = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenChucDanh = new System.Windows.Forms.TextBox();
            this.txtLuongCoBan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvCD = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCongTac = new System.Windows.Forms.TabPage();
            this.btnMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSuaCT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThemCT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cboMaCongTac = new System.Windows.Forms.ComboBox();
            this.txtTenCongTac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_CongTac = new System.Windows.Forms.DataGridView();
            this.MaCongTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCongTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabChucDanh.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCD)).BeginInit();
            this.tabCongTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CongTac)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChucDanh);
            this.tabControl1.Controls.Add(this.tabCongTac);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 722);
            this.tabControl1.TabIndex = 1;
            // 
            // tabChucDanh
            // 
            this.tabChucDanh.BackColor = System.Drawing.Color.Transparent;
            this.tabChucDanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabChucDanh.Controls.Add(this.btnLamMoi);
            this.tabChucDanh.Controls.Add(this.btnXoaCD);
            this.tabChucDanh.Controls.Add(this.btnSuaCD);
            this.tabChucDanh.Controls.Add(this.btnThemCD);
            this.tabChucDanh.Controls.Add(this.cboMaChucDanh);
            this.tabChucDanh.Controls.Add(this.panel1);
            this.tabChucDanh.Controls.Add(this.txtTenChucDanh);
            this.tabChucDanh.Controls.Add(this.txtLuongCoBan);
            this.tabChucDanh.Controls.Add(this.label3);
            this.tabChucDanh.Controls.Add(this.DgvCD);
            this.tabChucDanh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabChucDanh.Location = new System.Drawing.Point(4, 44);
            this.tabChucDanh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabChucDanh.Name = "tabChucDanh";
            this.tabChucDanh.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabChucDanh.Size = new System.Drawing.Size(1276, 674);
            this.tabChucDanh.TabIndex = 0;
            this.tabChucDanh.Text = "Chức danh";
            this.tabChucDanh.Click += new System.EventHandler(this.tabChucDanh_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 20;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(183)))));
            this.btnLamMoi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(913, 250);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(172, 55);
            this.btnLamMoi.TabIndex = 41;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // btnXoaCD
            // 
            this.btnXoaCD.BorderRadius = 20;
            this.btnXoaCD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaCD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaCD.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaCD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(183)))));
            this.btnXoaCD.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnXoaCD.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCD.ForeColor = System.Drawing.Color.White;
            this.btnXoaCD.Location = new System.Drawing.Point(689, 250);
            this.btnXoaCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaCD.Name = "btnXoaCD";
            this.btnXoaCD.Size = new System.Drawing.Size(172, 55);
            this.btnXoaCD.TabIndex = 40;
            this.btnXoaCD.Text = "Xóa";
            this.btnXoaCD.Click += new System.EventHandler(this.btnXoaCD_Click_1);
            // 
            // btnSuaCD
            // 
            this.btnSuaCD.BorderRadius = 20;
            this.btnSuaCD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaCD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaCD.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaCD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(183)))));
            this.btnSuaCD.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnSuaCD.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCD.ForeColor = System.Drawing.Color.White;
            this.btnSuaCD.Location = new System.Drawing.Point(464, 250);
            this.btnSuaCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaCD.Name = "btnSuaCD";
            this.btnSuaCD.Size = new System.Drawing.Size(172, 55);
            this.btnSuaCD.TabIndex = 39;
            this.btnSuaCD.Text = "Sửa";
            this.btnSuaCD.Click += new System.EventHandler(this.btnSuaCD_Click_1);
            // 
            // btnThemCD
            // 
            this.btnThemCD.BorderRadius = 20;
            this.btnThemCD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemCD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemCD.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemCD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(183)))));
            this.btnThemCD.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnThemCD.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCD.ForeColor = System.Drawing.Color.White;
            this.btnThemCD.Location = new System.Drawing.Point(244, 250);
            this.btnThemCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCD.Name = "btnThemCD";
            this.btnThemCD.Size = new System.Drawing.Size(172, 55);
            this.btnThemCD.TabIndex = 38;
            this.btnThemCD.Text = "Thêm";
            this.btnThemCD.Click += new System.EventHandler(this.btnThemCD_Click_1);
            // 
            // cboMaChucDanh
            // 
            this.cboMaChucDanh.FormattingEnabled = true;
            this.cboMaChucDanh.Location = new System.Drawing.Point(496, 105);
            this.cboMaChucDanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaChucDanh.Name = "cboMaChucDanh";
            this.cboMaChucDanh.Size = new System.Drawing.Size(310, 31);
            this.cboMaChucDanh.TabIndex = 35;
            this.cboMaChucDanh.SelectedIndexChanged += new System.EventHandler(this.cboMaChucDanh_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 52);
            this.panel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quản lý chức danh";
            // 
            // txtTenChucDanh
            // 
            this.txtTenChucDanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenChucDanh.Location = new System.Drawing.Point(496, 173);
            this.txtTenChucDanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenChucDanh.Multiline = true;
            this.txtTenChucDanh.Name = "txtTenChucDanh";
            this.txtTenChucDanh.Size = new System.Drawing.Size(310, 30);
            this.txtTenChucDanh.TabIndex = 23;
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.AutoSize = true;
            this.txtLuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCoBan.Location = new System.Drawing.Point(356, 177);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(124, 20);
            this.txtLuongCoBan.TabIndex = 22;
            this.txtLuongCoBan.Text = "Tên chức danh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã chức danh:";
            // 
            // DgvCD
            // 
            this.DgvCD.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TenChucDanh});
            this.DgvCD.GridColor = System.Drawing.Color.LightSeaGreen;
            this.DgvCD.Location = new System.Drawing.Point(43, 336);
            this.DgvCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvCD.Name = "DgvCD";
            this.DgvCD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DgvCD.RowTemplate.Height = 28;
            this.DgvCD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvCD.Size = new System.Drawing.Size(1143, 309);
            this.DgvCD.TabIndex = 0;
            this.DgvCD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCD_CellContentClick);
            this.DgvCD.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCD_CellMouseClick);
            this.DgvCD.SelectionChanged += new System.EventHandler(this.DgvCD_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Mã chức danh";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 300;
            // 
            // TenChucDanh
            // 
            this.TenChucDanh.DataPropertyName = "TenChucDanh";
            this.TenChucDanh.HeaderText = "Tên chức danh";
            this.TenChucDanh.MinimumWidth = 8;
            this.TenChucDanh.Name = "TenChucDanh";
            this.TenChucDanh.Width = 300;
            // 
            // tabCongTac
            // 
            this.tabCongTac.Controls.Add(this.btnMoi);
            this.tabCongTac.Controls.Add(this.btnXoa);
            this.tabCongTac.Controls.Add(this.btnSuaCT);
            this.tabCongTac.Controls.Add(this.btnThemCT);
            this.tabCongTac.Controls.Add(this.cboMaCongTac);
            this.tabCongTac.Controls.Add(this.txtTenCongTac);
            this.tabCongTac.Controls.Add(this.label4);
            this.tabCongTac.Controls.Add(this.label5);
            this.tabCongTac.Controls.Add(this.DGV_CongTac);
            this.tabCongTac.Controls.Add(this.panel2);
            this.tabCongTac.Location = new System.Drawing.Point(4, 44);
            this.tabCongTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCongTac.Name = "tabCongTac";
            this.tabCongTac.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCongTac.Size = new System.Drawing.Size(1276, 674);
            this.tabCongTac.TabIndex = 2;
            this.tabCongTac.Text = "Công tác";
            this.tabCongTac.UseVisualStyleBackColor = true;
            this.tabCongTac.Click += new System.EventHandler(this.tabCongTac_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.BorderRadius = 20;
            this.btnMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(183)))));
            this.btnMoi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnMoi.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.ForeColor = System.Drawing.Color.White;
            this.btnMoi.Location = new System.Drawing.Point(862, 219);
            this.btnMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(172, 55);
            this.btnMoi.TabIndex = 40;
            this.btnMoi.Text = "Làm mới";
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(183)))));
            this.btnXoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(647, 219);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(172, 55);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.BorderRadius = 20;
            this.btnSuaCT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaCT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaCT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaCT.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaCT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaCT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(183)))));
            this.btnSuaCT.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnSuaCT.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCT.ForeColor = System.Drawing.Color.White;
            this.btnSuaCT.Location = new System.Drawing.Point(436, 219);
            this.btnSuaCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(172, 55);
            this.btnSuaCT.TabIndex = 38;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click_1);
            // 
            // btnThemCT
            // 
            this.btnThemCT.BorderRadius = 20;
            this.btnThemCT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemCT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemCT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemCT.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemCT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemCT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(180)))), ((int)(((byte)(183)))));
            this.btnThemCT.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.btnThemCT.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCT.ForeColor = System.Drawing.Color.White;
            this.btnThemCT.Location = new System.Drawing.Point(224, 219);
            this.btnThemCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(172, 55);
            this.btnThemCT.TabIndex = 37;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // cboMaCongTac
            // 
            this.cboMaCongTac.FormattingEnabled = true;
            this.cboMaCongTac.Location = new System.Drawing.Point(520, 74);
            this.cboMaCongTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaCongTac.Name = "cboMaCongTac";
            this.cboMaCongTac.Size = new System.Drawing.Size(283, 31);
            this.cboMaCongTac.TabIndex = 34;
            // 
            // txtTenCongTac
            // 
            this.txtTenCongTac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenCongTac.Location = new System.Drawing.Point(520, 142);
            this.txtTenCongTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenCongTac.Multiline = true;
            this.txtTenCongTac.Name = "txtTenCongTac";
            this.txtTenCongTac.Size = new System.Drawing.Size(310, 30);
            this.txtTenCongTac.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tên công tác:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Mã công tác:";
            // 
            // DGV_CongTac
            // 
            this.DGV_CongTac.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_CongTac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_CongTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CongTac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCongTac,
            this.TenCongTac});
            this.DGV_CongTac.GridColor = System.Drawing.Color.LightSeaGreen;
            this.DGV_CongTac.Location = new System.Drawing.Point(67, 305);
            this.DGV_CongTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_CongTac.Name = "DGV_CongTac";
            this.DGV_CongTac.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DGV_CongTac.RowTemplate.Height = 28;
            this.DGV_CongTac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_CongTac.Size = new System.Drawing.Size(1143, 309);
            this.DGV_CongTac.TabIndex = 26;
            this.DGV_CongTac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGV_CongTac.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CongTac_CellMouseClick);
            this.DGV_CongTac.SelectionChanged += new System.EventHandler(this.DGV_CongTac_SelectionChanged);
            // 
            // MaCongTac
            // 
            this.MaCongTac.DataPropertyName = "Id";
            this.MaCongTac.HeaderText = "Mã công tác";
            this.MaCongTac.MinimumWidth = 8;
            this.MaCongTac.Name = "MaCongTac";
            this.MaCongTac.Width = 300;
            // 
            // TenCongTac
            // 
            this.TenCongTac.DataPropertyName = "TenCongTac";
            this.TenCongTac.HeaderText = "Tên công tác";
            this.TenCongTac.MinimumWidth = 8;
            this.TenCongTac.Name = "TenCongTac";
            this.TenCongTac.Width = 300;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(211)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1270, 52);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quản lý công tác";
            // 
            // BoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 722);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BoPhan";
            this.Text = "BoPhan";
            this.Load += new System.EventHandler(this.tabChucDanh_Click);
            this.tabControl1.ResumeLayout(false);
            this.tabChucDanh.ResumeLayout(false);
            this.tabChucDanh.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCD)).EndInit();
            this.tabCongTac.ResumeLayout(false);
            this.tabCongTac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CongTac)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChucDanh;
        private System.Windows.Forms.TabPage tabCongTac;
        private System.Windows.Forms.DataGridView DgvCD;
        private System.Windows.Forms.TextBox txtTenChucDanh;
        private System.Windows.Forms.Label txtLuongCoBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucDanh;
        private System.Windows.Forms.TextBox txtTenCongTac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV_CongTac;
        private System.Windows.Forms.ComboBox cboMaChucDanh;
        private System.Windows.Forms.ComboBox cboMaCongTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCongTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCongTac;
        private Guna.UI2.WinForms.Guna2GradientButton btnThemCT;
        private Guna.UI2.WinForms.Guna2GradientButton btnSuaCT;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnMoi;
        private Guna.UI2.WinForms.Guna2GradientButton btnThemCD;
        private Guna.UI2.WinForms.Guna2GradientButton btnSuaCD;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoaCD;
        private Guna.UI2.WinForms.Guna2GradientButton btnLamMoi;
    }
}