using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public partial class LoginForm : Form
    {
        clsDatabase db;       
        clsLogin logIn;
        public LoginForm()
        {
            InitializeComponent();
            db = new clsDatabase();           
            logIn = new clsLogin();
            logIn.accounts = db.GetAccountsInDatabase();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string logInput = txtUsername_Login.Text;
            string password = txtPassword_Login.Text;

            

            if (logInput.Length < 1)
            {
                errorProviderLogInput.SetError(txtUsername_Login, "Please populate this field!");            
            }
            else if (password.Length < 1)
            {
                errorProviderPassword.SetError(txtPassword_Login, "Please populate this field!");
            }
            else
            {
                bool check = logIn.CheckLoginStatus(logInput, password);
                if (check)
                {
                    //Homepage

                    MessageBox.Show("Eek eek... Welcome to homepage");
                    errorProviderLogInput.Dispose();
                    errorProviderPassword.Dispose();
                }
                errorProviderLogInput.Dispose();
                errorProviderPassword.Dispose();
            }
            




        }

        private void chkbox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_ShowPassword.Checked)
                txtPassword_Login.PasswordChar = '\0';
            else
                txtPassword_Login.PasswordChar = '*';
        }
    }
}
