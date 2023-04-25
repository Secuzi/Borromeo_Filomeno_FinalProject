using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Borromeo_Filomeno_FinalProject
{
    public partial class LoginForm : Form
    {
        public string Username_Login;
        public string Password_Login;

        public List<clsAccount> log_Accounts;

        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void chkbox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_ShowPassword.Checked)
            {
                txtPassword_Login.PasswordChar = '\0';
            }
            else
            {
                txtPassword_Login.PasswordChar = '*';
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            bool checkLogIfAccountExists = log_Accounts.Any(a => a.Username == txtUsername_Login.Text);

            if (checkLogIfAccountExists)
            {
                clsAccount test = log_Accounts.Find(b => b.Username == txtUsername_Login.Text);


                string checkedIfValidLog = test.CheckLoginStatus(txtUsername_Login.Text, txtPassword_Login.Text);

                MessageBox.Show(checkedIfValidLog, "Yoo");

            }
            else
            {
                MessageBox.Show("Account does not exist!");
            }







            //if (txtUsername_Login.Text != Username_Login)
            //{
            //    MessageBox.Show("Invalid Username!");
            //}

            //if (txtPassword_Login.Text != Password_Login && txtUsername_Login.Text == Username_Login)
            //{
            //    MessageBox.Show("Wrong Password!");
            //}

            //if (txtUsername_Login.Text == Username_Login && txtPassword_Login.Text == Password_Login)
            //{
            //    MessageBox.Show("Welcome to Compound Games!");
            //}


        }
    }
}
