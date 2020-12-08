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
    public partial class Реквизиты_Банка : Form
    {
        public Реквизиты_Банка()
        {
            InitializeComponent();
        }

        public string ПолучитьНазваниеБанка()
        {
            return ((Реквизиты_банкаRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row)?.Название_банка;
        }

        public string ПолучитьБИКБанка()
        {
            return ((Реквизиты_банкаRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row)?.БИК_банка;
        }

        public string ПолучитьИННБанка()
        {
            return ((Реквизиты_банкаRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row)?.ИНН_банка;
        }

        private void Реквизиты_банка_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "приставыDataSet.Реквизиты_банка". При необходимости она может быть перемещена или удалена.
            this.реквизиты_банкаTableAdapter.Fill(this.приставыDataSet.Реквизиты_банка);

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
