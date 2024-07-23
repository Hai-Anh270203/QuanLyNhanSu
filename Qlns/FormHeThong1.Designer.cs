
namespace Qlns
{
    partial class FormHeThong1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbQuyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXacNhanMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMk = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtMaNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBP = new FontAwesome.Sharp.IconButton();
            this.DGVHeThong = new System.Windows.Forms.DataGridView();
            this.IdUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Them = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Xoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Sua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnNhapLai = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHeThong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CbQuyen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtXacNhanMK);
            this.panel2.Controls.Add(this.txtMk);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.txtMaNhanVien);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(152, 177);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1495, 354);
            this.panel2.TabIndex = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(829, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 19);
            this.label6.TabIndex = 174;
            this.label6.Text = "Xác minh mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(829, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 173;
            this.label7.Text = "Mật khẩu";
            // 
            // CbQuyen
            // 
            this.CbQuyen.BackColor = System.Drawing.Color.Transparent;
            this.CbQuyen.BorderRadius = 4;
            this.CbQuyen.BorderThickness = 2;
            this.CbQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbQuyen.FocusedColor = System.Drawing.Color.Silver;
            this.CbQuyen.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.CbQuyen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbQuyen.ForeColor = System.Drawing.Color.Black;
            this.CbQuyen.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.CbQuyen.HoverState.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbQuyen.ItemHeight = 30;
            this.CbQuyen.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CbQuyen.Location = new System.Drawing.Point(629, 271);
            this.CbQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbQuyen.Name = "CbQuyen";
            this.CbQuyen.Size = new System.Drawing.Size(207, 36);
            this.CbQuyen.TabIndex = 172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(539, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 171;
            this.label1.Text = "Quyền";
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.BorderRadius = 4;
            this.txtXacNhanMK.BorderThickness = 2;
            this.txtXacNhanMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacNhanMK.DefaultText = "";
            this.txtXacNhanMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXacNhanMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXacNhanMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacNhanMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacNhanMK.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.txtXacNhanMK.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMK.ForeColor = System.Drawing.Color.Black;
            this.txtXacNhanMK.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtXacNhanMK.Location = new System.Drawing.Point(1064, 171);
            this.txtXacNhanMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.PasswordChar = '\0';
            this.txtXacNhanMK.PlaceholderText = "";
            this.txtXacNhanMK.SelectedText = "";
            this.txtXacNhanMK.Size = new System.Drawing.Size(225, 50);
            this.txtXacNhanMK.TabIndex = 170;
            // 
            // txtMk
            // 
            this.txtMk.BorderRadius = 4;
            this.txtMk.BorderThickness = 2;
            this.txtMk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMk.DefaultText = "";
            this.txtMk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMk.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.txtMk.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk.ForeColor = System.Drawing.Color.Black;
            this.txtMk.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtMk.Location = new System.Drawing.Point(1064, 96);
            this.txtMk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMk.Name = "txtMk";
            this.txtMk.PasswordChar = '\0';
            this.txtMk.PlaceholderText = "";
            this.txtMk.SelectedText = "";
            this.txtMk.Size = new System.Drawing.Size(225, 50);
            this.txtMk.TabIndex = 169;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderRadius = 4;
            this.txtHoTen.BorderThickness = 2;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtHoTen.Location = new System.Drawing.Point(295, 171);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(225, 50);
            this.txtHoTen.TabIndex = 168;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(43, 22);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 39);
            this.iconPictureBox1.TabIndex = 167;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderRadius = 4;
            this.txtMaNhanVien.BorderThickness = 2;
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.DefaultText = "";
            this.txtMaNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtMaNhanVien.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtMaNhanVien.Location = new System.Drawing.Point(295, 96);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PasswordChar = '\0';
            this.txtMaNhanVien.PlaceholderText = "";
            this.txtMaNhanVien.SelectedText = "";
            this.txtMaNhanVien.Size = new System.Drawing.Size(225, 50);
            this.txtMaNhanVien.TabIndex = 166;
            this.txtMaNhanVien.TextChanged += new System.EventHandler(this.txtMaNhanVien_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(27, 65);
            this.label11.MaximumSize = new System.Drawing.Size(0, 2);
            this.label11.MinimumSize = new System.Drawing.Size(0, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1101, 2);
            this.label11.TabIndex = 36;
            this.label11.Text = "555555555555555555555555555555555555555555555555555555555555555555555555555555555" +
    "555555555555555555555555555555555555555555555555555555555555555555555555555";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(106, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = "Quyền đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(133, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(133, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.btnBP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1800, 100);
            this.panel1.TabIndex = 149;
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
            this.btnBP.Location = new System.Drawing.Point(38, 11);
            this.btnBP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBP.Name = "btnBP";
            this.btnBP.Padding = new System.Windows.Forms.Padding(12, 0, 19, 0);
            this.btnBP.Size = new System.Drawing.Size(425, 60);
            this.btnBP.TabIndex = 133;
            this.btnBP.Text = "   Hệ thống";
            this.btnBP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBP.UseVisualStyleBackColor = true;
            // 
            // DGVHeThong
            // 
            this.DGVHeThong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVHeThong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVHeThong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DGVHeThong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVHeThong.BackgroundColor = System.Drawing.Color.White;
            this.DGVHeThong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVHeThong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVHeThong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(52)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(52)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHeThong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVHeThong.ColumnHeadersHeight = 60;
            this.DGVHeThong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUserRole,
            this.IdUser,
            this.Role,
            this.HoTen,
            this.MaNhanVien,
            this.MatKhau});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVHeThong.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVHeThong.EnableHeadersVisualStyles = false;
            this.DGVHeThong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVHeThong.Location = new System.Drawing.Point(168, 619);
            this.DGVHeThong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVHeThong.Name = "DGVHeThong";
            this.DGVHeThong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHeThong.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVHeThong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVHeThong.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVHeThong.RowTemplate.Height = 28;
            this.DGVHeThong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVHeThong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVHeThong.Size = new System.Drawing.Size(1451, 281);
            this.DGVHeThong.TabIndex = 151;
            this.DGVHeThong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHeThong_CellClick);
            // 
            // IdUserRole
            // 
            this.IdUserRole.DataPropertyName = "IdUserRole";
            this.IdUserRole.HeaderText = "IdUserRole";
            this.IdUserRole.MinimumWidth = 6;
            this.IdUserRole.Name = "IdUserRole";
            // 
            // IdUser
            // 
            this.IdUser.DataPropertyName = "IdUser";
            this.IdUser.HeaderText = "ID User";
            this.IdUser.MinimumWidth = 6;
            this.IdUser.Name = "IdUser";
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Quyền tài khoản";
            this.Role.MinimumWidth = 8;
            this.Role.Name = "Role";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên chủ tài khoản";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Tài khoản";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu được mã hóa";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 300;
            // 
            // Them
            // 
            this.Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Them.BorderRadius = 25;
            this.Them.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Them.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Them.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.Them.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.Them.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Them.ForeColor = System.Drawing.Color.White;
            this.Them.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.Them.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.Them.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Them.IndicateFocus = true;
            this.Them.Location = new System.Drawing.Point(309, 954);
            this.Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Them.Name = "Them";
            this.Them.ShadowDecoration.BorderRadius = 5;
            this.Them.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.Them.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.Them.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.Them.ShadowDecoration.Depth = 5;
            this.Them.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Them.Size = new System.Drawing.Size(251, 76);
            this.Them.TabIndex = 152;
            this.Them.Text = "Thêm hệ thống";
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Xoa
            // 
            this.Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Xoa.BorderRadius = 25;
            this.Xoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Xoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Xoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.Xoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.Xoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Xoa.ForeColor = System.Drawing.Color.White;
            this.Xoa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.Xoa.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.Xoa.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Xoa.IndicateFocus = true;
            this.Xoa.Location = new System.Drawing.Point(604, 954);
            this.Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Xoa.Name = "Xoa";
            this.Xoa.ShadowDecoration.BorderRadius = 5;
            this.Xoa.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.Xoa.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.Xoa.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.Xoa.ShadowDecoration.Depth = 5;
            this.Xoa.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Xoa.Size = new System.Drawing.Size(251, 76);
            this.Xoa.TabIndex = 153;
            this.Xoa.Text = "Xóa hệ thống";
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sua.BorderRadius = 25;
            this.Sua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Sua.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Sua.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Sua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.Sua.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.Sua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Sua.ForeColor = System.Drawing.Color.White;
            this.Sua.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.Sua.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.Sua.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Sua.IndicateFocus = true;
            this.Sua.Location = new System.Drawing.Point(921, 954);
            this.Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sua.Name = "Sua";
            this.Sua.ShadowDecoration.BorderRadius = 5;
            this.Sua.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.Sua.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.Sua.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.Sua.ShadowDecoration.Depth = 5;
            this.Sua.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Sua.Size = new System.Drawing.Size(251, 76);
            this.Sua.TabIndex = 154;
            this.Sua.Text = "Sửa hệ thống";
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // BtnNhapLai
            // 
            this.BtnNhapLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnNhapLai.BorderRadius = 25;
            this.BtnNhapLai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNhapLai.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNhapLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNhapLai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNhapLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNhapLai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.BtnNhapLai.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.BtnNhapLai.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnNhapLai.ForeColor = System.Drawing.Color.White;
            this.BtnNhapLai.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(81)))), ((int)(((byte)(250)))));
            this.BtnNhapLai.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.BtnNhapLai.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNhapLai.IndicateFocus = true;
            this.BtnNhapLai.Location = new System.Drawing.Point(1220, 954);
            this.BtnNhapLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNhapLai.Name = "BtnNhapLai";
            this.BtnNhapLai.ShadowDecoration.BorderRadius = 5;
            this.BtnNhapLai.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.BtnNhapLai.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.BtnNhapLai.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.BtnNhapLai.ShadowDecoration.Depth = 5;
            this.BtnNhapLai.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.BtnNhapLai.Size = new System.Drawing.Size(251, 76);
            this.BtnNhapLai.TabIndex = 155;
            this.BtnNhapLai.Text = "Làm mới";
            this.BtnNhapLai.Click += new System.EventHandler(this.BtnNhapLai_Click);
            // 
            // FormHeThong1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1102);
            this.Controls.Add(this.BtnNhapLai);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.DGVHeThong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHeThong1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHeThong1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHeThong1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHeThong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtXacNhanMK;
        private Guna.UI2.WinForms.Guna2TextBox txtMk;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBP;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox CbQuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVHeThong;
        private Guna.UI2.WinForms.Guna2GradientButton Them;
        private Guna.UI2.WinForms.Guna2GradientButton Xoa;
        private Guna.UI2.WinForms.Guna2GradientButton Sua;
        private Guna.UI2.WinForms.Guna2GradientButton BtnNhapLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
    }
}