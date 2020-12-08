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
    public partial class Восстановление_пароля : Form
    {
        public Восстановление_пароля()
        {
            this.InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:ca01@fssprus.ru");
        }
    }
}
