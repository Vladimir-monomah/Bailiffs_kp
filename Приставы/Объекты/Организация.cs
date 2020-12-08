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
    public partial class Организация : Form
    {
        public Организация()
        {
            this.InitializeComponent();
        }

        public string ПолучитьОрганизация()
        {
            return ((ОрганизацияRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row)?.Организация;
        }
        public string ПолучитьАдрес()
        {
            return ((ОрганизацияRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row)?.Адрес_организации;
        }

        private void Организация_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.Организация". При необходимости она может быть перемещена или удалена.
            this.организацияTableAdapter.Fill(this.приставыDataSet.Организация);

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
