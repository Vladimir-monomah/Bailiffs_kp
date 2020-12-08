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
    public delegate void OnSave();

    public delegate void OnBeforeSave(ДолжностиRow isRecordExists);

    public partial class Новая_должность : Form
    {
        public Новая_должность()
        {
            this.OnSaveEvent += () => { };
            this.OnBeforeSaveEvent += isRecordExists => { };
            this.InitializeComponent();
        }

        public event OnSave OnSaveEvent;

        public event OnBeforeSave OnBeforeSaveEvent;

        public void ЗагрузитьДолжность(string названиеДолжность)
        {
            this.textBoxDol.Text = названиеДолжность;
        }

        public string ПолучитьДолжность()
        {
            return this.textBoxDol.Text;
        }

        /// <summary>
        /// Проверка заполненности полей
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            if (this.textBoxDol.Text == "")
            {
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Название элемента справочника пустое и не будет сохранено.", "Информация",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            var positionName = this.textBoxDol.Text;
            var adapter = new ДолжностиTableAdapter();
            adapter.Fill(EntityManager.PostsDataTable);
            ДолжностиRow existingPosition = null;
            foreach (var position in EntityManager.PostsDataTable)
            {
                if (position.Название == positionName)
                {
                    existingPosition = position;
                    break;
                }
            }

            if (existingPosition != null)
            {
                this.OnBeforeSaveEvent(existingPosition);
                if (MessageBox.Show(
                    "Должность с таким именем уже существует!\r\nОбновить информацию по текущей должности?",
                    "Информация",
                    MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                existingPosition.Отделы = (int)this.departmentComboBox.SelectedValue;
            }
            else
            {
                var newPosition = EntityManager.PostsDataTable.NewДолжностиRow();
                newPosition.Название = positionName;
                newPosition.Отделы = (int)this.departmentComboBox.SelectedValue;
                EntityManager.PostsDataTable.AddДолжностиRow(newPosition);
            }

            EntityManager.UpdatePosts();
            this.OnSaveEvent();

            MessageBox.Show("Добавление прошло успешно!", "Информация", MessageBoxButtons.OK);
        }

        private void Новая_должность_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.приставыDataSet.Отделы);

        }
    }
}
