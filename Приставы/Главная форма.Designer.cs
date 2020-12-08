namespace Приставы
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сменаАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПристависполнительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторЗадолженностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonExp = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.onlyWorkingFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.должникиЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приставыDataSet = new Приставы.ПриставыDataSet();
            this.должникиЗапросTableAdapter = new Приставы.ПриставыDataSetTableAdapters.ДолжникиЗапросTableAdapter();
            this.должникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должникиTableAdapter = new Приставы.ПриставыDataSetTableAdapters.ДолжникиTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.номерДелаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОДолжникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОВзыскателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пристависполнительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.организацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаведенияДелаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияДелаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnEndFilter = new System.Windows.Forms.Button();
            this.checkBoxEnd = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.должникиЗапросBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаАккаунтаToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1754, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сменаАккаунтаToolStripMenuItem
            // 
            this.сменаАккаунтаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаПользователяToolStripMenuItem});
            this.сменаАккаунтаToolStripMenuItem.Name = "сменаАккаунтаToolStripMenuItem";
            this.сменаАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.сменаАккаунтаToolStripMenuItem.Text = "Смена аккаунта";
            // 
            // сменаПользователяToolStripMenuItem
            // 
            this.сменаПользователяToolStripMenuItem.Image = global::Приставы.Properties.Resources.ikonka_6;
            this.сменаПользователяToolStripMenuItem.Name = "сменаПользователяToolStripMenuItem";
            this.сменаПользователяToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.сменаПользователяToolStripMenuItem.Text = "Смена пользователя";
            this.сменаПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменаПользователяToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйПристависполнительToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.отделыToolStripMenuItem,
            this.калькуляторЗадолженностиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // новыйПристависполнительToolStripMenuItem
            // 
            this.новыйПристависполнительToolStripMenuItem.Image = global::Приставы.Properties.Resources.ikonka;
            this.новыйПристависполнительToolStripMenuItem.Name = "новыйПристависполнительToolStripMenuItem";
            this.новыйПристависполнительToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.новыйПристависполнительToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.новыйПристависполнительToolStripMenuItem.Text = "Пристав-исполнитель";
            this.новыйПристависполнительToolStripMenuItem.Click += new System.EventHandler(this.новыйПристависполнительToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Image = global::Приставы.Properties.Resources.ikonka;
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // отделыToolStripMenuItem
            // 
            this.отделыToolStripMenuItem.Image = global::Приставы.Properties.Resources.ikonka_1;
            this.отделыToolStripMenuItem.Name = "отделыToolStripMenuItem";
            this.отделыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.отделыToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.отделыToolStripMenuItem.Text = "Отделы";
            this.отделыToolStripMenuItem.Click += new System.EventHandler(this.отделыToolStripMenuItem_Click);
            // 
            // калькуляторЗадолженностиToolStripMenuItem
            // 
            this.калькуляторЗадолженностиToolStripMenuItem.Image = global::Приставы.Properties.Resources.exeL_fri1;
            this.калькуляторЗадолженностиToolStripMenuItem.Name = "калькуляторЗадолженностиToolStripMenuItem";
            this.калькуляторЗадолженностиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.калькуляторЗадолженностиToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.калькуляторЗадолженностиToolStripMenuItem.Text = "Калькулятор задолженности";
            this.калькуляторЗадолженностиToolStripMenuItem.Click += new System.EventHandler(this.калькуляторЗадолженностиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.toolStripSeparator1,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPrint.Location = new System.Drawing.Point(630, 79);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(79, 30);
            this.buttonPrint.TabIndex = 30;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonExp
            // 
            this.buttonExp.BackColor = System.Drawing.Color.Transparent;
            this.buttonExp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonExp.Location = new System.Drawing.Point(538, 79);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(86, 30);
            this.buttonExp.TabIndex = 28;
            this.buttonExp.Text = "Экспорт";
            this.buttonExp.UseVisualStyleBackColor = false;
            this.buttonExp.Click += new System.EventHandler(this.buttonExp_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Image = global::Приставы.Properties.Resources.кнопка_3;
            this.button11.Location = new System.Drawing.Point(1700, 115);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 30);
            this.button11.TabIndex = 27;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "Поиск";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(82, 115);
            this.textBox3.MaxLength = 30;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1612, 30);
            this.textBox3.TabIndex = 24;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // onlyWorkingFilterCheckBox
            // 
            this.onlyWorkingFilterCheckBox.AutoSize = true;
            this.onlyWorkingFilterCheckBox.Checked = true;
            this.onlyWorkingFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onlyWorkingFilterCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.onlyWorkingFilterCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.onlyWorkingFilterCheckBox.Location = new System.Drawing.Point(713, 76);
            this.onlyWorkingFilterCheckBox.Name = "onlyWorkingFilterCheckBox";
            this.onlyWorkingFilterCheckBox.Size = new System.Drawing.Size(62, 21);
            this.onlyWorkingFilterCheckBox.TabIndex = 25;
            this.onlyWorkingFilterCheckBox.Text = "Долг";
            this.onlyWorkingFilterCheckBox.UseVisualStyleBackColor = true;
            this.onlyWorkingFilterCheckBox.Visible = false;
            this.onlyWorkingFilterCheckBox.CheckedChanged += new System.EventHandler(this.onlyWorkingFilterCheckBox_CheckedChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonAdd.Location = new System.Drawing.Point(15, 76);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 30);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDelete.Location = new System.Drawing.Point(130, 76);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(107, 30);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFilter.Location = new System.Drawing.Point(244, 76);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(141, 30);
            this.buttonFilter.TabIndex = 17;
            this.buttonFilter.Text = "Фильтр долга";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click_1);
            // 
            // должникиЗапросBindingSource
            // 
            this.должникиЗапросBindingSource.DataMember = "ДолжникиЗапрос";
            this.должникиЗапросBindingSource.DataSource = this.приставыDataSet;
            // 
            // приставыDataSet
            // 
            this.приставыDataSet.DataSetName = "ПриставыDataSet";
            this.приставыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // должникиЗапросTableAdapter
            // 
            this.должникиЗапросTableAdapter.ClearBeforeFill = true;
            // 
            // должникиBindingSource
            // 
            this.должникиBindingSource.DataMember = "Должники";
            this.должникиBindingSource.DataSource = this.приставыDataSet;
            // 
            // должникиTableAdapter
            // 
            this.должникиTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДелаDataGridViewTextBoxColumn,
            this.фИОДолжникаDataGridViewTextBoxColumn,
            this.фИОВзыскателяDataGridViewTextBoxColumn,
            this.пристависполнительDataGridViewTextBoxColumn,
            this.организацияDataGridViewTextBoxColumn,
            this.датаЗаведенияДелаDataGridViewTextBoxColumn,
            this.датаОкончанияДелаDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.должникиЗапросBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 148);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1730, 496);
            this.dataGridView.TabIndex = 31;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // номерДелаDataGridViewTextBoxColumn
            // 
            this.номерДелаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.номерДелаDataGridViewTextBoxColumn.DataPropertyName = "Номер дела";
            this.номерДелаDataGridViewTextBoxColumn.HeaderText = "Номер дела";
            this.номерДелаDataGridViewTextBoxColumn.Name = "номерДелаDataGridViewTextBoxColumn";
            this.номерДелаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОДолжникаDataGridViewTextBoxColumn
            // 
            this.фИОДолжникаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОДолжникаDataGridViewTextBoxColumn.DataPropertyName = "ФИО должника";
            this.фИОДолжникаDataGridViewTextBoxColumn.HeaderText = "ФИО должника";
            this.фИОДолжникаDataGridViewTextBoxColumn.Name = "фИОДолжникаDataGridViewTextBoxColumn";
            this.фИОДолжникаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОВзыскателяDataGridViewTextBoxColumn
            // 
            this.фИОВзыскателяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОВзыскателяDataGridViewTextBoxColumn.DataPropertyName = "ФИО взыскателя";
            this.фИОВзыскателяDataGridViewTextBoxColumn.HeaderText = "ФИО взыскателя";
            this.фИОВзыскателяDataGridViewTextBoxColumn.Name = "фИОВзыскателяDataGridViewTextBoxColumn";
            this.фИОВзыскателяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // пристависполнительDataGridViewTextBoxColumn
            // 
            this.пристависполнительDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.пристависполнительDataGridViewTextBoxColumn.DataPropertyName = "Пристав-исполнитель";
            this.пристависполнительDataGridViewTextBoxColumn.HeaderText = "Пристав-исполнитель";
            this.пристависполнительDataGridViewTextBoxColumn.Name = "пристависполнительDataGridViewTextBoxColumn";
            this.пристависполнительDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // организацияDataGridViewTextBoxColumn
            // 
            this.организацияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.организацияDataGridViewTextBoxColumn.DataPropertyName = "Организация";
            this.организацияDataGridViewTextBoxColumn.HeaderText = "Организация";
            this.организацияDataGridViewTextBoxColumn.Name = "организацияDataGridViewTextBoxColumn";
            this.организацияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаЗаведенияДелаDataGridViewTextBoxColumn
            // 
            this.датаЗаведенияДелаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаЗаведенияДелаDataGridViewTextBoxColumn.DataPropertyName = "Дата заведения дела";
            this.датаЗаведенияДелаDataGridViewTextBoxColumn.HeaderText = "Дата заведения дела";
            this.датаЗаведенияДелаDataGridViewTextBoxColumn.Name = "датаЗаведенияДелаDataGridViewTextBoxColumn";
            this.датаЗаведенияДелаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаОкончанияДелаDataGridViewTextBoxColumn
            // 
            this.датаОкончанияДелаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаОкончанияДелаDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания дела";
            this.датаОкончанияДелаDataGridViewTextBoxColumn.HeaderText = "Дата окончания дела";
            this.датаОкончанияДелаDataGridViewTextBoxColumn.Name = "датаОкончанияДелаDataGridViewTextBoxColumn";
            this.датаОкончанияДелаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(755, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Карточки должников";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(1582, 664);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(160, 30);
            this.label23.TabIndex = 34;
            this.label23.Text = "label23";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(1397, 664);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(179, 30);
            this.label22.TabIndex = 33;
            this.label22.Text = "label22";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnEndFilter
            // 
            this.btnEndFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnEndFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEndFilter.Location = new System.Drawing.Point(391, 76);
            this.btnEndFilter.Name = "btnEndFilter";
            this.btnEndFilter.Size = new System.Drawing.Size(141, 30);
            this.btnEndFilter.TabIndex = 17;
            this.btnEndFilter.Text = "Фильтр дел";
            this.btnEndFilter.UseVisualStyleBackColor = false;
            this.btnEndFilter.Click += new System.EventHandler(this.btnEndFilter_Click);
            // 
            // checkBoxEnd
            // 
            this.checkBoxEnd.AutoSize = true;
            this.checkBoxEnd.Checked = true;
            this.checkBoxEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnd.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxEnd.Location = new System.Drawing.Point(781, 76);
            this.checkBoxEnd.Name = "checkBoxEnd";
            this.checkBoxEnd.Size = new System.Drawing.Size(140, 21);
            this.checkBoxEnd.TabIndex = 35;
            this.checkBoxEnd.Text = "Окончание дела";
            this.checkBoxEnd.UseVisualStyleBackColor = true;
            this.checkBoxEnd.Visible = false;
            this.checkBoxEnd.CheckedChanged += new System.EventHandler(this.checkBoxEnd_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1754, 715);
            this.Controls.Add(this.checkBoxEnd);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonExp);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnEndFilter);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.onlyWorkingFilterCheckBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приставы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.должникиЗапросBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйПристависполнительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox onlyWorkingFilterCheckBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFilter;
        private ПриставыDataSet приставыDataSet;
        private System.Windows.Forms.BindingSource должникиЗапросBindingSource;
        private ПриставыDataSetTableAdapters.ДолжникиЗапросTableAdapter должникиЗапросTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделыToolStripMenuItem;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.BindingSource должникиBindingSource;
        private ПриставыDataSetTableAdapters.ДолжникиTableAdapter должникиTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem сменаАккаунтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаПользователяToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem калькуляторЗадолженностиToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДелаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОДолжникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОВзыскателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пристависполнительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn организацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаведенияДелаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияДелаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnEndFilter;
        private System.Windows.Forms.CheckBox checkBoxEnd;
    }
}

