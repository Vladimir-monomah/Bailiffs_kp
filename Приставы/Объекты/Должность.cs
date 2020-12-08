using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Приставы.Формы;
using static Приставы.ПриставыDataSet;

namespace Приставы.Объекты
{
    public partial class Должность : Form
    {

        public Должность()
        {
            this.InitializeComponent();
        }

        private bool ExistsДолжности(ДолжностиRow должностьRow)
        {
            foreach (ДолжностиRow row in this.приставыDataSet.Должности.Rows)
            {
                if (row.Название == должностьRow.Название)
                {
                    return true;
                }
            }

            return false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var открыть = new Новая_должность();
            открыть.OnSaveEvent += () =>
            {
                this.должностиTableAdapter.Fill(this.приставыDataSet.Должности);
            };
            открыть.ShowDialog();
        }

        private void Должность_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.ДолжностиЗапрос". При необходимости она может быть перемещена или удалена.
            this.должностиЗапросTableAdapter.Fill(this.приставыDataSet.ДолжностиЗапрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.приставыDataSet.Должности);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.должностиTableAdapter.Update(this.приставыDataSet.Должности);
            this.должностиTableAdapter.Fill(this.приставыDataSet.Должности);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var deleteDol = MessageBox.Show("Вы действительно хотите удалить данную должность?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteDol != DialogResult.Yes)
            {
                return;
            }
            int ind = this.dataGridView.SelectedCells[0].RowIndex;
            this.dataGridView.Rows.RemoveAt(ind);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var filterExpressionList = new List<string>();
            var fieldFilter = this.textBox5.Text;
            if (!string.IsNullOrEmpty(fieldFilter))
            {
                filterExpressionList.Add(string.Format("[Название] Like '%{0}%'", fieldFilter));
            }

            this.должностиЗапросBindingSource.Filter = "[Название] Like'" + this.textBox5.Text + "%'";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = "";
        }
    }
}
