namespace Приставы.Формы
{
    partial class Реквизиты_банка
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Реквизиты_банка));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tbINNBank = new System.Windows.Forms.TextBox();
            this.tbBIKBank = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameBank = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(262, 180);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 39);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(394, 180);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 39);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tbINNBank
            // 
            this.tbINNBank.Location = new System.Drawing.Point(195, 125);
            this.tbINNBank.MaxLength = 4;
            this.tbINNBank.Multiline = true;
            this.tbINNBank.Name = "tbINNBank";
            this.tbINNBank.Size = new System.Drawing.Size(319, 30);
            this.tbINNBank.TabIndex = 18;
            this.tbINNBank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBIKBank_KeyPress);
            // 
            // tbBIKBank
            // 
            this.tbBIKBank.Location = new System.Drawing.Point(195, 65);
            this.tbBIKBank.MaxLength = 11;
            this.tbBIKBank.Multiline = true;
            this.tbBIKBank.Name = "tbBIKBank";
            this.tbBIKBank.Size = new System.Drawing.Size(319, 30);
            this.tbBIKBank.TabIndex = 19;
            this.tbBIKBank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBIKBank_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "ИНН банка";
            // 
            // textBoxNameBank
            // 
            this.textBoxNameBank.Location = new System.Drawing.Point(196, 11);
            this.textBoxNameBank.Multiline = true;
            this.textBoxNameBank.Name = "textBoxNameBank";
            this.textBoxNameBank.Size = new System.Drawing.Size(319, 30);
            this.textBoxNameBank.TabIndex = 20;
            this.textBoxNameBank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameBank_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "БИК банка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название банка";
            // 
            // Реквизиты_банка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 243);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tbINNBank);
            this.Controls.Add(this.tbBIKBank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNameBank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Реквизиты_банка";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реквизиты банка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox tbINNBank;
        private System.Windows.Forms.TextBox tbBIKBank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}