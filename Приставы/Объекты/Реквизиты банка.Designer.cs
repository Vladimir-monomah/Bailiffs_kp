namespace Приставы.Объекты
{
    partial class Реквизиты_Банка
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Реквизиты_Банка));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.приставыDataSet = new Приставы.ПриставыDataSet();
            this.реквизитыБанкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.реквизиты_банкаTableAdapter = new Приставы.ПриставыDataSetTableAdapters.Реквизиты_банкаTableAdapter();
            this.названиеБанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бИКБанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иННБанкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.реквизитыБанкаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеБанкаDataGridViewTextBoxColumn,
            this.бИКБанкаDataGridViewTextBoxColumn,
            this.иННБанкаDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.реквизитыБанкаBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(903, 569);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // приставыDataSet
            // 
            this.приставыDataSet.DataSetName = "ПриставыDataSet";
            this.приставыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // реквизитыБанкаBindingSource
            // 
            this.реквизитыБанкаBindingSource.DataMember = "Реквизиты банка";
            this.реквизитыБанкаBindingSource.DataSource = this.приставыDataSet;
            // 
            // реквизиты_банкаTableAdapter
            // 
            this.реквизиты_банкаTableAdapter.ClearBeforeFill = true;
            // 
            // названиеБанкаDataGridViewTextBoxColumn
            // 
            this.названиеБанкаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.названиеБанкаDataGridViewTextBoxColumn.DataPropertyName = "Название банка";
            this.названиеБанкаDataGridViewTextBoxColumn.HeaderText = "Название банка";
            this.названиеБанкаDataGridViewTextBoxColumn.Name = "названиеБанкаDataGridViewTextBoxColumn";
            this.названиеБанкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // бИКБанкаDataGridViewTextBoxColumn
            // 
            this.бИКБанкаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.бИКБанкаDataGridViewTextBoxColumn.DataPropertyName = "БИК банка";
            this.бИКБанкаDataGridViewTextBoxColumn.HeaderText = "БИК банка";
            this.бИКБанкаDataGridViewTextBoxColumn.Name = "бИКБанкаDataGridViewTextBoxColumn";
            this.бИКБанкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // иННБанкаDataGridViewTextBoxColumn
            // 
            this.иННБанкаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.иННБанкаDataGridViewTextBoxColumn.DataPropertyName = "ИНН банка";
            this.иННБанкаDataGridViewTextBoxColumn.HeaderText = "ИНН банка";
            this.иННБанкаDataGridViewTextBoxColumn.Name = "иННБанкаDataGridViewTextBoxColumn";
            this.иННБанкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Реквизиты_банка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 593);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Реквизиты_банка";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реквизиты банка";
            this.Load += new System.EventHandler(this.Реквизиты_банка_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.реквизитыБанкаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private ПриставыDataSet приставыDataSet;
        private System.Windows.Forms.BindingSource реквизитыБанкаBindingSource;
        private ПриставыDataSetTableAdapters.Реквизиты_банкаTableAdapter реквизиты_банкаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеБанкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бИКБанкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иННБанкаDataGridViewTextBoxColumn;
    }
}