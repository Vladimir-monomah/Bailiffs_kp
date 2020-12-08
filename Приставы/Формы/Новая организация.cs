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
    public delegate void OnTave();

    public delegate void OnBeforeTave(ОрганизацияRow isRecordExists);

    public partial class Новая_организация : Form
    {
        public Новая_организация()
        {
            this.OnSaveEvent += () => { };
            this.OnBeforeSaveEvent += isRecordExists => { };
            this.InitializeComponent();
        }

        public event OnTave OnSaveEvent;

        public event OnBeforeTave OnBeforeSaveEvent;

        public void ЗагрузитьОрганизацию(string названиеОрганизации)
        {
            this.textBoxOrg.Text = названиеОрганизации;
        }

        private bool CheckTextBoxes()
        {
            if (this.textBoxOrg.Text == "")
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

            var departamentName = this.textBoxOrg.Text;
            var adapter = new ОрганизацияTableAdapter();
            adapter.Fill(EntityManager.ОрганизацияDataTable);
            ОрганизацияRow existingDepartaments = null;
            foreach (var departaments in EntityManager.ОрганизацияDataTable)
            {
                if (departaments.Организация == departamentName)
                {
                    existingDepartaments = departaments;
                    break;
                }
            }

            if (existingDepartaments != null)
            {
                this.OnBeforeSaveEvent(existingDepartaments);
                MessageBox.Show("Организация с таким именем уже существует!", "Информация", MessageBoxButtons.OK);
                return;
            }

            var newDepartaments = EntityManager.ОрганизацияDataTable.NewОрганизацияRow();
            newDepartaments.Организация = departamentName;
            EntityManager.ОрганизацияDataTable.AddОрганизацияRow(newDepartaments);
            EntityManager.UpdateОрганизация();
            this.OnSaveEvent();

            MessageBox.Show("Добавление прошло успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
