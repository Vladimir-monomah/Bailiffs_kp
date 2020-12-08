namespace Приставы.РегАвт
{
    partial class Авторизация
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Авторизация));
            this.btReg = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btVH = new System.Windows.Forms.Button();
            this.pictureBoxRestart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasswordChangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btReg
            // 
            this.btReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btReg.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReg.Location = new System.Drawing.Point(175, 174);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(284, 38);
            this.btReg.TabIndex = 13;
            this.btReg.Text = "Регистрация";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(248, 88);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(333, 42);
            this.tbPassword.TabIndex = 12;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(248, 31);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(333, 42);
            this.tbLogin.TabIndex = 11;
            // 
            // lbPassword
            // 
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.ForeColor = System.Drawing.Color.Black;
            this.lbPassword.Location = new System.Drawing.Point(36, 94);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(137, 32);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Пароль";
            // 
            // lbLogin
            // 
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.ForeColor = System.Drawing.Color.Black;
            this.lbLogin.Location = new System.Drawing.Point(36, 41);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(99, 32);
            this.lbLogin.TabIndex = 9;
            this.lbLogin.Text = "Логин";
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(475, 174);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(141, 38);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btVH
            // 
            this.btVH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btVH.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btVH.Location = new System.Drawing.Point(12, 178);
            this.btVH.Name = "btVH";
            this.btVH.Size = new System.Drawing.Size(131, 38);
            this.btVH.TabIndex = 7;
            this.btVH.Text = "Вход";
            this.btVH.UseVisualStyleBackColor = true;
            this.btVH.Click += new System.EventHandler(this.btVH_Click);
            // 
            // pictureBoxRestart
            // 
            this.pictureBoxRestart.Image = global::Приставы.Properties.Resources.a6d0f13e933bb67363dfbd6e5da5c374;
            this.pictureBoxRestart.Location = new System.Drawing.Point(580, 136);
            this.pictureBoxRestart.Name = "pictureBoxRestart";
            this.pictureBoxRestart.Size = new System.Drawing.Size(36, 32);
            this.pictureBoxRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRestart.TabIndex = 21;
            this.pictureBoxRestart.TabStop = false;
            this.pictureBoxRestart.Click += new System.EventHandler(this.pictureBoxRestart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Приставы.Properties.Resources.ikonka_7;
            this.pictureBox1.Location = new System.Drawing.Point(541, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PasswordChangeLabel_Click);
            // 
            // PasswordChangeLabel
            // 
            this.PasswordChangeLabel.Location = new System.Drawing.Point(511, 146);
            this.PasswordChangeLabel.Name = "PasswordChangeLabel";
            this.PasswordChangeLabel.Size = new System.Drawing.Size(24, 23);
            this.PasswordChangeLabel.TabIndex = 31;
            this.PasswordChangeLabel.Click += new System.EventHandler(this.PasswordChangeLabel_Click);
            // 
            // Авторизация
            // 
            this.AcceptButton = this.btVH;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 228);
            this.ControlBox = false;
            this.Controls.Add(this.PasswordChangeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxRestart);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btVH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Авторизация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btVH;
        private System.Windows.Forms.PictureBox pictureBoxRestart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PasswordChangeLabel;
    }
}