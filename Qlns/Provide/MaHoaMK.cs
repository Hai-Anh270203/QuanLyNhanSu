using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Qlns.Provide
{
    internal class MaHoaMK
    {
      
            private const int SaltSize = 16; // Kích thước muối
            private const int HashSize = 20; // Kích thước hash
            private const int Iterations = 10000; // Số lần lặp để tạo salt

            public  string HashPassword(string password)
            {
                // Tạo salt ngẫu nhiên
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

                // Tạo hash từ mật khẩu và salt
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
                byte[] hash = pbkdf2.GetBytes(HashSize);

                // Kết hợp salt và hash
                byte[] hashBytes = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                // Chuyển đổi thành chuỗi hex
                string hashedPassword = Convert.ToBase64String(hashBytes);

                return hashedPassword;
            }

            public  bool GiaiMa(string password, string hashedPassword)
            {
                // Lấy salt từ chuỗi hash đã lưu
                byte[] hashBytes = Convert.FromBase64String(hashedPassword);
                byte[] salt = new byte[SaltSize];
                Array.Copy(hashBytes, 0, salt, 0, SaltSize);

                // Tạo hash từ mật khẩu nhập và salt
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
                byte[] hash = pbkdf2.GetBytes(HashSize);

                // So sánh hash mới với hash đã lưu
                for (int i = 0; i < HashSize; i++)
                {
                    if (hashBytes[i + SaltSize] != hash[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }

