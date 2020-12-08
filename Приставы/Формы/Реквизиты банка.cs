using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Приставы.ПриставыDataSetTableAdapters;
using static Приставы.ПриставыDataSet;

namespace Приставы.Формы
{
    public partial class Реквизиты_банка : Form
    {
        public delegate void OnSave();

        public delegate void OnBeforeSave(Реквизиты_банкаRow isRecordExists);

        public Реквизиты_банка()
        {
            this.OnSaveEvent += () => { };
            this.OnBeforeSaveEvent += existingDirector => { };
            InitializeComponent();
        }

        public event OnSave OnSaveEvent;

        public event OnBeforeSave OnBeforeSaveEvent;

        /// <summary>
        /// Проверка заполненности полей
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            if (this.textBoxNameBank.Text == "" || this.tbBIKBank.Text == "" || this.tbINNBank.Text == "")
            {
                return false;
            }
            return true;
        }

        public string ПолучитьРеквизиты()
        {
            return this.textBoxNameBank.Text;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Название элемента справочника пустое и не будет сохранено.", "Информация",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            var BankName = this.textBoxNameBank.Text;
            Реквизиты_банкаRow existingISP = null;
            var adapter = new Реквизиты_банкаTableAdapter();
            adapter.Fill(EntityManager.Реквизиты_банкаDataTable);
            foreach (var isp in EntityManager.Реквизиты_банкаDataTable)
            {
                if (BankName == isp.Название_банка)
                {
                    existingISP = isp;
                    break;
                }
            }

            if (existingISP != null)
            {
                this.OnBeforeSaveEvent(existingISP);
                if (MessageBox.Show("Реквизиты банка уже существует! Изменить информацию о нём?",
                    "Информация", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
            }
            else
            {
                var newBank = EntityManager.Реквизиты_банкаDataTable.NewРеквизиты_банкаRow();
                newBank.Название_банка = this.textBoxNameBank.Text;
                newBank.БИК_банка = this.tbBIKBank.Text;
                newBank.ИНН_банка = this.tbINNBank.Text;

                EntityManager.Реквизиты_банкаDataTable.AddРеквизиты_банкаRow(newBank);
            }

            EntityManager.UpdateРеквизиты_банка();
            this.OnSaveEvent();
            MessageBox.Show("Добавление прошло успешно!", "Информация", MessageBoxButtons.OK);
        }

        private void tbBIKBank_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void textBoxNameBank_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
