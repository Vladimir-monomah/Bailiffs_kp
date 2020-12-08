namespace Приставы.Формы
{
    partial class Калькулятор
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Калькулятор));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butPriceGo = new System.Windows.Forms.Button();
            this.butPriceClear = new System.Windows.Forms.Button();
            this.pricePeriodCombo = new System.Windows.Forms.ComboBox();
            this.pricePeriod = new System.Windows.Forms.NumericUpDown();
            this.pricePrice = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butSaveAsCSV = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.itogPayment = new System.Windows.Forms.TextBox();
            this.itogSum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGrafik = new System.Windows.Forms.DataGridView();
            this.priceProcent = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.Месяц = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сумма_платежа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Остаток_основного_долга_руб = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProcent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(424, 349);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.priceProcent);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.butPriceGo);
            this.tabPage2.Controls.Add(this.butPriceClear);
            this.tabPage2.Controls.Add(this.pricePeriodCombo);
            this.tabPage2.Controls.Add(this.pricePeriod);
            this.tabPage2.Controls.Add(this.pricePrice);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(416, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выплаты";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.pricePrice_Enter);
            // 
            // butPriceGo
            // 
            this.butPriceGo.Location = new System.Drawing.Point(233, 270);
            this.butPriceGo.Name = "butPriceGo";
            this.butPriceGo.Size = new System.Drawing.Size(177, 44);
            this.butPriceGo.TabIndex = 24;
            this.butPriceGo.Text = "Рассчитать стоимость";
            this.butPriceGo.UseVisualStyleBackColor = true;
            this.butPriceGo.Click += new System.EventHandler(this.butPriceGo_Click);
            // 
            // butPriceClear
            // 
            this.butPriceClear.Location = new System.Drawing.Point(9, 273);
            this.butPriceClear.Name = "butPriceClear";
            this.butPriceClear.Size = new System.Drawing.Size(160, 44);
            this.butPriceClear.TabIndex = 23;
            this.butPriceClear.Text = "Очистить расчёты";
            this.butPriceClear.UseVisualStyleBackColor = true;
            this.butPriceClear.Click += new System.EventHandler(this.butPriceClear_Click);
            // 
            // pricePeriodCombo
            // 
            this.pricePeriodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pricePeriodCombo.FormattingEnabled = true;
            this.pricePeriodCombo.Items.AddRange(new object[] {
            "лет",
            "мес."});
            this.pricePeriodCombo.Location = new System.Drawing.Point(325, 99);
            this.pricePeriodCombo.Name = "pricePeriodCombo";
            this.pricePeriodCombo.Size = new System.Drawing.Size(71, 24);
            this.pricePeriodCombo.TabIndex = 19;
            // 
            // pricePeriod
            // 
            this.pricePeriod.Location = new System.Drawing.Point(199, 101);
            this.pricePeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pricePeriod.Name = "pricePeriod";
            this.pricePeriod.Size = new System.Drawing.Size(120, 22);
            this.pricePeriod.TabIndex = 17;
            this.pricePeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pricePeriod.Enter += new System.EventHandler(this.pricePeriod_Enter);
            // 
            // pricePrice
            // 
            this.pricePrice.Location = new System.Drawing.Point(199, 9);
            this.pricePrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.pricePrice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pricePrice.Name = "pricePrice";
            this.pricePrice.Size = new System.Drawing.Size(120, 22);
            this.pricePrice.TabIndex = 14;
            this.pricePrice.ThousandsSeparator = true;
            this.pricePrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pricePrice.Enter += new System.EventHandler(this.pricePrice_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "Срок выплат алиментов";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Ежемесячный доход:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.butSaveAsCSV);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.itogPayment);
            this.groupBox1.Controls.Add(this.itogSum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 324);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результаты расчётов";
            // 
            // butSaveAsCSV
            // 
            this.butSaveAsCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSaveAsCSV.Location = new System.Drawing.Point(71, 270);
            this.butSaveAsCSV.Name = "butSaveAsCSV";
            this.butSaveAsCSV.Size = new System.Drawing.Size(274, 44);
            this.butSaveAsCSV.TabIndex = 12;
            this.butSaveAsCSV.Text = "Экспорт расчётов в .CSV";
            this.butSaveAsCSV.UseVisualStyleBackColor = true;
            this.butSaveAsCSV.Click += new System.EventHandler(this.butSaveAsCSV_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "руб.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "руб.";
            // 
            // itogPayment
            // 
            this.itogPayment.Location = new System.Drawing.Point(107, 131);
            this.itogPayment.Name = "itogPayment";
            this.itogPayment.ReadOnly = true;
            this.itogPayment.Size = new System.Drawing.Size(179, 22);
            this.itogPayment.TabIndex = 12;
            // 
            // itogSum
            // 
            this.itogSum.Location = new System.Drawing.Point(107, 58);
            this.itogSum.Name = "itogSum";
            this.itogSum.ReadOnly = true;
            this.itogSum.Size = new System.Drawing.Size(179, 22);
            this.itogSum.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ежемесячный платёж:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Итоговая сумма:\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgvGrafik);
            this.groupBox2.Location = new System.Drawing.Point(442, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 644);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "График платежей";
            // 
            // dgvGrafik
            // 
            this.dgvGrafik.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrafik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Месяц,
            this.Сумма_платежа,
            this.Остаток_основного_долга_руб});
            this.dgvGrafik.Location = new System.Drawing.Point(6, 21);
            this.dgvGrafik.Name = "dgvGrafik";
            this.dgvGrafik.RowTemplate.Height = 24;
            this.dgvGrafik.Size = new System.Drawing.Size(826, 617);
            this.dgvGrafik.TabIndex = 0;
            // 
            // priceProcent
            // 
            this.priceProcent.DecimalPlaces = 2;
            this.priceProcent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceProcent.Location = new System.Drawing.Point(199, 52);
            this.priceProcent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceProcent.Name = "priceProcent";
            this.priceProcent.Size = new System.Drawing.Size(120, 22);
            this.priceProcent.TabIndex = 26;
            this.priceProcent.Enter += new System.EventHandler(this.priceProcent_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Процентная ставка";
            // 
            // Месяц
            // 
            this.Месяц.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Месяц.HeaderText = "Месяц";
            this.Месяц.Name = "Месяц";
            this.Месяц.ReadOnly = true;
            // 
            // Сумма_платежа
            // 
            this.Сумма_платежа.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Сумма_платежа.HeaderText = "Сумма платежа";
            this.Сумма_платежа.Name = "Сумма_платежа";
            this.Сумма_платежа.ReadOnly = true;
            // 
            // Остаток_основного_долга_руб
            // 
            this.Остаток_основного_долга_руб.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Остаток_основного_долга_руб.HeaderText = "Остаток основного долга, руб.";
            this.Остаток_основного_долга_руб.Name = "Остаток_основного_долга_руб";
            this.Остаток_основного_долга_руб.ReadOnly = true;
            // 
            // Калькулятор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 817);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Калькулятор";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Калькулятор_Load);
            this.Shown += new System.EventHandler(this.Калькулятор_задолженности_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricePrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProcent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button butPriceGo;
        private System.Windows.Forms.Button butPriceClear;
        private System.Windows.Forms.ComboBox pricePeriodCombo;
        private System.Windows.Forms.NumericUpDown pricePeriod;
        private System.Windows.Forms.NumericUpDown pricePrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butSaveAsCSV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox itogPayment;
        private System.Windows.Forms.TextBox itogSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvGrafik;
        private System.Windows.Forms.NumericUpDown priceProcent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Месяц;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сумма_платежа;
        private System.Windows.Forms.DataGridViewTextBoxColumn Остаток_основного_долга_руб;
    }
}