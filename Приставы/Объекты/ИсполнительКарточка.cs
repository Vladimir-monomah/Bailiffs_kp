using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Приставы.ПриставыDataSet;

namespace Приставы.Объекты
{
    public partial class ИсполнительКарточка : Form
    {
        public ИсполнительКарточка()
        {
            this.InitializeComponent();
        }

        public string ПолучитьИсполнителя()
        {
            return ((ИсполнительRow)((DataRowView)this.PR_ISPDataGridView.CurrentRow?.DataBoundItem)?.Row)?.ФИО;
        }

        private void Исполнитель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.Исполнитель". При необходимости она может быть перемещена или удалена.
            this.исполнительTableAdapter.Fill(this.приставыDataSet.Исполнитель);

        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.PR_ISPFilterTextBox.Text = string.Empty;
        }

        private void PR_ISPFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            string resultFilterText = null;
            var filterText = this.PR_ISPFilterTextBox.Text;
            if (!string.IsNullOrWhiteSpace(filterText))
            {
                resultFilterText = "[ФИО] LIKE '%{filterText}%'";
            }
            this.исполнительBindingSource.Filter = resultFilterText;
        }

        private void PR_ISPDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
