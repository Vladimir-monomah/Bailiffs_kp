﻿using System;
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
    public partial class О_программе : Form
    {
        public О_программе()
        {
            this.InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Благодарности открыть = new Благодарности();
            открыть.ShowDialog();
        }
    }
}
