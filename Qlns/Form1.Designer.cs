using System.Runtime.CompilerServices;

namespace Qlns
{
    partial class Form1
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
            this.Vertical = new System.Windows.Forms.Panel();
            this.Admin = new System.Windows.Forms.Button();
            this.Tabheader = new System.Windows.Forms.Panel();
            this.Container = new System.Windows.Forms.Panel();
            this.Min = new System.Windows.Forms.PictureBox();
            this.Restauran = new System.Windows.Forms.PictureBox();
            this.Max = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Bar = new System.Windows.Forms.PictureBox();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.btnTracuu = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnbangluong = new System.Windows.Forms.Button();
            this.btnchamcong = new System.Windows.Forms.Button();
            this.btnbophan = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.Accout_img = new System.Windows.Forms.PictureBox();
            this.Logohome = new System.Windows.Forms.PictureBox();
            this.Vertical.SuspendLayout();
            this.Tabheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restauran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accout_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logohome)).BeginInit();
            this.SuspendLayout();
            // 
            // Vertical
            // 
            this.Vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Vertical.Controls.Add(this.btnHeThong);
            this.Vertical.Controls.Add(this.btnTracuu);
            this.Vertical.Controls.Add(this.btnBaocao);
            this.Vertical.Controls.Add(this.btnbangluong);
            this.Vertical.Controls.Add(this.btnchamcong);
            this.Vertical.Controls.Add(this.btnbophan);
            this.Vertical.Controls.Add(this.btnnhanvien);
            this.Vertical.Controls.Add(this.btnHome);
            this.Vertical.Controls.Add(this.Accout_img);
            this.Vertical.Controls.Add(this.Admin);
            this.Vertical.Controls.Add(this.Logohome);
            this.Vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.Vertical.Location = new System.Drawing.Point(0, 0);
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(275, 650);
            this.Vertical.TabIndex = 0;
            // 
            // Admin
            // 
            this.Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin.FlatAppearance.BorderSize = 5;
            this.Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Admin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admin.Location = new System.Drawing.Point(8, 99);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(262, 49);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.button1_Click);
            this.Admin.Resize += new System.EventHandler(this.button1_Resize);
            // 
            // Tabheader
            // 
            this.Tabheader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Tabheader.Controls.Add(this.Min);
            this.Tabheader.Controls.Add(this.Restauran);
            this.Tabheader.Controls.Add(this.Max);
            this.Tabheader.Controls.Add(this.Close);
            this.Tabheader.Controls.Add(this.Bar);
            this.Tabheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tabheader.Location = new System.Drawing.Point(275, 0);
            this.Tabheader.Name = "Tabheader";
            this.Tabheader.Size = new System.Drawing.Size(1025, 48);
            this.Tabheader.TabIndex = 1;
            this.Tabheader.Paint += new System.Windows.Forms.PaintEventHandler(this.Tabheader_Paint);
            this.Tabheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tabheader_MouseDown);
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(275, 48);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1025, 602);
            this.Container.TabIndex = 2;
            // 
            // Min
            // 
            this.Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Min.Image = global::Qlns.Properties.Resources.icon_minimizar;
            this.Min.Location = new System.Drawing.Point(888, 15);
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
            this.Restauran.Location = new System.Drawing.Point(923, 15);
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
            this.Max.Location = new System.Drawing.Point(958, 15);
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
            this.Close.Location = new System.Drawing.Point(993, 15);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 19);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Bar
            // 
            this.Bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bar.Image = global::Qlns.Properties.Resources.Mobile_Menu_Icon;
            this.Bar.Location = new System.Drawing.Point(12, 6);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(35, 33);
            this.Bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bar.TabIndex = 0;
            this.Bar.TabStop = false;
            this.Bar.Click += new System.EventHandler(this.Bar_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnHeThong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Times New Roman", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeThong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHeThong.Image = global::Qlns.Properties.Resources.producto;
            this.btnHeThong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.Location = new System.Drawing.Point(2, 578);
            this.btnHeThong.Margin = new System.Windows.Forms.Padding(8, 0, 35, 0);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(274, 50);
            this.btnHeThong.TabIndex = 11;
            this.btnHeThong.Text = "Hệ Thống";
            this.btnHeThong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHeThong.UseVisualStyleBackColor = true;
            // 
            // btnTracuu
            // 
            this.btnTracuu.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnTracuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTracuu.FlatAppearance.BorderSize = 0;
            this.btnTracuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnTracuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTracuu.Font = new System.Drawing.Font("Times New Roman", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTracuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTracuu.Image = global::Qlns.Properties.Resources.seach;
            this.btnTracuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTracuu.Location = new System.Drawing.Point(0, 518);
            this.btnTracuu.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTracuu.Name = "btnTracuu";
            this.btnTracuu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTracuu.Size = new System.Drawing.Size(274, 50);
            this.btnTracuu.TabIndex = 10;
            this.btnTracuu.Text = "Tra cứu thông tin";
            this.btnTracuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTracuu.UseVisualStyleBackColor = true;
            // 
            // btnBaocao
            // 
            this.btnBaocao.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnBaocao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaocao.FlatAppearance.BorderSize = 0;
            this.btnBaocao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnBaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaocao.Font = new System.Drawing.Font("Times New Roman", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaocao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaocao.Image = global::Qlns.Properties.Resources.chart1;
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.Location = new System.Drawing.Point(0, 454);
            this.btnBaocao.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBaocao.Size = new System.Drawing.Size(274, 50);
            this.btnBaocao.TabIndex = 9;
            this.btnBaocao.Text = "Báo cáo thống kê";
            this.btnBaocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaocao.UseVisualStyleBackColor = true;
            // 
            // btnbangluong
            // 
            this.btnbangluong.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnbangluong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbangluong.FlatAppearance.BorderSize = 0;
            this.btnbangluong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnbangluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbangluong.Font = new System.Drawing.Font("Times New Roman", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbangluong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbangluong.Image = global::Qlns.Properties.Resources.money;
            this.btnbangluong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbangluong.Location = new System.Drawing.Point(2, 390);
            this.btnbangluong.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnbangluong.Name = "btnbangluong";
            this.btnbangluong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnbangluong.Size = new System.Drawing.Size(274, 50);
            this.btnbangluong.TabIndex = 8;
            this.btnbangluong.Text = "Bảng lương";
            this.btnbangluong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbangluong.UseVisualStyleBackColor = true;
            // 
            // btnchamcong
            // 
            this.btnchamcong.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnchamcong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchamcong.FlatAppearance.BorderSize = 0;
            this.btnchamcong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnchamcong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchamcong.Font = new System.Drawing.Font("Times New Roman", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchamcong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnchamcong.Image = global::Qlns.Properties.Resources.check;
            this.btnchamcong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchamcong.Location = new System.Drawing.Point(0, 330);
            this.btnchamcong.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnchamcong.Name = "btnchamcong";
            this.btnchamcong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnchamcong.Size = new System.Drawing.Size(275, 50);
            this.btnchamcong.TabIndex = 7;
            this.btnchamcong.Text = "Chấm công";
            this.btnchamcong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnchamcong.UseVisualStyleBackColor = true;
            // 
            // btnbophan
            // 
            this.btnbophan.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnbophan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbophan.FlatAppearance.BorderSize = 0;
            this.btnbophan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnbophan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbophan.Font = new System.Drawing.Font("Times New Roman", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbophan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbophan.Image = global::Qlns.Properties.Resources.building;
            this.btnbophan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbophan.Location = new System.Drawing.Point(1, 269);
            this.btnbophan.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnbophan.Name = "btnbophan";
            this.btnbophan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnbophan.Size = new System.Drawing.Size(275, 50);
            this.btnbophan.TabIndex = 6;
            this.btnbophan.Text = "Bộ phận";
            this.btnbophan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbophan.UseVisualStyleBackColor = true;
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnnhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnhanvien.FlatAppearance.BorderSize = 0;
            this.btnnhanvien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnhanvien.Font = new System.Drawing.Font("Times New Roman", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhanvien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnhanvien.Image = global::Qlns.Properties.Resources.users;
            this.btnnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhanvien.Location = new System.Drawing.Point(0, 212);
            this.btnnhanvien.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnnhanvien.Size = new System.Drawing.Size(275, 50);
            this.btnnhanvien.TabIndex = 5;
            this.btnnhanvien.Text = "Nhân viên";
            this.btnnhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnhanvien.UseVisualStyleBackColor = true;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btnHome
            // 
            this.btnHome.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = global::Qlns.Properties.Resources.home2;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 159);
            this.btnHome.Margin = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(275, 50);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Accout_img
            // 
            this.Accout_img.BackColor = System.Drawing.Color.White;
            this.Accout_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Accout_img.Image = global::Qlns.Properties.Resources.boss_man_128;
            this.Accout_img.Location = new System.Drawing.Point(33, 108);
            this.Accout_img.Name = "Accout_img";
            this.Accout_img.Size = new System.Drawing.Size(34, 27);
            this.Accout_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Accout_img.TabIndex = 2;
            this.Accout_img.TabStop = false;
            this.Accout_img.Click += new System.EventHandler(this.Accout_img_Click);
            this.Accout_img.MouseLeave += new System.EventHandler(this.Accout_img_MouseLeave);
            this.Accout_img.MouseHover += new System.EventHandler(this.Accout_img_MouseHover_1);
            // 
            // Logohome
            // 
            this.Logohome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logohome.Image = global::Qlns.Properties.Resources.snapedit_1701178368437;
            this.Logohome.Location = new System.Drawing.Point(-9, 15);
            this.Logohome.Name = "Logohome";
            this.Logohome.Size = new System.Drawing.Size(265, 66);
            this.Logohome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logohome.TabIndex = 0;
            this.Logohome.TabStop = false;
            this.Logohome.Click += new System.EventHandler(this.Logohome_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.Tabheader);
            this.Controls.Add(this.Vertical);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Vertical.ResumeLayout(false);
            this.Tabheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restauran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accout_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logohome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel Vertical;
        private System.Windows.Forms.PictureBox Logohome;
        private System.Windows.Forms.Panel Tabheader;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.PictureBox Bar;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Max;
        private System.Windows.Forms.PictureBox Min;
        private System.Windows.Forms.PictureBox Restauran;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.PictureBox Accout_img;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnbophan;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button btnbangluong;
        private System.Windows.Forms.Button btnchamcong;
        //img
        private System.Windows.Forms.PictureBox Accout_img2;
        private System.Windows.Forms.Button btnTracuu;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnHeThong;
    }
}

