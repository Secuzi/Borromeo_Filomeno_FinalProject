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
                    errorChange.Dispose();
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
        //CHANGE THIS FROM VOID TO BOOL
        public bool IsUsernameValid(ErrorProvider errorChange, TextBox txtChange)
        {
            bool check = Regex.IsMatch(txtChange.Text, "[!@#$%^&*`\"()_+[{}\\],./;':|?/<>=-]");
            db = new clsDatabase();
            accounts = db.GetAccountsInDatabase();



            bool checkUser = accounts.Any(a => a.Username == txtChange.Text);


            //bool checkUser = accounts.IsUserExists(txtChange.Text);

            if (txtChange.Text.Length == 0)
            {
                errorChange.Tag = "0";
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



        public void RegexConfirm(string username, string password, string email)
        {

        }

    }
}
