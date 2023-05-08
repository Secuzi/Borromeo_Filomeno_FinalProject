﻿namespace Borromeo_Filomeno_FinalProject
{
    partial class LoginForm
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
            this.txtUsername_Login = new System.Windows.Forms.TextBox();
            this.txtPassword_Login = new System.Windows.Forms.TextBox();
            this.picbox_Password = new System.Windows.Forms.PictureBox();
            this.picbox_Username = new System.Windows.Forms.PictureBox();
            this.picbox_Logo = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderLogUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLogPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateaccount = new System.Windows.Forms.Button();
            this.chkbox_ShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogPass)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername_Login
            // 
            this.txtUsername_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername_Login.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername_Login.Location = new System.Drawing.Point(427, 300);
            this.txtUsername_Login.Name = "txtUsername_Login";
            this.txtUsername_Login.Size = new System.Drawing.Size(256, 37);
            this.txtUsername_Login.TabIndex = 4;
            this.txtUsername_Login.Tag = "3";
            this.txtUsername_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword_Login
            // 
            this.txtPassword_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword_Login.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword_Login.Location = new System.Drawing.Point(427, 350);
            this.txtPassword_Login.Name = "txtPassword_Login";
            this.txtPassword_Login.PasswordChar = '*';
            this.txtPassword_Login.Size = new System.Drawing.Size(256, 37);
            this.txtPassword_Login.TabIndex = 5;
            this.txtPassword_Login.Tag = "3";
            this.txtPassword_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picbox_Password
            // 
            this.picbox_Password.BackColor = System.Drawing.Color.Transparent;
            this.picbox_Password.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.password;
            this.picbox_Password.Location = new System.Drawing.Point(371, 350);
            this.picbox_Password.Name = "picbox_Password";
            this.picbox_Password.Size = new System.Drawing.Size(50, 44);
            this.picbox_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Password.TabIndex = 6;
            this.picbox_Password.TabStop = false;
            // 
            // picbox_Username
            // 
            this.picbox_Username.BackColor = System.Drawing.Color.Transparent;
            this.picbox_Username.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.username;
            this.picbox_Username.Location = new System.Drawing.Point(371, 300);
            this.picbox_Username.Name = "picbox_Username";
            this.picbox_Username.Size = new System.Drawing.Size(50, 44);
            this.picbox_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Username.TabIndex = 7;
            this.picbox_Username.TabStop = false;
            // 
            // picbox_Logo
            // 
            this.picbox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.picbox_Logo.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.bg_gif_transparent;
            this.picbox_Logo.Location = new System.Drawing.Point(258, 12);
            this.picbox_Logo.Name = "picbox_Logo";
            this.picbox_Logo.Size = new System.Drawing.Size(540, 399);
            this.picbox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Logo.TabIndex = 9;
            this.picbox_Logo.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(461, 431);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(139, 42);
            this.btnLogIn.TabIndex = 10;
            this.btnLogIn.Text = "Start Gaming";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(354, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Don\'t have an account? ";
            // 
            // errorProviderLogUser
            // 
            this.errorProviderLogUser.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLogUser.ContainerControl = this;
            // 
            // errorProviderLogPass
            // 
            this.errorProviderLogPass.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLogPass.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(627, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 13;
            // 
            // btnCreateaccount
            // 
            this.btnCreateaccount.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateaccount.FlatAppearance.BorderSize = 0;
            this.btnCreateaccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.btnCreateaccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(69)))), ((int)(((byte)(100)))));
            this.btnCreateaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateaccount.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateaccount.Location = new System.Drawing.Point(540, 475);
            this.btnCreateaccount.Name = "btnCreateaccount";
            this.btnCreateaccount.Size = new System.Drawing.Size(175, 42);
            this.btnCreateaccount.TabIndex = 14;
            this.btnCreateaccount.Text = "Create Account";
            this.btnCreateaccount.UseVisualStyleBackColor = false;
            this.btnCreateaccount.Click += new System.EventHandler(this.btnCreateaccount_Click);
            // 
            // chkbox_ShowPassword
            // 
            this.chkbox_ShowPassword.AutoSize = true;
            this.chkbox_ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkbox_ShowPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbox_ShowPassword.Location = new System.Drawing.Point(576, 392);
            this.chkbox_ShowPassword.Name = "chkbox_ShowPassword";
            this.chkbox_ShowPassword.Size = new System.Drawing.Size(109, 19);
            this.chkbox_ShowPassword.TabIndex = 15;
            this.chkbox_ShowPassword.Text = "Show Password";
            this.chkbox_ShowPassword.UseVisualStyleBackColor = false;
            this.chkbox_ShowPassword.CheckedChanged += new System.EventHandler(this.chkbox_ShowPassword_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borromeo_Filomeno_FinalProject.Properties.Resources.bg_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 608);
            this.Controls.Add(this.chkbox_ShowPassword);
            this.Controls.Add(this.btnCreateaccount);
            this.Controls.Add(this.txtUsername_Login);
            this.Controls.Add(this.txtPassword_Login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.picbox_Password);
            this.Controls.Add(this.picbox_Username);
            this.Controls.Add(this.picbox_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername_Login;
        private System.Windows.Forms.TextBox txtPassword_Login;
        private System.Windows.Forms.PictureBox picbox_Password;
        private System.Windows.Forms.PictureBox picbox_Username;
        private System.Windows.Forms.PictureBox picbox_Logo;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderLogUser;
        private System.Windows.Forms.ErrorProvider errorProviderLogPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkbox_ShowPassword;
        private System.Windows.Forms.Button btnCreateaccount;
    }
}