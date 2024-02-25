using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Qlns.Provide
{
    internal class LuuAnh
    {
      public string KtraAnh(string DuongDan)
{
    try
    {
        if (!File.Exists(DuongDan))
        {
            MessageBox.Show("Tệp ảnh không tồn tại");
            return null; // Trả về null nếu tệp ảnh không tồn tại
        }

        // Lấy đường dẫn của thư mục chứa dự án
        string rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        // Xác định đường dẫn của thư mục lưu trữ ảnh (ví dụ: Images)
        string imageDirectory = Path.Combine(rootDirectory, "Image");

        // Kết hợp đường dẫn của thư mục ảnh với tên của ảnh
        string relativeImagePath = Path.Combine(imageDirectory, Path.GetFileName(DuongDan)); // Sử dụng Path.GetFileName để lấy tên tệp ảnh từ đường dẫn
/*
        MessageBox.Show(imageDirectory);
                MessageBox.Show(relativeImagePath);*/
        
                return relativeImagePath; // Trả về đường dẫn tương đối của tệp ảnh

    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi khi kiểm tra ảnh: " + ex.Message);
        return null;
    }
}

        public void LuuAnhMoi(string DuongDan)
        {
            try
            {

                // Lấy đường dẫn của thư mục chứa dự án
                string rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

                // Xác định đường dẫn của thư mục lưu trữ ảnh (ví dụ: Images)
                string imageDirectory = Path.Combine(rootDirectory, "Image");

                // Kết hợp đường dẫn của thư mục ảnh với tên của ảnh
                string relativeImagePath = Path.Combine(imageDirectory, Path.GetFileName(DuongDan)); // Sử dụng Path.GetFileName để lấy tên tệp ảnh từ đường dẫn
                                                                                                     // Sao chép tệp từ đường dẫn nguồn sang đường dẫn đích
                File.Copy(DuongDan, relativeImagePath, true);
                /*
                        MessageBox.Show(imageDirectory);
                                MessageBox.Show(relativeImagePath);*/


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra ảnh: " + ex.Message);
            }
        }
    }
}
