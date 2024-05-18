using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using BCrypt.Net;

namespace PasswordManager
{
    public static class UserManagement
    {
        private static readonly string usersFilePath = "users.csv";

        public static void CreateUser(string username, string password)
        {
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            File.AppendAllLines(usersFilePath, new[] { $"{username},{hashedPassword}" });
        }

        public static bool ValidateUser(string username, string password)
        {
            if (!File.Exists(usersFilePath))
                return false;

            var lines = File.ReadAllLines(usersFilePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts[0] == username && BCrypt.Net.BCrypt.Verify(password, parts[1]))
                    return true;
            }

            return false;
        }
    }
}
