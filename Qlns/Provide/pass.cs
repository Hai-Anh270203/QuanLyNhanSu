using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Qlns.Provide
{
    internal class pass
    {
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Chuyển đổi mật khẩu thành mảng byte
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Tạo hash từ mật khẩu
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Chuyển đổi hash thành chuỗi hex
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

        // Hàm giải mã mật khẩu và kiểm tra tính hợp lệ
        public bool VerifyPassword(string password, string hashedPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Mã hóa mật khẩu nhập vào
                string hashedInput = HashPassword(password);

                // So sánh chuỗi hash mới tạo với chuỗi hash đã lưu
                return string.Equals(hashedInput, hashedPassword, StringComparison.OrdinalIgnoreCase);
            }
        }

    }
}
