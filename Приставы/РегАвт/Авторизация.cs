using System;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Приставы.Properties;
using Приставы.Админка;
using Приставы.Формы;

namespace Приставы.РегАвт
{
    public partial class Авторизация : Form
    {
        private string password = "2fd4e1c67a2d28fced849ee1bb76e7391b93eb12";

        int counter = 0;

        public Авторизация()
        {
            if (!CheckDBConnect())
            {
                this.Close();
            }

            this.InitializeComponent();
        }



        //// <summary>
        /// Проверяет возможность соединения с БД СИЗ,
        /// при необходимости, заменяет путь к резервной копии по указанию пользователя
        /// </summary>
        private bool CheckDBConnect()
        {
            while (true)
            {
                try
                {
                    using (var connection = new OleDbConnection(Settings.Default.ПриставыConnectionString))
                    {
                        connection.Open();
                        return true;
                    }
                }
                catch
                {
                    var reservDBFileQuestionResult = MessageBox.Show(
                        "Не найдена база данных приставы!\r\nХотите указать файл из резервной копии?",
                        "Информация",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (reservDBFileQuestionResult != DialogResult.Yes)
                    {
                        return false;
                    }

                    var openDialog = new OpenFileDialog
                    {
                        Title = "Укажите файл базы данных Приставы",
                        Filter = "База данных Приставы|*.mdb",
                        InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                    };
                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        Settings.Default["ПриставыConnectionString"] = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + openDialog.FileName;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Открытие формы регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReg_Click(object sender, EventArgs e)
        {
            var открыть = new Регистрация(this.password);
            открыть.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно " +
               "хотите закрыть программу?",
               "Закрытие программы", MessageBoxButtons.
               YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btVH_Click(object sender, EventArgs e)
        {
            if (this.tbLogin.Text == "" && this.tbPassword.Text == "")
            {
                MessageBox.Show("Вы не " +
                    "ввели логин или пароль! " +
                    "Пожалуйста, заполните поля!",
                    "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            this.counter++;
            if (string.IsNullOrEmpty(this.tbLogin.Text))
            {
                this.tbLogin.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.tbPassword.Text))
            {
                this.tbPassword.Focus();
                return;
            }

            else if (this.counter >= 3)
            {
                this.tbLogin.Enabled = false;
                this.tbPassword.Enabled = false;
                MessageBox.Show("Количесво попыток на ввод пароля закончились! " +
                    "Для восстановления пароля, вы можете написать на нашу официальную почту! Мы в скором времени с вами свяжемся!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                var откртыть = new Восстановление_пароля();
                откртыть.ShowDialog();
            }

            var user = this.FindUser(this.tbLogin.Text, this.tbPassword.Text);
            if (user != null)
            {
                if (user.Является_администратором)
                {
                    Администратор формаАдминистратора = new Администратор();
                    this.Hide();
                    формаАдминистратора.Show();
                }
                else
                {
                    var открыть = new Form1(user);
                    this.Hide();
                    открыть.Show();
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неверный логин или пароль!Пользователь в базе не найден!", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private ПриставыDataSet.ПользователиRow FindUser(string login,string password)
        {
            var loginCondition = $"Логин='{login}' AND Пароль='{Регистрация.Encrypt(password, this.password)}'";
            var user = EntityManager.FilterUsers(loginCondition).FirstOrDefault();
            return user;
        }

        private ПриставыDataSet.ПользователиRow User(string login)
        {
            var loginCondition = $"Логин='{login}'";
            var user = EntityManager.FilterUsers(loginCondition).FirstOrDefault();
            return user;
        }

        private void pictureBoxRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void PasswordChangeLabel_Click(object sender, EventArgs e)
        {
            var открыть = new Смена_пароля();
            открыть.OnValidateUser += (login, oldPassword, newPassword) =>
            {
                var user = this.User(открыть.GetLogin());
                if (user == null)
                {
                    MessageBox.Show("Не найден пользователь с таким логином и паролем");
                    return false;
                }

                user.Пароль = Регистрация.Encrypt(открыть.GetNewPassword(), this.password);
                EntityManager.UpdateUsers();
                MessageBox.Show("Пароль изменён!");
                return true;
            };
            открыть.ShowDialog();
        }
    }
}
