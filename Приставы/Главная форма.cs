using DGV2Printer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Приставы.Properties;
using Приставы.Объекты;
using Приставы.РегАвт;
using Приставы.Формы;
using static Приставы.ПриставыDataSet;

namespace Приставы
{
    public partial class Form1 : Form
    {
        private ПользователиRow user;

        public Form1(ПриставыDataSet.ПользователиRow user)
        {
            this.InitializeComponent();
            this.user = user;
            this.Form1_Load();
            Timer timer = new Timer();
        }

        private void Form1_Load()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.Должники". При необходимости она может быть перемещена или удалена.
            this.должникиTableAdapter.Fill(this.приставыDataSet.Должники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.ДолжникиЗапрос". При необходимости она может быть перемещена или удалена.
            this.должникиЗапросTableAdapter.Fill(this.приставыDataSet.ДолжникиЗапрос);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var input = new Карточка_должника(this.user);
            input.ShowDialog();

            this.должникиЗапросTableAdapter.Fill(this.приставыDataSet.ДолжникиЗапрос);
        }

        public ДолжникиRow GetCurrentEmployee()
        {
            return (ДолжникиRow)((DataRowView)this.dataGridView.CurrentRow.DataBoundItem).Row;
        }

        private string BuildWorkerCardFilter()
        {
            var filterExpressionList = new List<string>();
            var fieldFilter = this.textBox3.Text;
            if (!string.IsNullOrEmpty(fieldFilter))
            {
                filterExpressionList.Add(string.Format("(([ФИО должника] Like '%{0}%') OR ([ФИО взыскателя] Like '%{0}%'))", fieldFilter));
            }


            if (this.onlyWorkingFilterCheckBox.Checked)
            {
                filterExpressionList.Add("[Долг]");
            }

            if (this.checkBoxEnd.Checked)
            {
                filterExpressionList.Add("[Окончание дела]");
            }

            return string.Join(" AND ", filterExpressionList);
        }

        /// <summary>
        /// Кнопка удалить строку должника из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var idEmployee = ((ДолжникиЗапросRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row)?.Id;
            if (!idEmployee.HasValue)
            {
                return;
            }

            var deleteEmployeeQuestionResult = MessageBox.Show("Вы действительно хотите удалить сотрудника?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteEmployeeQuestionResult != DialogResult.Yes)
            {
                return;
            }

            using (var connection = new OleDbConnection(Settings.Default.ПриставыConnectionString))
            {
                connection.Open();
                using (var sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = $"DELETE FROM Должники WHERE Id = {idEmployee.Value}";
                    sqlCommand.ExecuteNonQuery();
                }
            }

            this.Form1_Load();
        }

        /// <summary>
        /// стереть весь текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
        }

