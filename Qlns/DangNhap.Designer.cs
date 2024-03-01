namespace Qlns
{
    partial class DangNhap
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
            this.Dd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.Tabheader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Min = new System.Windows.Forms.PictureBox();
            this.Restauran = new System.Windows.Forms.PictureBox();
            this.Max = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Tabheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restauran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Dd
            // 
            this.Dd.AutoSize = true;
            this.Dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dd.Location = new System.Drawing.Point(219, 75);
            this.Dd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dd.Name = "Dd";
            this.Dd.Size = new System.Drawing.Size(250, 29);
            this.Dd.TabIndex = 0;
            this.Dd.Text = "Đăng nhập tài khoản";
            this.Dd.Click += new System.EventHandler(this.Dd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDangNhap.Location = new System.Drawing.Point(181, 150);
            this.txtDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDangNhap.Multiline = true;
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(394, 42);
            this.txtDangNhap.TabIndex = 3;
            this.txtDangNhap.TextChanged += new System.EventHandler(this.txtDangNhap_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMatKhau.Location = new System.Drawing.Point(181, 216);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(394, 46);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(203)))), ((int)(((byte)(181)))));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDangNhap.Location = new System.Drawing.Point(354, 307);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(185, 63);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản trị viên"});
            this.cbRole.Location = new System.Drawing.Point(125, 327);
            this.cbRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(208, 28);
            this.cbRole.TabIndex = 6;
            // 
            // Tabheader
            // 
            this.Tabheader.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Tabheader.Controls.Add(this.pictureBox1);
            this.Tabheader.Controls.Add(this.Min);
            this.Tabheader.Controls.Add(this.Restauran);
            this.Tabheader.Controls.Add(this.Max);
            this.Tabheader.Controls.Add(this.Close);
            this.Tabheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tabheader.Location = new System.Drawing.Point(0, 0);
            this.Tabheader.Name = "Tabheader";
            this.Tabheader.Size = new System.Drawing.Size(726, 48);
            this.Tabheader.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Qlns.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Min
            // 
            this.Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Min.Image = global::Qlns.Properties.Resources.icon_minimizar;
            this.Min.Location = new System.Drawing.Point(589, 15);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(20, 19);
            this.Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Min.TabIndex = 4;
            this.Min.TabStop = false;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Restauran
            // 
            this.Restauran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restauran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restauran.Image = global::Qlns.Properties.Resources.icon_restaurar;
            this.Restauran.Location = new System.Drawing.Point(624, 15);
            this.Restauran.Name = "Restauran";
            this.Restauran.Size = new System.Drawing.Size(20, 19);
            this.Restauran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restauran.TabIndex = 3;
            this.Restauran.TabStop = false;
            this.Restauran.Click += new System.EventHandler(this.Restauran_Click);
            // 
            // Max
            // 
            this.Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Max.Image = global::Qlns.Properties.Resources.icon_maximizar;
            this.Max.Location = new System.Drawing.Point(659, 15);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(20, 19);
            this.Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Max.TabIndex = 2;
            this.Max.TabStop = false;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = global::Qlns.Properties.Resources.icon_cerrar2;
            this.Close.Location = new System.Drawing.Point(694, 15);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 19);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(726, 488);
            this.Controls.Add(this.Tabheader);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DangNhap";
            this.ShowIcon = false;
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.Tabheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restauran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Dd;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Panel Tabheader;
        private System.Windows.Forms.PictureBox Min;
        private System.Windows.Forms.PictureBox Restauran;
        private System.Windows.Forms.PictureBox Max;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}