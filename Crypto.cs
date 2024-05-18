using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManager
{
    public class Crypto
    {
        private static readonly string key = "raktas"; 

        public static byte[] generateValidKey(string key)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(key);
                byte[] hashedBytes = sha256.ComputeHash(inputBytes);

                Array.Resize(ref hashedBytes, 16);

                return hashedBytes;
            }
        }

        public static void EncryptFile(string filePath)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = generateValidKey(key);
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                using (CryptoStream cs = new CryptoStream(new FileStream(filePath + ".enc", FileMode.Create), aes.CreateEncryptor(), CryptoStreamMode.Write))
                using (FileStream fsIn = new FileStream(filePath, FileMode.Open))
                {
                    byte[] buffer = new byte[1048576];
                    int read;
                    while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        cs.Write(buffer, 0, read);
                    }
                }
            }
            File.Delete(filePath);
        }

        public static void DecryptFile(string filePath)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = generateValidKey(key);
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                using (CryptoStream cs = new CryptoStream(new FileStream(filePath.Replace(".enc", ""), FileMode.Create), aes.CreateDecryptor(), CryptoStreamMode.Write))
                using (FileStream fsCrypt = new FileStream(filePath, FileMode.Open))
                {
                    byte[] buffer = new byte[1048576];
                    int read;
                    while ((read = fsCrypt.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        cs.Write(buffer, 0, read);
                    }
                }
            }
            File.Delete(filePath);
        }

    }
}
