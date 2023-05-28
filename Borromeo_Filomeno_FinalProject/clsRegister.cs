using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public class clsRegister : clsAccount
    {
        
       

        
        public clsRegister()
        {
            clsFile db = new clsFile();
            accounts = db.GetAccountsinFile();
        }
        
        public bool IsPasswordValid(ErrorProvider errorChangePass, TextBox txtChangePass)
        {
            //For Password
            bool check = Regex.IsMatch(txtChangePass.Text, "[!@#$%^&*`\"()_+[{}\\],./;':|?/<>=-]");



            if (txtChangePass.Text.Length < 8 && txtChangePass.Text.Length > 0)
            {

                if (!check && !txtChangePass.Text.Contains(""))
                {
                    errorChangePass.SetError(txtChangePass, "Use at least 1 special character and password must be at least 8 characters long!");
                    errorChangePass.Tag = "0";
                    return false;
                }
                else if (txtChangePass.Text.Contains(' '))
                {
                    errorChangePass.SetError(txtChangePass, "Do not use space please");
                    errorChangePass.Tag = "0";
                    return false;

                }
                else
                {
                    errorChangePass.SetError(txtChangePass, "Password must be at least 8 characters long");
                    errorChangePass.Tag = "0";
                    return false;
                }
                

            }
            else
            {

                if (!check && !(txtChangePass.Text.Length == 0))
                {                 
                    if (txtChangePass.Text.Contains(' '))
                    {
                        errorChangePass.SetError(txtChangePass, "Do not use space please");
                        errorChangePass.Tag = "0";
                        return false;

                    }
                    else
                    {
                        errorChangePass.SetError(txtChangePass, "Use at least 1 special character!");
                        errorChangePass.Tag = "0";
                        return false;
                    }

                }               
                else if (txtChangePass.Text.Length == 0)
                {
                    errorChangePass.Tag = "0";
                    errorChangePass.SetError(txtChangePass, "Please populate this field!");
                    return false;
                }
                else
                {
                    errorChangePass.Dispose();
                    errorChangePass.Tag = "1";
                    return true;
                }

                
                
            }



        }
        
        public bool IsUsernameValid(ErrorProvider errorChangeUser, TextBox txtChangeUser)
        {
            bool check = Regex.IsMatch(txtChangeUser.Text, "[!@#$%^&*`\"()_+[{}\\],./;':|?/<>=-]");
            
            bool checkUser = accounts.Any(a => a.Username == txtChangeUser.Text);

            if (txtChangeUser.Text.Length == 0)
            {
                errorChangeUser.Tag = "0";
                errorChangeUser.SetError(txtChangeUser, "Please populate this field!");
                return false;
            }
            else if (check)
            {               
                if (txtChangeUser.Text.Contains(' '))
                {
                    errorChangeUser.SetError(txtChangeUser, "Do not use space please");
                    errorChangeUser.Tag = "0";
                    return false;
                }
                else
                {
                    errorChangeUser.SetError(txtChangeUser, "No special characters please!");
                    errorChangeUser.Tag = "0";
                    return false;
                }
            }
            else
            {
                

                if (checkUser)
                {
                    errorChangeUser.SetError(txtChangeUser, "Username is already taken!");
                    errorChangeUser.Tag = "0";
                    return false;
                }
                else
                {
                    errorChangeUser.Dispose();
                    errorChangeUser.Tag = "1";
                    return true;
                }

            }

        }

        public bool IsEmailValid(ErrorProvider errorChangeEmail, TextBox txtChangeEmail)
        {
            bool check = Regex.IsMatch(txtChangeEmail.Text, "[!#$%^&*`\"()_+[{}\\],/;':|?/<>=-]$");
            
            bool checkUser = accounts.Any(a => a.Email == txtChangeEmail.Text);

            
            if (txtChangeEmail.Text.Length == 0)
            {
                errorChangeEmail.Tag = "0";
                errorChangeEmail.SetError(txtChangeEmail, "Please populate this field!");
                return false;
            }
            else if (check || !txtChangeEmail.Text.Contains('@'))
            {

                if (txtChangeEmail.Text.Contains(" "))
                {
                    errorChangeEmail.SetError(txtChangeEmail, "Do not use space please");
                    errorChangeEmail.Tag = "0";
                    return false;
                }
                else
                {
                    errorChangeEmail.SetError(txtChangeEmail, "Invalid email!");
                    errorChangeEmail.Tag = "0";
                    return false;
                }
            }
            else
            {
                if (checkUser)
                {
                    errorChangeEmail.SetError(txtChangeEmail, "Email is already taken!");
                    errorChangeEmail.Tag = "0";
                    return false;
                }
                else
                {
                    errorChangeEmail.Dispose();
                    errorChangeEmail.Tag = "1";
                    return true;
                }
            }


            

            
        }

    }
}
