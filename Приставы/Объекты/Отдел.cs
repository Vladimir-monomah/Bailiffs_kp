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

namespace Приставы.Объекты
{
    public partial class Отдел : Form
    {
        public Отдел()
        {
            this.InitializeComponent();
        }

        private void Отдел_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.Отделы". При необходимости она может быть перемещена или удалена.
            this.отделыTableAdapter.Fill(this.приставыDataSet.Отделы);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Новый_отдел открыть = new Новый_отдел();
            открыть.OnSaveEvent += () =>
            {
                this.отделыTableAdapter.Fill(this.приставыDataSet.Отделы);
            };
            открыть.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.отделыTableAdapter.Update(this.приставыDataSet);
            this.отделыTableAdapter.Fill(this.приставыDataSet.Отделы);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ind = this.dataGridView.SelectedCells[0].RowIndex;
            this.dataGridView.Rows.RemoveAt(ind);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.отделыBindingSource.Filter = "[Наименование] Like'" + this.textBox4.Text + "%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox4.Text = "";
        }
    }
}
