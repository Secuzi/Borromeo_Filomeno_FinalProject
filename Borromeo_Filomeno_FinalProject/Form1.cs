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
            int errorPass = int.Parse(errorProviderRegister.Tag.ToString());
            int errorEmail = int.Parse(errorProviderEmail.Tag.ToString());


            if (errorUser == 0 || errorPass == 0 || errorEmail == 0)
            {
                MessageBox.Show("Invalid Registration");
            }
            else
                accounts.AddAccount(username, password, email);




        }

        private void txtPassword_Register_TextChanged(object sender, EventArgs e)
        {
            bool check = Regex.IsMatch(txtPassword_Register.Text, "[!@#$%^&*\"()_+[{}\\],./;':|?/<>=-]");

            

            if (txtPassword_Register.Text.Length < 8)
            {
                
                if (!check)
                {
                    errorProviderRegister.SetError(txtPassword_Register, "Use at least 1 special character and password must be at least 8 characters long!");
                    errorProviderRegister.Tag = "0";
                }
                

                if (txtPassword_Register.Text.Contains(' '))
                {
                    errorProviderRegister.SetError(txtPassword_Register, "Do not use space please");
                    errorProviderRegister.Tag = "0";


                }

                errorProviderRegister.SetError(txtPassword_Register, "Password must be at least 8 characters long");
                errorProviderRegister.Tag = "0";


            }
            else
            {

                if (!check)
                {
                    errorProviderRegister.SetError(txtPassword_Register, "Use at least 1 special character!");
                    errorProviderRegister.Tag = "0";

                }
                else
                {
                    errorProviderRegister.Dispose();
                    errorProviderRegister.Tag = "1";

                }

                if (txtPassword_Register.Text.Contains(' '))
                {
                    errorProviderRegister.SetError(txtPassword_Register, "Do not use space please");
                    errorProviderRegister.Tag = "0";


                }
            }

            if (txtPassword_Register == null || txtPassword_Register.TextLength == 0)
            {
                errorProviderRegister.Dispose();
            }

            
        }

        private void txtUsername_Register_TextChanged(object sender, EventArgs e)
        {

            bool check = Regex.IsMatch(txtUsername_Register.Text, "[!@#$%^&*\"()_+[{}\\],./;':|?/<>=-]");


            bool checkUser = accounts.IsUserExists(txtUsername_Register.Text);

            

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

            if (!txtEmail_Register.Text.Contains('@'))
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
                errorProviderEmail.Dispose();
            }

        }
    }
}
