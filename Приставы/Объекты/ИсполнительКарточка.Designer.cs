namespace Приставы.Объекты
{
    partial class ИсполнительКарточка
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ИсполнительКарточка));
            this.PR_ISPFilterTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button38 = new System.Windows.Forms.Button();
            this.PR_ISPDataGridView = new System.Windows.Forms.DataGridView();
            this.приставыDataSet = new Приставы.ПриставыDataSet();
            this.исполнительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.исполнительTableAdapter = new Приставы.ПриставыDataSetTableAdapters.ИсполнительTableAdapter();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PR_ISPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PR_ISPFilterTextBox
            // 
            this.PR_ISPFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PR_ISPFilterTextBox.Location = new System.Drawing.Point(76, 12);
            this.PR_ISPFilterTextBox.MaxLength = 30;
            this.PR_ISPFilterTextBox.Multiline = true;
            this.PR_ISPFilterTextBox.Name = "PR_ISPFilterTextBox";
            this.PR_ISPFilterTextBox.Size = new System.Drawing.Size(759, 30);
            this.PR_ISPFilterTextBox.TabIndex = 48;
            this.PR_ISPFilterTextBox.TextChanged += new System.EventHandler(this.PR_ISPFilterTextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 21);
            this.label16.TabIndex = 47;
            this.label16.Text = "Поиск";
            // 
            // button38
            // 
            this.button38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button38.Image = global::Приставы.Properties.Resources.кнопка_3;
            this.button38.Location = new System.Drawing.Point(841, 10);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(32, 30);
            this.button38.TabIndex = 46;
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // PR_ISPDataGridView
            // 
            this.PR_ISPDataGridView.AutoGenerateColumns = false;
            this.PR_ISPDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PR_ISPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PR_ISPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn});
            this.PR_ISPDataGridView.DataSource = this.исполнительBindingSource;
            this.PR_ISPDataGridView.Location = new System.Drawing.Point(10, 48);
            this.PR_ISPDataGridView.Name = "PR_ISPDataGridView";
            this.PR_ISPDataGridView.RowTemplate.Height = 24;
            this.PR_ISPDataGridView.Size = new System.Drawing.Size(863, 442);
            this.PR_ISPDataGridView.TabIndex = 49;
            this.PR_ISPDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PR_ISPDataGridView_CellDoubleClick);
            // 
            // приставыDataSet
            // 
            this.приставыDataSet.DataSetName = "ПриставыDataSet";
            this.приставыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // исполнительBindingSource
            // 
            this.исполнительBindingSource.DataMember = "Исполнитель";
            this.исполнительBindingSource.DataSource = this.приставыDataSet;
            // 
            // исполнительTableAdapter
            // 
            this.исполнительTableAdapter.ClearBeforeFill = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Исполнитель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 502);
            this.Controls.Add(this.PR_ISPDataGridView);
            this.Controls.Add(this.PR_ISPFilterTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button38);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Исполнитель";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Исполнитель";
            this.Load += new System.EventHandler(this.Исполнитель_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PR_ISPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PR_ISPFilterTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.DataGridView PR_ISPDataGridView;
        private ПриставыDataSet приставыDataSet;
        private System.Windows.Forms.BindingSource исполнительBindingSource;
        private ПриставыDataSetTableAdapters.ИсполнительTableAdapter исполнительTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
    }
}