namespace Borromeo_Filomeno_FinalProject
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
            this.chkbox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picbox_Logo = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.errorProviderLogUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLogPass = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogPass)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername_Login
            // 
            this.txtUsername_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername_Login.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername_Login.Location = new System.Drawing.Point(403, 262);
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
            this.txtPassword_Login.Location = new System.Drawing.Point(403, 312);
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
            this.picbox_Password.Location = new System.Drawing.Point(347, 312);
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
            this.picbox_Username.Location = new System.Drawing.Point(347, 262);
            this.picbox_Username.Name = "picbox_Username";
            this.picbox_Username.Size = new System.Drawing.Size(50, 44);
            this.picbox_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Username.TabIndex = 7;
            this.picbox_Username.TabStop = false;
            // 
            // chkbox_ShowPassword
            // 
            this.chkbox_ShowPassword.AutoSize = true;
            this.chkbox_ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkbox_ShowPassword.Font = new System.Drawing.Font("Javanese Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbox_ShowPassword.Location = new System.Drawing.Point(553, 362);
            this.chkbox_ShowPassword.Name = "chkbox_ShowPassword";
            this.chkbox_ShowPassword.Size = new System.Drawing.Size(106, 29);
            this.chkbox_ShowPassword.TabIndex = 8;
            this.chkbox_ShowPassword.Text = "Show Password";
            this.chkbox_ShowPassword.UseVisualStyleBackColor = false;
            this.chkbox_ShowPassword.CheckedChanged += new System.EventHandler(this.chkbox_ShowPassword_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picbox_Logo
            // 
            this.picbox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.picbox_Logo.Image = global::Borromeo_Filomeno_FinalProject.Properties.Resources.logo_transparent1;
            this.picbox_Logo.Location = new System.Drawing.Point(320, 12);
            this.picbox_Logo.Name = "picbox_Logo";
            this.picbox_Logo.Size = new System.Drawing.Size(391, 280);
            this.picbox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Logo.TabIndex = 9;
            this.picbox_Logo.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Location = new System.Drawing.Point(474, 406);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(117, 23);
            this.btnLogIn.TabIndex = 10;
            this.btnLogIn.Text = "Start Gaming";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(434, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Don\'t have an account? ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(553, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 90);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(836, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 90);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(78, 321);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 90);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(836, 301);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 90);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borromeo_Filomeno_FinalProject.Properties.Resources.bg_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 678);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtUsername_Login);
            this.Controls.Add(this.txtPassword_Login);
            this.Controls.Add(this.picbox_Password);
            this.Controls.Add(this.picbox_Username);
            this.Controls.Add(this.chkbox_ShowPassword);
            this.Controls.Add(this.picbox_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.CheckBox chkbox_ShowPassword;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picbox_Logo;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ErrorProvider errorProviderLogUser;
        private System.Windows.Forms.ErrorProvider errorProviderLogPass;
    }
}