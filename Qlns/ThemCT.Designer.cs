namespace Qlns
{
    partial class ThemCT
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
            this.ThemCongTac = new System.Windows.Forms.Button();
            this.txtTenCongTac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThemCongTac
            // 
            this.ThemCongTac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.ThemCongTac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThemCongTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemCongTac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemCongTac.ForeColor = System.Drawing.SystemColors.Control;
            this.ThemCongTac.Location = new System.Drawing.Point(287, 193);
            this.ThemCongTac.Name = "ThemCongTac";
            this.ThemCongTac.Size = new System.Drawing.Size(197, 48);
            this.ThemCongTac.TabIndex = 7;
            this.ThemCongTac.Text = "Thêm";
            this.ThemCongTac.UseVisualStyleBackColor = false;
            this.ThemCongTac.Click += new System.EventHandler(this.ThemCongTac_Click);
            // 
            // txtTenCongTac
            // 
            this.txtTenCongTac.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtTenCongTac.Location = new System.Drawing.Point(269, 112);
            this.txtTenCongTac.MaximumSize = new System.Drawing.Size(250, 100);
            this.txtTenCongTac.Name = "txtTenCongTac";
            this.txtTenCongTac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTenCongTac.Size = new System.Drawing.Size(250, 26);
            this.txtTenCongTac.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên công tác";
            // 
            // ThemCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 353);
            this.Controls.Add(this.ThemCongTac);
            this.Controls.Add(this.txtTenCongTac);
            this.Controls.Add(this.label2);
            this.Name = "ThemCT";
            this.Text = "ThemCT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ThemCongTac;
        public System.Windows.Forms.TextBox txtTenCongTac;
        private System.Windows.Forms.Label label2;
    }
}