using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Приставы.Объекты;
using Приставы.ПриставыDataSetTableAdapters;
using static Приставы.ПриставыDataSet;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using System.Diagnostics;

namespace Приставы.Формы
{
    public partial class Карточка_должника : Form
    {
        private Dictionary<string, string[]> sexToHeightMap = new Dictionary<string, string[]>
        {
            {
                "Алименты",
                new string[]
                {
                }
            }
        };

        private ДолжникиRow должники;

        public Карточка_должника(ПользователиRow user)
        {
            this.InitializeComponent();
            this.textBoxPR.Text= user.Фамилия + " " + user.Имя + " " + user.Отчество;
            Timer timer = new Timer();
        }

        public void LoadКарточка_должника(ДолжникиЗапросRow должники)
        {
            this.должники = EntityManager.FilterDOL($"Id={должники.Id}").FirstOrDefault();
            this.textBoxNomer.Text = должники.IsНомер_делаNull() ? "0" : должники.Номер_дела.ToString();
            this.textBoxNomer.ReadOnly = true;
            this.textBoxFIODOL.Text = должники.ФИО_должника;
            this.textBoxFIODOL.ReadOnly = true;
            this.textBoxFIOVZ.Text = должники.ФИО_взыскателя;
            this.textBoxFIOVZ.ReadOnly = true;
            this.textBoxPR.Text = должники._Пристав_исполнитель;
            this.textBoxPR.ReadOnly = true;
            this.ReceiptDateTimePicker.Enabled = false;
            this.ReceiptDateTimePicker.Value = должники.Дата_заведения_дела;
            this.DateJobChancheTimePicker.Enabled = false;
            this.DateJobChancheTimePicker.Value = должники.Дата_окончания_дела;
            this.DateJobChancheTimePicker.Enabled = true;
            this.textBoxOrg.Text = должники.Организация;
            this.textBoxOrg.ReadOnly = true;
            this.tbProcedure.Text = должники.Порядок_обжалования;
            this.tbProcedure.ReadOnly = true;
            this.textBoxKey.Text = должники.Основные_решения_СП;
            this.textBoxKey.ReadOnly = true;
            this.label22.Text = должники.ФИО_должника;
            this.textBoxSeriya.Text = Convert.ToInt32(должники.Серия_паспорта).ToString();
            this.textBoxSeriya.ReadOnly = true;
            this.textBoxNumber.Text = Convert.ToInt32(должники.Номер_паспорта).ToString();
            this.textBoxNumber.ReadOnly = true;
            this.tbSeriaVZ.Text = Convert.ToInt32(должники.Серия_паспорта).ToString();
            this.tbSeriaVZ.ReadOnly = true;
            this.tbNumberVZ.Text = Convert.ToInt32(должники.Номер_паспорта).ToString();
            this.tbNumberVZ.ReadOnly = true;
            this.tbFIOChildren.Text = должники.ФИО_ребёнка;
            this.tbFIOChildren.ReadOnly = true;
            this.tbNumberChildren.Text = должники.___свидетельсва_о_рождении;
            this.tbNumberChildren.ReadOnly = true;
            this.dateTimePickerChildren.Value = должники.Дата_рождения_ребёнка;
            this.dateTimePickerChildren.Enabled = true;
            this.tbNum.Text = должники.Счёт_получателя;
            this.tbNum.ReadOnly = true;
            this.tbBank.Text = должники.Банк_получателя;
            this.tbBank.ReadOnly = true;
            this.tbInnBank.Text = должники.ИНН_банка_получателя;
            this.tbInnBank.ReadOnly = true;
            this.tbBIKBank.Text = должники.БИК_банка_получателя;
            this.tbBIKBank.ReadOnly = true;
            this.tbRazmVZ.Text = должники.Размер_взыскания.ToString();
            this.tbRazmVZ.ReadOnly = true;
            this.tbStreetDol.Text = должники.Адрес_проживания_должника;
            this.tbStreetDol.ReadOnly = true;
            this.tbStreetVZ.Text = должники.Адрес_проживания_взыскателя;
            this.tbStreetVZ.ReadOnly = true;
            this.tbStreetORG.Text = должники.Адрес_организации;
            this.tbStreetORG.ReadOnly = true;
            this.firedCheckBox.Checked = !должники.Долг;
            this.EndBusinessCheckBox.Checked = !должники.Окончание_дела;

            if (!должники.IsТип_взысканияNull())
            {
                this.comboBoxTypeVZ.SelectedIndex = this.comboBoxTypeVZ.Items.IndexOf(должники.Тип_взыскания);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.textBoxNomer.ReadOnly = false;
            this.textBoxFIODOL.ReadOnly = false;
            this.textBoxFIOVZ.ReadOnly = false;
            this.tbProcedure.ReadOnly = false;
            this.textBoxKey.ReadOnly = false;
            this.textBoxSeriya.ReadOnly = false;
            this.textBoxNumber.ReadOnly = false;
            this.tbSeriaVZ.ReadOnly = false;
            this.tbNumberVZ.ReadOnly = false;
            this.tbFIOChildren.ReadOnly = false;
            this.tbNumberChildren.ReadOnly = false;
            this.tbNum.ReadOnly = false;
            this.tbBank.ReadOnly = false;
            this.tbInnBank.ReadOnly = false;
            this.tbBIKBank.ReadOnly = false;
            this.tbRazmVZ.ReadOnly = false;
            this.tbStreetDol.ReadOnly = false;
            this.tbStreetVZ.ReadOnly = false;
            this.tbStreetORG.ReadOnly = false;
        }

        private bool CheckTextBoxes()
        {
            if (this.textBoxNomer.Text == "" || this.textBoxFIODOL.Text == ""
                ||this.textBoxFIOVZ.Text==""||this.textBoxPR.Text=="" 
                || this.ReceiptDateTimePicker.Value.ToString() == "")
            {
                return false;
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните необходимые поля!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idEmloyee = this.должники?.Id;
            var adapter = new ДолжникиTableAdapter();
            adapter.Fill(EntityManager.DOLDataTable);
            var savingEmployee = EntityManager.DOLDataTable.FindById(idEmloyee ?? -1)
                ?? EntityManager.DOLDataTable.NewДолжникиRow();
            var cardNumber = Convert.ToInt32(this.textBoxNomer.Text);
            if (this.IsEmployeeNumbersExists(savingEmployee, cardNumber))
            {
                MessageBox.Show("Неверно введены данные! Проверте номер карточки!",
                     "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            savingEmployee.Номер_дела = Convert.ToInt32(this.textBoxNomer.Text);
            this.textBoxNomer.ReadOnly = true;
            savingEmployee.ФИО_должника = this.textBoxFIODOL.Text;
            savingEmployee.ФИО_взыскателя = this.textBoxFIOVZ.Text;
            savingEmployee._Пристав_исполнитель = this.textBoxPR.Text;
            savingEmployee.Организация = this.textBoxOrg.Text;
            savingEmployee.Порядок_обжалования = this.tbProcedure.Text;
            savingEmployee.Основные_решения_СП = this.textBoxKey.Text;
            savingEmployee.Серия_паспорта = Convert.ToInt32(this.textBoxSeriya.Text);
            savingEmployee.Номер_паспорта = Convert.ToInt32(this.textBoxNumber.Text);
            savingEmployee.Серия_паспорта_взыскателя = Convert.ToInt32(this.tbSeriaVZ.Text);
            savingEmployee.Номер_паспорта_взыскателя = Convert.ToInt32(this.tbNumberVZ.Text);
            savingEmployee.Дата_заведения_дела = this.ReceiptDateTimePicker.Value
                .AddHours(-this.ReceiptDateTimePicker.Value.Hour)
                .AddMinutes(-this.ReceiptDateTimePicker.Value.Minute)
                .AddSeconds(-this.ReceiptDateTimePicker.Value.Second)
                .AddMilliseconds(-this.ReceiptDateTimePicker.Value.Millisecond);
            savingEmployee.Дата_окончания_дела = this.DateJobChancheTimePicker.Value
                .AddHours(-this.DateJobChancheTimePicker.Value.Hour)
                .AddMinutes(-this.DateJobChancheTimePicker.Value.Minute)
                .AddSeconds(-this.DateJobChancheTimePicker.Value.Second)
                .AddMilliseconds(-this.DateJobChancheTimePicker.Value.Millisecond);
            savingEmployee.Тип_взыскания = (string)this.comboBoxTypeVZ.SelectedItem;
            savingEmployee.ФИО_ребёнка = this.tbFIOChildren.Text;
            savingEmployee.___свидетельсва_о_рождении = this.tbNum.Text;
            savingEmployee.Дата_рождения_ребёнка = this.dateTimePickerChildren.Value
                .AddHours(-this.dateTimePickerChildren.Value.Hour)
                .AddMinutes(-this.dateTimePickerChildren.Value.Minute)
                .AddSeconds(-this.dateTimePickerChildren.Value.Second)
                .AddMilliseconds(-this.dateTimePickerChildren.Value.Millisecond);
            savingEmployee.Счёт_получателя = this.tbNum.Text;
            savingEmployee.Банк_получателя = this.tbBank.Text;
            savingEmployee.ИНН_банка_получателя = this.tbInnBank.Text;
            savingEmployee.БИК_банка_получателя = this.tbBIKBank.Text;
            savingEmployee.Размер_взыскания = Convert.ToInt32(this.tbRazmVZ.Text);
            savingEmployee.Адрес_проживания_должника = this.tbStreetDol.Text;
            savingEmployee.Адрес_проживания_взыскателя = this.tbStreetVZ.Text;
            savingEmployee.Адрес_организации = this.tbStreetORG.Text;

            savingEmployee.Долг = !this.firedCheckBox.Checked;
            savingEmployee.Окончание_дела = !this.EndBusinessCheckBox.Checked;

            try
            {
                if (this.должники == null)
                {
                    EntityManager.DOLDataTable.AddДолжникиRow(savingEmployee);
                    if (savingEmployee.IsНомер_делаNull())
                    {
                        var должникиTableAdapter = new ДолжникиTableAdapter();
                        должникиTableAdapter.Connection.Open();
                        var nextNumberComand = должникиTableAdapter.Connection.CreateCommand();
                        nextNumberComand.CommandText = "SELECT MAX([Номер дела]) FROM Должники";
                        var nextNumber = (int)nextNumberComand.ExecuteScalar();
                        savingEmployee.Номер_дела = nextNumber + 1;
                    }
                    EntityManager.UpdateDOL();
                }
                else
                {
                    var должникиTableAdapter = new ДолжникиTableAdapter();
                    должникиTableAdapter.Adapter.Update(savingEmployee.Table);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Ошибка при добавлении/изменении! \r\n" + exception.ToString(),
                    "Ошибка",
                    MessageBoxButtons.OK);
                return;
            }
            var message = this.должники == null
                ? "Добавление прошло успешно!"
                : "Изменение завершено успешно!";

            MessageBox.Show(message, "Информация", MessageBoxButtons.OK);
            this.Close();
        }

        private bool IsEmployeeNumbersExists(ДолжникиRow savingEmployee, int cardNumber)
        {
            foreach (var employee in EntityManager.DOLDataTable)
            {
                if ((employee.Номер_дела == cardNumber)
                    && (savingEmployee.IsNull(0) || employee.Id != savingEmployee.Id))
                {
                    return true;
                }
            }

            return false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действиетльно хотите закрыть данную вкладку?",
               "Закрытие вкладки", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBoxNomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void DateJobChancheTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.Enabled
                && (dateTimePicker.Value < DateTime.Now.Date))
            {
                MessageBox.Show("Нельзя выбрать предыдующую дату", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker.Value = DateTime.Now.Date;
                return;
            }
        }

        private void textBoxFIODOL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void ReceiptDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.Enabled
                && (dateTimePicker.Value < DateTime.Now.Date
                    || dateTimePicker.Value > DateTime.Now.Date.AddDays(1).AddMilliseconds(-1)))
            {
                MessageBox.Show("Нельзя выбрать предыдующую или последующую даты", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker.Value = DateTime.Now.Date;
                return;
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            var открыть = new ИсполнительКарточка();
            if (открыть.ShowDialog() == DialogResult.OK)
            {
                this.textBoxPR.Text = открыть.ПолучитьИсполнителя();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var открыть = new Организация();
            if (открыть.ShowDialog() == DialogResult.OK)
            {
                this.textBoxOrg.Text = открыть.ПолучитьОрганизация();
                this.tbStreetORG.Text = открыть.ПолучитьАдрес();
            }
        }

        private void dateTimePickerChildren_ValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.Enabled
                && (dateTimePicker.Value > DateTime.Now.Date.AddDays(1).AddMilliseconds(-1)))
            {
                MessageBox.Show("Нельзя выбрать следующую дату", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker.Value = DateTime.Now.Date;
                return;
            }

            this.DateJobChancheTimePicker.Value = this.dateTimePickerChildren.Value.AddYears(18);
        }

        private void tbNumberChildren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void tbFIOChildren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var открыть = new Калькулятор_задолженности();
            открыть.ShowDialog();
        }

        private void Карточка_должника_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
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

            label9.Text = time;

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
            label23.Text = data;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var templateFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Исполнительное производство.dotx");
            if (!File.Exists(templateFile))
            {
                throw new Exception("Не найден файл " + templateFile);
            }

            var oWord = new Word.Application();
            _Document oDoc = null;
            var newTemplateFile = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    $"ИП\\Исполнительное_производство_{DateTime.Now:dd.MM.yyyy_HH.mm.ss}_{this.textBoxFIODOL.Text}.docx");
            try
            {
                oDoc = oWord.Documents.Add(templateFile);
                this.SetTemplate(oDoc);

                oDoc.SaveAs2(FileName: newTemplateFile);
            }
            finally
            {
                oDoc?.Close();
                oWord.Quit();
            }
            MessageBox.Show("Сохранение прошло успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start(newTemplateFile);
        }

        private void SetTemplate(_Document oDoc)
        {
            var tableInfo = oDoc.Tables[1];
            tableInfo.Cell(1, 2).Range.Text = this.textBoxOrg.Text;
            tableInfo.Cell(3, 2).Range.Text = this.tbStreetORG.Text;
            tableInfo.Cell(5, 2).Range.Text = this.textBoxFIOVZ.Text;
            tableInfo.Cell(7, 2).Range.Text = this.textBoxFIODOL.Text;
            tableInfo.Cell(15, 2).Range.Text = this.ReceiptDateTimePicker.Value.ToString("dd.MM.yyyy");
            tableInfo.Cell(16, 2).Range.Text = this.tbRazmVZ.Text;
            tableInfo.Cell(17, 2).Range.Text = this.tbFIOChildren.Text + "," + this.dateTimePickerChildren.Value.ToString("dd.MM.yyyy");
            tableInfo.Cell(18, 2).Range.Text = this.textBoxFIOVZ.Text;
            tableInfo.Cell(20, 2).Range.Text = this.tbNum.Text;
            tableInfo.Cell(21, 2).Range.Text = this.tbBank.Text;
            tableInfo.Cell(22, 2).Range.Text = this.tbInnBank.Text;
            tableInfo.Cell(23, 2).Range.Text = this.tbBIKBank.Text;
            tableInfo.Cell(25, 2).Range.Text = this.ReceiptDateTimePicker.Value.ToString("dd.MM.yyyy");
            tableInfo.Cell(27, 2).Range.Text = this.textBoxFIODOL.Text;
            tableInfo.Cell(28, 1).Range.Text = this.tbFIOChildren.Text;
            tableInfo.Cell(30, 2).Range.Text = DateTime.Now.ToString("dd.MM.yyyy");
            tableInfo.Cell(31, 2).Range.Text = this.textBoxPR.Text;
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            var открыть = new Реквизиты_Банка();
            if (открыть.ShowDialog() == DialogResult.OK)
            {
                this.tbBank.Text = открыть.ПолучитьНазваниеБанка();
                this.tbInnBank.Text = открыть.ПолучитьБИКБанка();
                this.tbBIKBank.Text = открыть.ПолучитьИННБанка();
            }
        }
    }
}
