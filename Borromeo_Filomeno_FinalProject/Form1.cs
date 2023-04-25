using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public partial class Register_Form : Form
    {
        clsRegister accounts = new clsRegister();

       
        
        public Register_Form()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword_Register.PasswordChar = '*';

            //Testing purposes
            accounts.AddAccount("harold", "mouz@321", "@gmail.com");
            
        }

        private void chkbox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_ShowPassword.Checked == false)
            {
                txtPassword_Register.PasswordChar =  '*';
            }
            else
            {
                txtPassword_Register.PasswordChar = '\0';
            }

                
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string username = txtUsername_Register.Text;
            string password = txtPassword_Register.Text;
            string email = txtEmail_Register.Text;

            int errorUser = int.Parse(errorProviderUsername.Tag.ToString());
            int errorPass = int.Parse(errorProviderPassword.Tag.ToString());
            int errorEmail = int.Parse(errorProviderEmail.Tag.ToString());


            if (errorUser == 0 || errorPass == 0 || errorEmail == 0)
            {

                errorProviderEmail.SetError(txtEmail_Register, "Email cannot be empty!");
                errorProviderPassword.SetError(txtPassword_Register, "Password cannot be empty!");
                errorProviderUsername.SetError(txtUsername_Register, "Username cannot be empty!");

            }
             
            if (errorUser == 3 || txtUsername_Register.Text.Length == 0)
            {
                errorProviderUsername.SetError(txtUsername_Register, "Username cannot be empty!");
            }
            else
            {
                errorProviderUsername.Dispose();
            }
             
            if (errorPass == 3 || txtPassword_Register.Text.Length == 0)
            {
                errorProviderPassword.SetError(txtPassword_Register, "Password cannot be empty!");
            }
            else
            {
                errorProviderPassword.Dispose();
            }
          
            if (errorEmail == 3 || txtEmail_Register.Text.Length == 0)
            {
                errorProviderEmail.SetError(txtEmail_Register, "Email cannot be empty!");

            }
            else
            {
                errorProviderEmail.Dispose();
            }

            if (errorUser == 1 && errorPass == 1 && errorEmail == 1)
            {
                accounts.AddAccount(username, password, email);
                errorProviderEmail.Dispose();
                errorProviderPassword.Dispose();
                errorProviderUsername.Dispose();

                MessageBox.Show("Account Created");
            }
            else
            {
                MessageBox.Show("Invalid Registeration!");
            }




        }

        private void txtPassword_Register_TextChanged(object sender, EventArgs e)
        {
            bool check = Regex.IsMatch(txtPassword_Register.Text, "[!@#$%^&*`\"()_+[{}\\],./;':|?/<>=-]");

            

            if (txtPassword_Register.Text.Length < 8)
            {
                
                if (!check)
                {
                    errorProviderPassword.SetError(txtPassword_Register, "Use at least 1 special character and password must be at least 8 characters long!");
                    errorProviderPassword.Tag = "0";
                }
                

                if (txtPassword_Register.Text.Contains(' '))
                {
                    errorProviderPassword.SetError(txtPassword_Register, "Do not use space please");
                    errorProviderPassword.Tag = "0";


                }

                errorProviderPassword.SetError(txtPassword_Register, "Password must be at least 8 characters long");
                errorProviderPassword.Tag = "0";


            }
            else
            {

                if (!check)
                {
                    errorProviderPassword.SetError(txtPassword_Register, "Use at least 1 special character!");
                    errorProviderPassword.Tag = "0";

                }
                else
                {
                    errorProviderPassword.Dispose();
                    errorProviderPassword.Tag = "1";

                }

                if (txtPassword_Register.Text.Contains(' '))
                {
                    errorProviderPassword.SetError(txtPassword_Register, "Do not use space please");
                    errorProviderPassword.Tag = "0";


                }
            }

            if (txtPassword_Register.TextLength == 0)
            {
                errorProviderPassword.Tag = "0";
                errorProviderPassword.Dispose();
            }

            
        }

        private void txtUsername_Register_TextChanged(object sender, EventArgs e)
        {

            bool check = Regex.IsMatch(txtUsername_Register.Text, "[!@#$%^&*`\"()_+[{}\\],./;':|?/<>=-]");


            bool checkUser = accounts.IsUserExists(txtUsername_Register.Text);

            if (txtUsername_Register.Text.Length == 0)
            {
                errorProviderUsername.Tag = "0";
            }
            

            if (check)
            {
                errorProviderUsername.SetError(txtUsername_Register, "No special characters please!");
                errorProviderUsername.Tag = "0";

            }
            else
            {
                errorProviderUsername.Dispose();
                errorProviderUsername.Tag = "1";
            }

            if (txtUsername_Register.Text.Contains(' '))
            {
                errorProviderUsername.SetError(txtUsername_Register, "Do not use space please");
                errorProviderUsername.Tag = "0";
            }
            

            if (checkUser)
            {
                errorProviderUsername.SetError(txtUsername_Register, "Username is already taken!");
                errorProviderUsername.Tag = "0";
            }



        }

        private void txtEmail_Register_TextChanged(object sender, EventArgs e)
        {
            //For legit verification for formatting emails
            //bool check = Regex.IsMatch(txtEmail_Register.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            
            bool check = Regex.IsMatch(txtEmail_Register.Text, "[!#$%^&*`\"()_+[{}\\],/;':|?/<>=-]$");

           



            if (check)
            {
                errorProviderEmail.SetError(txtEmail_Register, "Invalid email!");
                errorProviderEmail.Tag = "0";

            }
            else
            {
                errorProviderEmail.Dispose();
                errorProviderEmail.Tag = "1";
            }


            if (txtEmail_Register.Text.Contains(' '))
            {
                errorProviderEmail.SetError(txtEmail_Register, "Do not use space please");
                errorProviderEmail.Tag = "0";

            }

            
            if (txtEmail_Register.Text.Length == 0)
            {
                errorProviderEmail.Tag = "0";
            }

        }
    }
}
