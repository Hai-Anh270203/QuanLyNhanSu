namespace Qlns
{
    partial class NV_KhenThuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NV_KhenThuong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBP = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGVkhen = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhenThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKhenThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVkhen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(136)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.btnBP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1906, 100);
            this.panel1.TabIndex = 162;
            // 
            // btnBP
            // 
            this.btnBP.FlatAppearance.BorderSize = 0;
            this.btnBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBP.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnBP.ForeColor = System.Drawing.Color.White;
            this.btnBP.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            this.btnBP.IconColor = System.Drawing.Color.White;
            this.btnBP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBP.IconSize = 34;
            this.btnBP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBP.Location = new System.Drawing.Point(34, 23);
            this.btnBP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBP.Name = "btnBP";
            this.btnBP.Padding = new System.Windows.Forms.Padding(12, 0, 18, 0);
            this.btnBP.Size = new System.Drawing.Size(581, 60);
            this.btnBP.TabIndex = 133;
            this.btnBP.Text = "Thông tin khen thưởng";
            this.btnBP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBP.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.DGVkhen);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Location = new System.Drawing.Point(34, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1894, 835);
            this.panel3.TabIndex = 163;
            // 
            // DGVkhen
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVkhen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(147)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(147)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVkhen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVkhen.ColumnHeadersHeight = 70;
            this.DGVkhen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVkhen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.MaKhenThuong,
            this.LoaiKhenThuong,
            this.TienThuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVkhen.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVkhen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVkhen.Location = new System.Drawing.Point(43, 128);
            this.DGVkhen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVkhen.Name = "DGVkhen";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVkhen.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVkhen.RowHeadersVisible = false;
            this.DGVkhen.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVkhen.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVkhen.RowTemplate.Height = 28;
            this.DGVkhen.Size = new System.Drawing.Size(1819, 640);
            this.DGVkhen.TabIndex = 126;
            this.DGVkhen.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVkhen.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVkhen.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVkhen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVkhen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVkhen.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVkhen.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVkhen.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVkhen.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVkhen.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVkhen.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVkhen.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVkhen.ThemeStyle.HeaderStyle.Height = 70;
            this.DGVkhen.ThemeStyle.ReadOnly = false;
            this.DGVkhen.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVkhen.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVkhen.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVkhen.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVkhen.ThemeStyle.RowsStyle.Height = 28;
            this.DGVkhen.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVkhen.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // MaKhenThuong
            // 
            this.MaKhenThuong.DataPropertyName = "Id";
            this.MaKhenThuong.HeaderText = "Mã khen thưởng";
            this.MaKhenThuong.MinimumWidth = 6;
            this.MaKhenThuong.Name = "MaKhenThuong";
            // 
            // LoaiKhenThuong
            // 
            this.LoaiKhenThuong.DataPropertyName = "KhenThuong";
            this.LoaiKhenThuong.HeaderText = "Loại k.thưởng";
            this.LoaiKhenThuong.MinimumWidth = 6;
            this.LoaiKhenThuong.Name = "LoaiKhenThuong";
            // 
            // TienThuong
            // 
            this.TienThuong.DataPropertyName = "Tien";
            this.TienThuong.HeaderText = "Tiền thưởng";
            this.TienThuong.MinimumWidth = 6;
            this.TienThuong.Name = "TienThuong";
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label23.Location = new System.Drawing.Point(37, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(328, 32);
            this.label23.TabIndex = 124;
            this.label23.Text = "Khen thưởng nhân viên";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(43, 78);
            this.label22.MaximumSize = new System.Drawing.Size(0, 2);
            this.label22.MinimumSize = new System.Drawing.Size(0, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1840, 2);
            this.label22.TabIndex = 125;
            this.label22.Text = resources.GetString("label22.Text");
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // NV_KhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1008);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NV_KhenThuong";
            this.Text = "NV_KhenThuong";
            this.Load += new System.EventHandler(this.NV_KhenThuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVkhen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBP;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView DGVkhen;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhenThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKhenThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienThuong;
    }
}