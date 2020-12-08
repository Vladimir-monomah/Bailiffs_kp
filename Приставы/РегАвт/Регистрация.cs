using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Приставы.РегАвт
{
    public partial class Регистрация : Form
    {
        private string password;

        public Регистрация(string password)
        {
            this.password = password;
            this.InitializeComponent();
        }

        public static string Encrypt(string plainText, string password, string salt = "Kosher", string hashAlgorithm = "SHA1",
            int passwordInterations = 2, string initialVector = "PFRna73*aze01xY1", int keySize = 256)
        {
            if (string.IsNullOrEmpty(plainText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, hashAlgorithm, passwordInterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] cipherTextBytes = null;

            using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }
            symmetricKey.Clear();
            return Convert.ToBase64String(cipherTextBytes);
        }

        /// <summary>
        /// Проверка заполненности строк
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            if (this.tbSername.Text == "" || this.tbName.Text == "" ||
                this.tbPatronomic.Text == "" || this.tbDol.Text == "" ||
                this.tbLogin.Text == "" || this.tbPassword.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните все поля", "Сообщение" +
                    MessageBoxButtons.OK);
                return;
            }

            var newUser = EntityManager.UserDataTable.NewПользователиRow();
            newUser.Фамилия = this.tbSername.Text;
            newUser.Имя = this.tbName.Text;
            newUser.Отчество = this.tbPatronomic.Text;
            newUser.Должность = this.tbDol.Text;
            newUser.Логин = this.tbLogin.Text;
            newUser.Пароль = Encrypt(this.tbPassword.Text, this.password);
            EntityManager.UserDataTable.AddПользователиRow(newUser);
            EntityManager.UpdateUsers();

            MessageBox.Show("Регистрация успешна", "Сообщение");
            this.Close();
        }
    }
}
