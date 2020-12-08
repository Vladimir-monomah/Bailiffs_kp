using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приставы.Формы
{
    public partial class Новый_пристав_исполнитель : Form
    {
        public Новый_пристав_исполнитель()
        {
            this.InitializeComponent();
        }

        private void Новый_пристав_исполнитель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.Исполнитель". При необходимости она может быть перемещена или удалена.
            this.исполнительTableAdapter.Fill(this.приставыDataSet.Исполнитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.ИсполнительЗапрос". При необходимости она может быть перемещена или удалена.
            this.исполнительЗапросTableAdapter.Fill(this.приставыDataSet.ИсполнительЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.ИсполнительЗапрос". При необходимости она может быть перемещена или удалена.
            this.исполнительЗапросTableAdapter.Fill(this.приставыDataSet.ИсполнительЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.Исполнитель". При необходимости она может быть перемещена или удалена.
            this.исполнительTableAdapter.Fill(this.приставыDataSet.Исполнитель);

        }

        /// <summary>
        /// Добавить исполнителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button37_Click(object sender, EventArgs e)
        {
            Исполнитель открыть = new Исполнитель();
            открыть.OnSaveEvent += () =>
            {
                this.исполнительTableAdapter.Fill(this.приставыDataSet.Исполнитель);
            };
            открыть.ShowDialog();
        }

        /// <summary>
        /// Кнопка сохранить исполнителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button34_Click(object sender, EventArgs e)
        {
            this.исполнительTableAdapter.Update(this.приставыDataSet);
            this.исполнительTableAdapter.Fill(this.приставыDataSet.Исполнитель);
        }

        /// <summary>
        /// Кнопка удалить исполнителя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button35_Click(object sender, EventArgs e)
        {
            var deleteISP = MessageBox.Show("Вы действительно хотите удалить данного руководителя?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteISP != DialogResult.Yes)
            {
                return;
            }
            int ind = this.dataGridView.SelectedCells[0].RowIndex;
            this.dataGridView.Rows.RemoveAt(ind);
        }

        /// <summary>
        /// Очистить текстовое поле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button38_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = "";
        }

        /// <summary>
        /// Фильтрация руководителей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.исполнительBindingSource.Filter = "[ФИО] Like'" + this.textBox7.Text + "%'";
        }
    }
}
