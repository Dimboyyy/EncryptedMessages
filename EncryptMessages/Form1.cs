using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EncryptMessages
{
    public partial class Form1 : Form
    {
        private List<Form> messageForms;
        private byte[] key;
        private byte[] iv;

        public Form1()
        {
            InitializeComponent();
            messageForms = new List<Form>();

            // Gerar a chave e o IV
            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                aes.GenerateIV();
                key = aes.Key;
                iv = aes.IV;
            }
        }

        private byte[] GenerateKeyFromPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                return sha256.ComputeHash(passwordBytes);
            }
        }



        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            if (key.Length >= 100)
            {
                MessageBox.Show("A chave deve ter no máximo 100 caracteres.", "Erro de Chave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] keyBytes = GenerateKeyFromPassword(key);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(txtToEncrypt.Text);
                    byte[] ciphertextBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);

                    txtEncrypted.Text = BitConverter.ToString(ciphertextBytes).Replace("-", "");
                }
            }

            // Limpar os campos
            txtKey.Text = string.Empty;
            txtDecrypted.Text = string.Empty;
            txtToEncrypt.Text = string.Empty;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            if (key.Length >= 100)
            {
                MessageBox.Show("A chave deve ter no máximo 100 caracteres.", "Erro de Chave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] keyBytes = GenerateKeyFromPassword(key);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    try
                    {
                        byte[] ciphertextBytes = HexStringToByteArray(txtEncrypted.Text);
                        byte[] decryptedBytes = decryptor.TransformFinalBlock(ciphertextBytes, 0, ciphertextBytes.Length);

                        txtDecrypted.Text = Encoding.UTF8.GetString(decryptedBytes);

                        // Limpar os campos txtEncrypted e txtKey
                        txtEncrypted.Text = string.Empty;
                        txtKey.Text = string.Empty;

                        // Fechar todas as janelas de aviso
                        CloseAllMessageForms();
                    }
                    catch (CryptographicException)
                    {
                        ShowDecryptionWarningMessage();
                    }
                }
            }
        }

        private void ShowDecryptionWarningMessage()
        {
            string message = "SEU PC VAI EXPLODIR EM 1 MINUTO CASO NÃO INSIRA A KEY CORRETA.";
            string caption = "Important";

            // Exibir a mensagem de aviso em diferentes idiomas usando MessageBox
            if (System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "pt")
            {
                message = "SEU PC VAI EXPLODIR EM 1 MINUTO CASO NÃO INSIRA A KEY CORRETA.";
            }
            else if (System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "es")
            {
                message = "SEU PC VAI EXPLODIR EM 1 MINUTO CASO NÃO INSIRA A KEY CORRETA.";
            }
            else if (System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
            {
                message = "SEU PC VAI EXPLODIR EM 1 MINUTO CASO NÃO INSIRA A KEY CORRETA.";
            }

            for (int i = 0; i < 150; i++)
            {
                Form messageForm = new Form();
                messageForm.Text = caption;
                messageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                messageForm.StartPosition = FormStartPosition.Manual;
                messageForm.ShowInTaskbar = false;
                messageForm.Size = new Size(300, 150);
                messageForm.Location = GetRandomLocation();

                Label label = new Label();
                label.Text = message;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                messageForm.Controls.Add(label);

                messageForms.Add(messageForm);
                messageForm.Show();
            }
        }

        private void CloseAllMessageForms()
        {
            foreach (Form messageForm in messageForms)
            {
                messageForm.Close();
            }
            messageForms.Clear();
        }

        // Método auxiliar para converter uma string hexadecimal em um array de bytes
        private byte[] HexStringToByteArray(string hexString)
        {
            hexString = hexString.Replace("-", "");

            int byteCount = hexString.Length / 2;
            byte[] byteArray = new byte[byteCount];
            for (int i = 0; i < byteCount; i++)
            {
                string byteValue = hexString.Substring(i * 2, 2);
                byteArray[i] = Convert.ToByte(byteValue, 16);
            }
            return byteArray;
        }

        // Método auxiliar para obter uma localização aleatória na tela
        private Point GetRandomLocation()
        {
            Random random = new Random();
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = 300;
            int formHeight = 150;
            int x = random.Next(screenWidth - formWidth);
            int y = random.Next(screenHeight - formHeight);
            return new Point(x, y);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEncrypted.Text))
            {
                Clipboard.SetText(txtEncrypted.Text);
            }
        }
        private void lbKey_Click(object sender, EventArgs e)
        {

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbToEncrypt_Click(object sender, EventArgs e)
        {

        }

        private void txtToEncrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEncrypted_Click(object sender, EventArgs e)
        {

        }

        private void txtEncrypted_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