        /// <summary>
        /// Фильтрация должников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.должникиЗапросBindingSource.Filter = this.BuildWorkerCardFilter();
        }

        /// <summary>
        /// Фильтрация долгов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFilter_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var input = new Карточка_должника(this.user);
            input.LoadКарточка_должника(
                (ДолжникиЗапросRow)((DataRowView)this.dataGridView.CurrentRow.DataBoundItem).Row);
            input.ShowDialog();

            this.должникиЗапросTableAdapter.Fill(this.приставыDataSet.ДолжникиЗапрос);
        }

        private void buttonFilter_Click_1(object sender, EventArgs e)
        {
            var deltaCoordinates = this.onlyWorkingFilterCheckBox.Height;
            if (this.onlyWorkingFilterCheckBox.Visible)
            {
                this.buttonFilter.BackColor = Color.Transparent;
                deltaCoordinates = -deltaCoordinates;
            }
            else
            {
                this.buttonFilter.BackColor = Color.LightSlateGray;
            }

            this.onlyWorkingFilterCheckBox.Visible = !this.onlyWorkingFilterCheckBox.Visible;

            this.dataGridView.Top += deltaCoordinates;
            this.dataGridView.Height -= deltaCoordinates;
            this.label5.Top += deltaCoordinates;
            this.textBox3.Top += deltaCoordinates;
            this.button11.Top += deltaCoordinates;
        }

        private void btnEndFilter_Click(object sender, EventArgs e)
        {
            var deltaCoordination = this.checkBoxEnd.Height;
            if (this.checkBoxEnd.Visible)
            {
                this.btnEndFilter.BackColor = Color.Red;
                deltaCoordination = -deltaCoordination;
            }
            else
            {
                this.btnEndFilter.BackColor = Color.LightPink;
            }

            this.checkBoxEnd.Visible = !this.checkBoxEnd.Visible;

            this.dataGridView.Top += deltaCoordination;
            this.dataGridView.Height -= deltaCoordination;
            this.label5.Top += deltaCoordination;
            this.textBox3.Top += deltaCoordination;
            this.button11.Top += deltaCoordination;
        }

        private void onlyWorkingFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.должникиЗапросBindingSource.Filter = this.BuildWorkerCardFilter();
        }

        private void checkBoxEnd_CheckedChanged(object sender, EventArgs e)
        {
            this.должникиЗапросBindingSource.Filter = this.BuildWorkerCardFilter();
        }

        private void новыйПристависполнительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Новый_пристав_исполнитель открыть = new Новый_пристав_исполнитель();
            открыть.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var открыть = new Должность();
            открыть.ShowDialog();
        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var открыть = new Отдел();
            открыть.ShowDialog();
        }

        /// <summary>
        /// Печать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDataGridView pr = new PrintDataGridView(this.dataGridView);
            pr.isRightToLeft = true;
            pr.ReportHeader = this.label6.Text;
            pr.Print();
        }

        /// <summary>
        /// Экспорт данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExp_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            for (int i = 0; i < this.dataGridView.Columns.Count; i++)
            {
                var cellCaption = this.dataGridView.Columns[i].HeaderText;
                var bracketIndex = cellCaption.IndexOf('(') - 1;
                if (bracketIndex > -1)
                {
                    cellCaption = cellCaption.Substring(0, bracketIndex);
                }

                cellCaption = cellCaption.Replace("ФИО должника", "ФИО должника");

                ExcelWorkSheet.Cells[1, i + 1] = cellCaption;
            }
            for (int i = 0; i < this.dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < this.dataGridView.Columns.Count; j++)
                {
                    ExcelWorkSheet.Cells[i + 2, j + 1] = this.dataGridView.Rows[i].Cells[j].Value.ToString();
                    if (!this.dataGridView.Columns[j].Visible)
                    {
                        ExcelWorkSheet.Cells[i + 2, j + 1].ColumnWidth = 0;
                    }
                }
            }

            for (int j = 0; j < this.dataGridView.Columns.Count; j++)
            {
                if (this.dataGridView.Columns[j].Visible)
                {
                    ExcelWorkSheet.Columns[j + 1].AutoFit();
                }
            }
            ExcelApp.Visible = true;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var открыть = new О_программе();
            открыть.ShowDialog();
        }

        private void сохранитьБДToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void восстановитьБДToolStripMenuItem_Click(object sender, EventArgs e)
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

                this.Form1_Load();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void сменаПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var откртыть = new Авторизация();
            откртыть.Show();
            this.Hide();
        }

        private void калькуляторЗадолженностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var открыть = new Калькулятор_задолженности();
            открыть.ShowDialog();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\Справка.chm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer.Interval = 1000;
            this.timer.Tick += new EventHandler(this.timer_Tick);
            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            string time = "";

            if (h < 10)
            {
                time += "0" + h;
            }
            else
            {
                time += h;
            }

            time += ":";

            if (m < 10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }

            time += ":";

            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }

            this.label22.Text = time;

            string data = "";

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            if (day < 10)
            {
                data += "0" + day;
            }
            else
            {
                data += day;
            }
            data += ".";
            if (month < 10)
            {
                data += "0" + month;
            }
            else
            {
                data += month;
            }
            data += ".";
            data += year;

            this.label23.Text = data;
        }
    }
}
