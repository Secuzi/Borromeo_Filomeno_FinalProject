using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public class clsRegister : clsAccount, IAuthentication
    {
        //Encapsulate these fields
        clsDatabase db;

        List<clsAccount> accounts;
        public clsRegister()
        {
            db = new clsDatabase();
            accounts = db.GetAccountsInDatabase();
        }
        
        public bool IsPasswordValid(ErrorProvider errorChange, TextBox txtChange)
        {
            //For Password
            bool check = Regex.IsMatch(txtChange.Text, "[!@#$%^&*`\"()_+[{}\\],./;':|?/<>=-]");



            if (txtChange.Text.Length < 8 && txtChange.Text.Length > 0)
            {

                if (!check && !txtChange.Text.Contains(""))
                {
                    errorChange.SetError(txtChange, "Use at least 1 special character and password must be at least 8 characters long!");
                    errorChange.Tag = "0";
                    return false;
                }
                else if (txtChange.Text.Contains(' '))
                {
                    errorChange.SetError(txtChange, "Do not use space please");
                    errorChange.Tag = "0";
                    return false;

                }
                else
                {
                    errorChange.SetError(txtChange, "Password must be at least 8 characters long");
                    errorChange.Tag = "0";
                    return false;
                }
                

            }
            else
            {

                if (!check && !(txtChange.Text.Length == 0))
                {                 
                    if (txtChange.Text.Contains(' '))
                    {
                        errorChange.SetError(txtChange, "Do not use space please");
                        errorChange.Tag = "0";
                        return false;

                    }
                    else
                    {
                        errorChange.SetError(txtChange, "Use at least 1 special character!");
                        errorChange.Tag = "0";
                        return false;
                    }

                }               
                else if (txtChange.Text.Length == 0)
                {
                    errorChange.Tag = "0";
                    errorChange.SetError(txtChange, "Please populate this field!");
                    return false;
                }
                else
                {
                    errorChange.Dispose();
                    errorChange.Tag = "1";
                    return true;
                }

                
                
            }



        }
        
        public bool IsUsernameValid(ErrorProvider errorChange, TextBox txtChange)
        {
            bool check = Regex.IsMatch(txtChange.Text, "[!@#$%^&*`\"()_+[{}\\],./;':|?/<>=-]");
            
            bool checkUser = accounts.Any(a => a.Username == txtChange.Text);

            if (txtChange.Text.Length == 0)
            {
                errorChange.Tag = "0";
                errorChange.SetError(txtChange, "Please populate this field!");
                return false;
            }
            else if (check)
            {               
                if (txtChange.Text.Contains(' '))
                {
                    errorChange.SetError(txtChange, "Do not use space please");
                    errorChange.Tag = "0";
                    return false;
                }
                else
                {
                    errorChange.SetError(txtChange, "No special characters please!");
                    errorChange.Tag = "0";
                    return false;
                }
            }
            else
            {
                

                if (checkUser)
                {
                    errorChange.SetError(txtChange, "Username is already taken!");
                    errorChange.Tag = "0";
                    return false;
                }
                else
                {
                    errorChange.Dispose();
                    errorChange.Tag = "1";
                    return true;
                }

            }

        }

        public bool IsEmailValid(ErrorProvider errorChange, TextBox txtChange)
        {
            bool check = Regex.IsMatch(txtChange.Text, "[!#$%^&*`\"()_+[{}\\],/;':|?/<>=-]$");
            
            bool checkUser = accounts.Any(a => a.Email == txtChange.Text);

            
            if (txtChange.Text.Length == 0)
            {
                errorChange.Tag = "0";
                errorChange.SetError(txtChange, "Please populate this field!");
                return false;
            }
            else if (check || !txtChange.Text.Contains('@'))
            {

                if (txtChange.Text.Contains(" "))
                {
                    errorChange.SetError(txtChange, "Do not use space please");
                    errorChange.Tag = "0";
                    return false;
                }
                else
                {
                    errorChange.SetError(txtChange, "Invalid email!");
                    errorChange.Tag = "0";
                    return false;
                }
            }
            else
            {
                if (checkUser)
                {
                    errorChange.SetError(txtChange, "Email is already taken!");
                    errorChange.Tag = "0";
                    return false;
                }
                else
                {
                    errorChange.Dispose();
                    errorChange.Tag = "1";
                    return true;
                }
            }


            

            
        }

    }
}
