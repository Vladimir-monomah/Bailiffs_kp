namespace Приставы.Объекты
{
    partial class Организация
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Организация));
            this.организацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приставыDataSet = new Приставы.ПриставыDataSet();
            this.организацияTableAdapter = new Приставы.ПриставыDataSetTableAdapters.ОрганизацияTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.организацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресОрганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.организацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // организацияBindingSource
            // 
            this.организацияBindingSource.DataMember = "Организация";
            this.организацияBindingSource.DataSource = this.приставыDataSet;
            // 
            // приставыDataSet
            // 
            this.приставыDataSet.DataSetName = "ПриставыDataSet";
            this.приставыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // организацияTableAdapter
            // 
            this.организацияTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.организацияDataGridViewTextBoxColumn,
            this.адресОрганизацииDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.организацияBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(903, 569);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // организацияDataGridViewTextBoxColumn
            // 
            this.организацияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.организацияDataGridViewTextBoxColumn.DataPropertyName = "Организация";
            this.организацияDataGridViewTextBoxColumn.HeaderText = "Организация";
            this.организацияDataGridViewTextBoxColumn.Name = "организацияDataGridViewTextBoxColumn";
            this.организацияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресОрганизацииDataGridViewTextBoxColumn
            // 
            this.адресОрганизацииDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.адресОрганизацииDataGridViewTextBoxColumn.DataPropertyName = "Адрес организации";
            this.адресОрганизацииDataGridViewTextBoxColumn.HeaderText = "Адрес организации";
            this.адресОрганизацииDataGridViewTextBoxColumn.Name = "адресОрганизацииDataGridViewTextBoxColumn";
            this.адресОрганизацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Организация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 593);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Организация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Организация";
            this.Load += new System.EventHandler(this.Организация_Load);
            ((System.ComponentModel.ISupportInitialize)(this.организацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ПриставыDataSet приставыDataSet;
        private System.Windows.Forms.BindingSource организацияBindingSource;
        private ПриставыDataSetTableAdapters.ОрганизацияTableAdapter организацияTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn организацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресОрганизацииDataGridViewTextBoxColumn;
    }
}