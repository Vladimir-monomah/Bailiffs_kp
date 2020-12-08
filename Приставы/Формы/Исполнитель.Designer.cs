namespace Приставы.Формы
{
    partial class Исполнитель
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Исполнитель));
            this.отделыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приставыDataSet = new Приставы.ПриставыDataSet();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxISP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.должностиTableAdapter = new Приставы.ПриставыDataSetTableAdapters.ДолжностиTableAdapter();
            this.отделыTableAdapter = new Приставы.ПриставыDataSetTableAdapters.ОтделыTableAdapter();
            this.исполнительЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.исполнительЗапросTableAdapter = new Приставы.ПриставыDataSetTableAdapters.ИсполнительЗапросTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumberPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительЗапросBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // отделыBindingSource
            // 
            this.отделыBindingSource.DataMember = "Отделы";
            this.отделыBindingSource.DataSource = this.приставыDataSet;
            // 
            // приставыDataSet
            // 
            this.приставыDataSet.DataSetName = "ПриставыDataSet";
            this.приставыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.приставыDataSet;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(262, 179);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 39);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(394, 179);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 39);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxISP
            // 
            this.textBoxISP.Location = new System.Drawing.Point(195, 15);
            this.textBoxISP.Multiline = true;
            this.textBoxISP.Name = "textBoxISP";
            this.textBoxISP.Size = new System.Drawing.Size(319, 30);
            this.textBoxISP.TabIndex = 12;
            this.textBoxISP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxISP_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "ФИО";
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // отделыTableAdapter
            // 
            this.отделыTableAdapter.ClearBeforeFill = true;
            // 
            // исполнительЗапросBindingSource
            // 
            this.исполнительЗапросBindingSource.DataMember = "ИсполнительЗапрос";
            this.исполнительЗапросBindingSource.DataSource = this.приставыDataSet;
            // 
            // исполнительЗапросTableAdapter
            // 
            this.исполнительЗапросTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер телефона";
            // 
            // tbNumberPhone
            // 
            this.tbNumberPhone.Location = new System.Drawing.Point(194, 69);
            this.tbNumberPhone.MaxLength = 11;
            this.tbNumberPhone.Multiline = true;
            this.tbNumberPhone.Name = "tbNumberPhone";
            this.tbNumberPhone.Size = new System.Drawing.Size(319, 30);
            this.tbNumberPhone.TabIndex = 12;
            this.tbNumberPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumberPhone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Номер участка";
            // 
            // tbNomer
            // 
            this.tbNomer.Location = new System.Drawing.Point(194, 129);
            this.tbNomer.MaxLength = 4;
            this.tbNomer.Multiline = true;
            this.tbNomer.Name = "tbNomer";
            this.tbNomer.Size = new System.Drawing.Size(319, 30);
            this.tbNomer.TabIndex = 12;
            this.tbNomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumberPhone_KeyPress);
            // 
            // Исполнитель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 243);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tbNomer);
            this.Controls.Add(this.tbNumberPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxISP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Исполнитель";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Исполнитель";
            this.Load += new System.EventHandler(this.Исполнитель_Load);
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.исполнительЗапросBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxISP;
        private System.Windows.Forms.Label label1;
        private ПриставыDataSet приставыDataSet;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private ПриставыDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.BindingSource отделыBindingSource;
        private ПриставыDataSetTableAdapters.ОтделыTableAdapter отделыTableAdapter;
        private System.Windows.Forms.BindingSource исполнительЗапросBindingSource;
        private ПриставыDataSetTableAdapters.ИсполнительЗапросTableAdapter исполнительЗапросTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumberPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNomer;
    }
}