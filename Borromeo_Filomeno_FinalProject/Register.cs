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
        List<clsAccount> accounts;
        clsDatabase db;
        clsRegister account_Register;
        bool isPasswordValid = false;
        bool isUsernameValid = false;
        bool isEmailValid = false;
        public Register_Form()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword_Register.PasswordChar = '*';
            db = new clsDatabase();
            account_Register = new clsRegister();
            accounts = new List<clsAccount>(db.GetAccountsInDatabase());

            //accounts.Add(new clsAccount() { Username = "Harold", Email = "wtf@gmail.com", Password = "Secret" });
            //accounts.Add(new clsAccount() { Username = "Afterparty", Email = "zzz@gmail.com", Password = "Secret" });
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
            // opens the login form
            var login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            // registers the user
            if (!isPasswordValid || !isUsernameValid || !isEmailValid)
            {
                MessageBox.Show("Register Invalid");
            }
            else
            {
                string username = txtUsername_Register.Text;
                string password = txtPassword_Register.Text;
                string email = txtEmail_Register.Text;

                accounts.Add(new clsAccount(username, password, email));
             
                db.ImportAccountsToDatabase(accounts);

                MessageBox.Show("Done");
                chkbox_ShowPassword.Checked = false;
                txtUsername_Register.Clear();
                txtPassword_Register.Clear();
                txtEmail_Register.Clear();
                errorProviderEmail.Dispose();
                errorProviderPassword.Dispose();
                errorProviderUsername.Dispose();
            }


        }

        private void txtPassword_Register_TextChanged(object sender, EventArgs e)
        {
            

            isPasswordValid = account_Register.IsPasswordValid(errorProviderPassword, txtPassword_Register);


        }

        private void txtUsername_Register_TextChanged(object sender, EventArgs e)
        {

           
            isUsernameValid = account_Register.IsUsernameValid(errorProviderUsername, txtUsername_Register);


        }

        private void txtEmail_Register_TextChanged(object sender, EventArgs e)
        {

            isEmailValid = account_Register.IsEmailValid(errorProviderEmail, txtEmail_Register);

        }
    }
}
