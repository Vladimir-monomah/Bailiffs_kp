namespace Приставы.Формы
{
    partial class Новая_должность
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Новая_должность));
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.приставыDataSet = new Приставы.ПриставыDataSet();
            this.отделыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отделыTableAdapter = new Приставы.ПриставыDataSetTableAdapters.ОтделыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DataSource = this.отделыBindingSource;
            this.departmentComboBox.DisplayMember = "Наименование";
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(274, 94);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(252, 24);
            this.departmentComboBox.TabIndex = 9;
            this.departmentComboBox.ValueMember = "№ отдела";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(274, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(400, 135);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 39);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxDol
            // 
            this.textBoxDol.Location = new System.Drawing.Point(274, 25);
            this.textBoxDol.Multiline = true;
            this.textBoxDol.Name = "textBoxDol";
            this.textBoxDol.Size = new System.Drawing.Size(252, 30);
            this.textBoxDol.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(46, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Название отдела";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название должности";
            // 
            // приставыDataSet
            // 
            this.приставыDataSet.DataSetName = "ПриставыDataSet";
            this.приставыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отделыBindingSource
            // 
            this.отделыBindingSource.DataMember = "Отделы";
            this.отделыBindingSource.DataSource = this.приставыDataSet;
            // 
            // отделыTableAdapter
            // 
            this.отделыTableAdapter.ClearBeforeFill = true;
            // 
            // Новая_должность
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 211);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Новая_должность";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая должность";
            this.Load += new System.EventHandler(this.Новая_должность_Load);
            ((System.ComponentModel.ISupportInitialize)(this.приставыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxDol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ПриставыDataSet приставыDataSet;
        private System.Windows.Forms.BindingSource отделыBindingSource;
        private ПриставыDataSetTableAdapters.ОтделыTableAdapter отделыTableAdapter;
    }
}