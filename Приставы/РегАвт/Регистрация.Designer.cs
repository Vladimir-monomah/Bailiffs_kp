namespace Приставы.РегАвт
{
    partial class Регистрация
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Регистрация));
            this.btRegistration = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbDol = new System.Windows.Forms.TextBox();
            this.tbPatronomic = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbDol = new System.Windows.Forms.Label();
            this.lbPatronomic = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRegistration
            // 
            this.btRegistration.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRegistration.Location = new System.Drawing.Point(29, 383);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(456, 62);
            this.btRegistration.TabIndex = 25;
            this.btRegistration.Text = "Зарегистрироваться";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(230, 318);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(255, 34);
            this.tbPassword.TabIndex = 24;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(230, 255);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(255, 34);
            this.tbLogin.TabIndex = 23;
            // 
            // tbDol
            // 
            this.tbDol.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDol.Location = new System.Drawing.Point(230, 194);
            this.tbDol.Multiline = true;
            this.tbDol.Name = "tbDol";
            this.tbDol.Size = new System.Drawing.Size(255, 34);
            this.tbDol.TabIndex = 22;
            // 
            // tbPatronomic
            // 
            this.tbPatronomic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPatronomic.Location = new System.Drawing.Point(230, 137);
            this.tbPatronomic.Multiline = true;
            this.tbPatronomic.Name = "tbPatronomic";
            this.tbPatronomic.Size = new System.Drawing.Size(255, 34);
            this.tbPatronomic.TabIndex = 21;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(230, 78);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(255, 34);
            this.tbName.TabIndex = 20;
            // 
            // tbSername
            // 
            this.tbSername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSername.Location = new System.Drawing.Point(230, 20);
            this.tbSername.Multiline = true;
            this.tbSername.Name = "tbSername";
            this.tbSername.Size = new System.Drawing.Size(255, 34);
            this.tbSername.TabIndex = 19;
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.Location = new System.Drawing.Point(24, 318);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(136, 35);
            this.lbPassword.TabIndex = 18;
            this.lbPassword.Text = "Пароль";
            // 
            // lbLogin
            // 
            this.lbLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(24, 255);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(136, 32);
            this.lbLogin.TabIndex = 17;
            this.lbLogin.Text = "Логин";
            // 
            // lbDol
            // 
            this.lbDol.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDol.Location = new System.Drawing.Point(24, 194);
            this.lbDol.Name = "lbDol";
            this.lbDol.Size = new System.Drawing.Size(155, 35);
            this.lbDol.TabIndex = 16;
            this.lbDol.Text = "Должность";
            // 
            // lbPatronomic
            // 
            this.lbPatronomic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPatronomic.Location = new System.Drawing.Point(24, 130);
            this.lbPatronomic.Name = "lbPatronomic";
            this.lbPatronomic.Size = new System.Drawing.Size(136, 37);
            this.lbPatronomic.TabIndex = 15;
            this.lbPatronomic.Text = "Отчество";
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(24, 78);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(102, 42);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Имя";
            // 
            // lbSername
            // 
            this.lbSername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSername.Location = new System.Drawing.Point(24, 20);
            this.lbSername.Name = "lbSername";
            this.lbSername.Size = new System.Drawing.Size(136, 46);
            this.lbSername.TabIndex = 13;
            this.lbSername.Text = "Фамилия";
            // 
            // Регистрация
            // 
            this.AcceptButton = this.btRegistration;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 465);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbDol);
            this.Controls.Add(this.tbPatronomic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbDol);
            this.Controls.Add(this.lbPatronomic);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Регистрация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegistration;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbDol;
        private System.Windows.Forms.TextBox tbPatronomic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbDol;
        private System.Windows.Forms.Label lbPatronomic;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSername;
    }
}