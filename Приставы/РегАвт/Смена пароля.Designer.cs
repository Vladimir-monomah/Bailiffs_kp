namespace Приставы.РегАвт
{
    partial class Смена_пароля
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Смена_пароля));
            this.label1 = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswprdLabel = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxRepeatNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 39);
            this.label1.TabIndex = 38;
            this.label1.Text = "Повторите новый пароль";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordLabel.Location = new System.Drawing.Point(12, 125);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(154, 39);
            this.newPasswordLabel.TabIndex = 39;
            this.newPasswordLabel.Text = "Новый пароль";
            // 
            // oldPasswprdLabel
            // 
            this.oldPasswprdLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPasswprdLabel.Location = new System.Drawing.Point(12, 69);
            this.oldPasswprdLabel.Name = "oldPasswprdLabel";
            this.oldPasswprdLabel.Size = new System.Drawing.Size(184, 39);
            this.oldPasswprdLabel.TabIndex = 40;
            this.oldPasswprdLabel.Text = "Старый пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(12, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(100, 39);
            this.labelLogin.TabIndex = 37;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxRepeatNewPassword
            // 
            this.textBoxRepeatNewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRepeatNewPassword.Location = new System.Drawing.Point(270, 184);
            this.textBoxRepeatNewPassword.MaxLength = 15;
            this.textBoxRepeatNewPassword.Multiline = true;
            this.textBoxRepeatNewPassword.Name = "textBoxRepeatNewPassword";
            this.textBoxRepeatNewPassword.PasswordChar = '*';
            this.textBoxRepeatNewPassword.Size = new System.Drawing.Size(183, 39);
            this.textBoxRepeatNewPassword.TabIndex = 44;
            this.textBoxRepeatNewPassword.Tag = "";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(270, 122);
            this.textBoxNewPassword.MaxLength = 15;
            this.textBoxNewPassword.Multiline = true;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(183, 39);
            this.textBoxNewPassword.TabIndex = 43;
            this.textBoxNewPassword.Tag = "";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOldPassword.Location = new System.Drawing.Point(270, 66);
            this.textBoxOldPassword.MaxLength = 15;
            this.textBoxOldPassword.Multiline = true;
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(183, 39);
            this.textBoxOldPassword.TabIndex = 42;
            this.textBoxOldPassword.Tag = "";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(270, 6);
            this.textBoxLogin.MaxLength = 15;
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(183, 39);
            this.textBoxLogin.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(281, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 54);
            this.button2.TabIndex = 47;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 54);
            this.button1.TabIndex = 46;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(270, 229);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(163, 25);
            this.checkBoxShowPassword.TabIndex = 45;
            this.checkBoxShowPassword.Text = "Показать пароль";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // Смена_пароля
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 349);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.textBoxRepeatNewPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.oldPasswprdLabel);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Смена_пароля";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label oldPasswprdLabel;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxRepeatNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}