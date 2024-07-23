namespace Qlns
{
    partial class GiaodienNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaodienNV));
            this.Container = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.daidien = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ten = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.anh = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnNV = new FontAwesome.Sharp.IconButton();
            this.btnTongluong = new FontAwesome.Sharp.IconButton();
            this.btnCC = new FontAwesome.Sharp.IconButton();
            this.btnKhenThuong = new FontAwesome.Sharp.IconButton();
            this.btnKiLuat = new FontAwesome.Sharp.IconButton();
            this.txtDuongDan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daidien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Container.BackColor = System.Drawing.Color.White;
            this.Container.Cursor = System.Windows.Forms.Cursors.Default;
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(463, 148);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1479, 954);
            this.Container.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.daidien);
            this.guna2Panel2.Controls.Add(this.btnMin);
            this.guna2Panel2.Controls.Add(this.btnMax);
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(463, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1479, 148);
            this.guna2Panel2.TabIndex = 4;
            // 
            // daidien
            // 
            this.daidien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.daidien.Image = ((System.Drawing.Image)(resources.GetObject("daidien.Image")));
            this.daidien.ImageRotate = 0F;
            this.daidien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.daidien.Location = new System.Drawing.Point(1242, 33);
            this.daidien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daidien.Name = "daidien";
            this.daidien.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.daidien.Size = new System.Drawing.Size(96, 87);
            this.daidien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.daidien.TabIndex = 29;
            this.daidien.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::Qlns.Properties.Resources.icon_minimizar;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(1378, 11);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(18, 18);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 26;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = global::Qlns.Properties.Resources.icon_restaurar;
            this.btnMax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMax.Location = new System.Drawing.Point(1414, 11);
            this.btnMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(18, 18);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 25;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::Qlns.Properties.Resources.icon_cerrar2;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(1448, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 18);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 24;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(147)))), ((int)(((byte)(29)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnNV);
            this.panelMenu.Controls.Add(this.btnTongluong);
            this.panelMenu.Controls.Add(this.btnCC);
            this.panelMenu.Controls.Add(this.btnKhenThuong);
            this.panelMenu.Controls.Add(this.btnKiLuat);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(463, 1102);
            this.panelMenu.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 38;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogout.Location = new System.Drawing.Point(0, 1021);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(12, 0, 18, 0);
            this.btnLogout.Size = new System.Drawing.Size(463, 79);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ten);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.anh);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 188);
            this.panel1.TabIndex = 17;
            // 
            // ten
            // 
            this.ten.BackColor = System.Drawing.Color.Transparent;
            this.ten.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.ForeColor = System.Drawing.Color.White;
            this.ten.Location = new System.Drawing.Point(212, 73);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(136, 34);
            this.ten.TabIndex = 14;
            this.ten.Text = "Họ và Tên ";
            this.ten.Click += new System.EventHandler(this.ten_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(220, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "96,9k Follow";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // anh
            // 
            this.anh.Image = ((System.Drawing.Image)(resources.GetObject("anh.Image")));
            this.anh.ImageRotate = 0F;
            this.anh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.anh.Location = new System.Drawing.Point(52, 40);
            this.anh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anh.Name = "anh";
            this.anh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.anh.Size = new System.Drawing.Size(133, 125);
            this.anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anh.TabIndex = 0;
            this.anh.TabStop = false;
            this.anh.Click += new System.EventHandler(this.anh_Click);
            // 
            // btnNV
            // 
            this.btnNV.FlatAppearance.BorderSize = 0;
            this.btnNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNV.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnNV.ForeColor = System.Drawing.Color.White;
            this.btnNV.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btnNV.IconColor = System.Drawing.Color.White;
            this.btnNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNV.IconSize = 38;
            this.btnNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNV.Location = new System.Drawing.Point(0, 242);
            this.btnNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNV.Name = "btnNV";
            this.btnNV.Padding = new System.Windows.Forms.Padding(12, 0, 18, 0);
            this.btnNV.Size = new System.Drawing.Size(463, 79);
            this.btnNV.TabIndex = 16;
            this.btnNV.Text = "Thông tin cá nhân ";
            this.btnNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNV.UseVisualStyleBackColor = true;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnTongluong
            // 
            this.btnTongluong.FlatAppearance.BorderSize = 0;
            this.btnTongluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongluong.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnTongluong.ForeColor = System.Drawing.Color.White;
            this.btnTongluong.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnTongluong.IconColor = System.Drawing.Color.White;
            this.btnTongluong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTongluong.IconSize = 38;
            this.btnTongluong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongluong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTongluong.Location = new System.Drawing.Point(0, 408);
            this.btnTongluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTongluong.Name = "btnTongluong";
            this.btnTongluong.Padding = new System.Windows.Forms.Padding(12, 0, 18, 0);
            this.btnTongluong.Size = new System.Drawing.Size(463, 79);
            this.btnTongluong.TabIndex = 15;
            this.btnTongluong.Text = "Tổng lương";
            this.btnTongluong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTongluong.UseVisualStyleBackColor = true;
            this.btnTongluong.Click += new System.EventHandler(this.btnTongluong_Click);
            // 
            // btnCC
            // 
            this.btnCC.FlatAppearance.BorderSize = 0;
            this.btnCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCC.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnCC.ForeColor = System.Drawing.Color.White;
            this.btnCC.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnCC.IconColor = System.Drawing.Color.White;
            this.btnCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCC.IconSize = 38;
            this.btnCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCC.Location = new System.Drawing.Point(3, 325);
            this.btnCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCC.Name = "btnCC";
            this.btnCC.Padding = new System.Windows.Forms.Padding(12, 0, 18, 0);
            this.btnCC.Size = new System.Drawing.Size(460, 79);
            this.btnCC.TabIndex = 11;
            this.btnCC.Text = "Chấm công";
            this.btnCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCC.UseVisualStyleBackColor = true;
            this.btnCC.Click += new System.EventHandler(this.btnCC_Click);
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.FlatAppearance.BorderSize = 0;
            this.btnKhenThuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhenThuong.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnKhenThuong.ForeColor = System.Drawing.Color.White;
            this.btnKhenThuong.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            this.btnKhenThuong.IconColor = System.Drawing.Color.White;
            this.btnKhenThuong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhenThuong.IconSize = 38;
            this.btnKhenThuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhenThuong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKhenThuong.Location = new System.Drawing.Point(0, 491);
            this.btnKhenThuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.Padding = new System.Windows.Forms.Padding(12, 0, 18, 0);
            this.btnKhenThuong.Size = new System.Drawing.Size(463, 79);
            this.btnKhenThuong.TabIndex = 12;
            this.btnKhenThuong.Text = "Khen thưởng";
            this.btnKhenThuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhenThuong.UseVisualStyleBackColor = true;
            this.btnKhenThuong.Click += new System.EventHandler(this.btnKhenThuong_Click);
            // 
            // btnKiLuat
            // 
            this.btnKiLuat.FlatAppearance.BorderSize = 0;
            this.btnKiLuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiLuat.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnKiLuat.ForeColor = System.Drawing.Color.White;
            this.btnKiLuat.IconChar = FontAwesome.Sharp.IconChar.Award;
            this.btnKiLuat.IconColor = System.Drawing.Color.White;
            this.btnKiLuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKiLuat.IconSize = 38;
            this.btnKiLuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiLuat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKiLuat.Location = new System.Drawing.Point(0, 574);
            this.btnKiLuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKiLuat.Name = "btnKiLuat";
            this.btnKiLuat.Padding = new System.Windows.Forms.Padding(12, 0, 18, 0);
            this.btnKiLuat.Size = new System.Drawing.Size(463, 79);
            this.btnKiLuat.TabIndex = 13;
            this.btnKiLuat.Text = "Kỉ luật";
            this.btnKiLuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKiLuat.UseVisualStyleBackColor = true;
            this.btnKiLuat.Click += new System.EventHandler(this.btnKiLuat_Click_1);
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDuongDan.DefaultText = "";
            this.txtDuongDan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDuongDan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDuongDan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuongDan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuongDan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDuongDan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDuongDan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDuongDan.Location = new System.Drawing.Point(1641, 307);
            this.txtDuongDan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.PasswordChar = '\0';
            this.txtDuongDan.PlaceholderText = "";
            this.txtDuongDan.SelectedText = "";
            this.txtDuongDan.Size = new System.Drawing.Size(229, 30);
            this.txtDuongDan.TabIndex = 6;
            // 
            // GiaodienNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.txtDuongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiaodienNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaodienNV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GiaodienNV_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daidien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Container;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox anh;
        private FontAwesome.Sharp.IconButton btnNV;
        private FontAwesome.Sharp.IconButton btnTongluong;
        private FontAwesome.Sharp.IconButton btnCC;
        private FontAwesome.Sharp.IconButton btnKhenThuong;
        private FontAwesome.Sharp.IconButton btnKiLuat;
        private Guna.UI2.WinForms.Guna2CirclePictureBox daidien;
        private Guna.UI2.WinForms.Guna2TextBox txtDuongDan;
        private Guna.UI2.WinForms.Guna2HtmlLabel ten;
    }
}