﻿using Qlns.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Home ve = new Home(); // Tạo một thể hiện mới của form DNAdmin
            ve.Show(); // Hiển thị form DNAdmin mà không chặn form hiện tại
            this.Hide(); // Ẩn form hiện tại thay vì đóng nó
        }
    }
}
