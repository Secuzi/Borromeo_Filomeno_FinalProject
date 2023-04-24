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
        clsAccount test;
        
        public Register_Form()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword_Register.PasswordChar = '*';
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

            





        }

        private void txtPassword_Register_TextChanged(object sender, EventArgs e)
        {
            bool check = Regex.IsMatch(txtPassword_Register.Text, "[!@#$%^&*\"()_+[{}\\],./;':|?/<>=-]");


            if (txtPassword_Register.Text.Length < 8)
            {
                
                if (!check)
                {
                    errorProviderAll.SetError(txtPassword_Register, "Use at least 1 special character and password must be at least 8 characters long!");
                }
                

                if (txtPassword_Register.Text.Contains(' '))
                {
                    errorProviderAll.SetError(txtPassword_Register, "Do not use space please");
                }

                errorProviderAll.SetError(txtPassword_Register, "Password must be at least 8 characters long");

            }
            else
            {

                if (!check)
                {
                    errorProviderAll.SetError(txtPassword_Register, "Use at least 1 special character!");
                }
                else
                {
                    errorProviderAll.Dispose();
                }

                if (txtPassword_Register.Text.Contains(' '))
                {
                    errorProviderAll.SetError(txtPassword_Register, "Do not use space please");
                }
            }



            if (txtPassword_Register == null || txtPassword_Register.TextLength == 0)
            {
                errorProviderAll.Dispose();
            }


        }

        private void txtUsername_Register_TextChanged(object sender, EventArgs e)
        {

            bool check = Regex.IsMatch(txtUsername_Register.Text, "[!@#$%^&*\"()_+[{}\\],./;':|?/<>=-]");

            if (check)
            {
                errorProviderAll.SetError(txtUsername_Register, "No special characters please!");

            }
            else
            {
                errorProviderAll.Dispose();
            }

            if (txtUsername_Register.Text.Contains(' '))
            {
                errorProviderAll.SetError(txtUsername_Register, "Do not use space please");
            }



        }
    }
}
