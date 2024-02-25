namespace Qlns
{
    partial class ThemCD
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenChucDanh = new System.Windows.Forms.TextBox();
            this.ThemChucD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Chức Danh";
            // 
            // txtTenChucDanh
            // 
            this.txtTenChucDanh.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtTenChucDanh.Location = new System.Drawing.Point(269, 122);
            this.txtTenChucDanh.MaximumSize = new System.Drawing.Size(250, 100);
            this.txtTenChucDanh.Name = "txtTenChucDanh";
            this.txtTenChucDanh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTenChucDanh.Size = new System.Drawing.Size(250, 26);
            this.txtTenChucDanh.TabIndex = 3;
            this.txtTenChucDanh.TextChanged += new System.EventHandler(this.TenChucDanh_TextChanged);
            // 
            // ThemChucD
            // 
            this.ThemChucD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.ThemChucD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThemChucD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemChucD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemChucD.ForeColor = System.Drawing.SystemColors.Control;
            this.ThemChucD.Location = new System.Drawing.Point(287, 203);
            this.ThemChucD.Name = "ThemChucD";
            this.ThemChucD.Size = new System.Drawing.Size(197, 48);
            this.ThemChucD.TabIndex = 4;
            this.ThemChucD.Text = "Thêm";
            this.ThemChucD.UseVisualStyleBackColor = false;
            this.ThemChucD.Click += new System.EventHandler(this.ThemChucD_Click);
            // 
            // ThemCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThemChucD);
            this.Controls.Add(this.txtTenChucDanh);
            this.Controls.Add(this.label2);
            this.Name = "ThemCD";
            this.Text = "ThemCD";
            this.Load += new System.EventHandler(this.ThemCD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ThemChucD;
        public System.Windows.Forms.TextBox txtTenChucDanh;
    }
}