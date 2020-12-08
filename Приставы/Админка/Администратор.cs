using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Приставы.РегАвт;
using Приставы.Формы;

namespace Приставы.Админка
{
    public partial class Администратор : Form
    {
        private string password = "ntvHA2s1y+ryOZizPQ1WHQ==";

        const string FilterNonAdministrators = "([Является администратором]=FALSE)";

        public Администратор()
        {
            this.InitializeComponent();
        }

        private void Администратор_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.приставыDataSet.Пользователи);

        }

        ///<summary>
        ///Фильтрация пользователей
        ///</summary>
        ///<param name="sender"></param>
        ///<param name="e"</param>
        private void clientFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            var findFields = new[] { "Фамилия", "Имя", "Отчество" };
            var filterString = EntityManager.GetFilterStringByFields(findFields, this.clientFilterTextBox.Text).Trim();

            this.пользователиBindingSource.Filter = FilterNonAdministrators;
            if (!string.IsNullOrEmpty(filterString))
            {
                this.пользователиBindingSource.Filter += $"AND ({filterString})";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.пользователиBindingSource.Filter = null;
            this.clientFilterTextBox.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            int ind = this.dataGridView.SelectedCells[0].RowIndex;
            this.dataGridView.Rows.RemoveAt(ind);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.пользователиTableAdapter.Adapter.Update(this.приставыDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dataBasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Приставы.mdb";
            var saveDialog = new SaveFileDialog
            {
                FileName = "Приставы - копия.mdb",
                Filter = "AccessDB files|*.mdb"
            };
            try
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(dataBasePath, saveDialog.FileName, true);
                    MessageBox.Show("Резервное копирование прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Не удаётся скопировать файл из-за исключения: " + exception.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dataBasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Приставы.mdb";
            var openDialog = new OpenFileDialog
            {
                Filter = "AccessDB files|*.mdb"
            };
            try
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openDialog.FileName, dataBasePath, true);
                    MessageBox.Show("Восстановление прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var открыть = new Новая_должность();
            открыть.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var открыть = new Исполнитель();
            открыть.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var открыть = new Новый_отдел();
            открыть.ShowDialog();
        }

        private void Администратор_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действиетльно хотите выйти?",
                    "Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else e.Cancel = true;
            }
            else Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var открыть = new Новая_организация();
            открыть.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var открыть = new Авторизация();
            открыть.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var открыть = new Реквизиты_банка();
            открыть.ShowDialog();
        }
    }
}
