using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace PasswordManager.Forms
{
    public partial class MainForm : Form
    {
        private string username;
        private string filePath;
        private string passwordCopy;
        private readonly string key = "raktas";

        public MainForm(string username)
        {
            InitializeComponent();
            this.username = username;
            filePath = $"UserCSV\\{username}.csv";
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                var data = lines.Select(line => line.Split(',')).Select(parts => new { Name = parts[0], Password = parts[1], URL = parts[2], Comment = parts[3] });
                dataGridView1.DataSource = data.ToList();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Crypto.EncryptFile(filePath);
        }

        private void DecryptPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DecryptPasswordBox.Checked)
            {
                string decryptedPassword = DecryptStringAES(txtPassword.Text);
                txtPassword.Text = decryptedPassword;
                btnCopyToClipboard.Visible = true;
            }
            else
            {
                txtPassword.Text = passwordCopy;
                btnCopyToClipboard.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string encryptedPassword = EncryptStringAES(txtPassword.Text);
            var entry = $"{txtName.Text},{encryptedPassword},{txtURL.Text},{txtComment.Text}";
            File.AppendAllLines(filePath, new[] { entry });
            LoadData();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtURL.Clear();
            txtComment.Clear();
            DecryptPasswordBox.Visible = false;
            btnCopyToClipboard.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtPassword.Text = selectedRow.Cells["Password"].Value.ToString();
                txtURL.Text = selectedRow.Cells["URL"].Value.ToString();
                txtComment.Text = selectedRow.Cells["Comment"].Value.ToString();
                passwordCopy = txtPassword.Text;
            }

            DecryptPasswordBox.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private string EncryptStringAES(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException(nameof(plainText));

            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = generateValidKey(key);
                aesAlg.Mode = CipherMode.ECB;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }

        private string DecryptStringAES(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException(nameof(cipherText));

            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = generateValidKey(key);
                aesAlg.Mode = CipherMode.ECB;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (!string.IsNullOrEmpty(password))
            {
                Clipboard.SetText(password);
                MessageBox.Show("Password copied to clipboard!");
            }
            else
            {
                MessageBox.Show("Password is empty, not able to copy.");
            }
        }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filePath);

            string entryToDelete = txtName.Text;

            List<string> updatedLines = new List<string>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length >= 4 && parts[0] != entryToDelete)
                {
                    updatedLines.Add(line);
                }
            }
            File.WriteAllLines(filePath, updatedLines.ToArray());
            LoadData();
            ClearInputs();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string generatedPassword = GenerateRandomPassword(12);

            txtPassword.Text = generatedPassword;
        }

        private string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_-+=";
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(validChars.Length);
                sb.Append(validChars[index]);
            }

            return sb.ToString();
        }
    }
}
