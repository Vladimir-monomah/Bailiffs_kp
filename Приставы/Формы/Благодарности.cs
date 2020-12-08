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
    public partial class Благодарности : Form
    {
        public Благодарности()
        {
            this.InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:yana.burmak@mail.ru");
        }
    }
}
