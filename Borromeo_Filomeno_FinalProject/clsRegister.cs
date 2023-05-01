using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    internal class clsRegister : clsAccount, IAuthentication
    {

        public void isPasswordValid(string username, string password, string email, ErrorProvider errorChange, TextBox txtChange)
        {
            //For Password
            bool check = Regex.IsMatch(txtChange.Text, "[!@#$%^&*`\"()_+[{}\\],./;':|?/<>=-]");



            if (txtChange.Text.Length < 8)
            {

                if (!check)
                {
                    errorChange.SetError(txtChange, "Use at least 1 special character and password must be at least 8 characters long!");
                    errorChange.Tag = "0";
                }


                if (txtChange.Text.Contains(' '))
                {
                    errorChange.SetError(txtChange, "Do not use space please");
                    errorChange.Tag = "0";


                }

                errorChange.SetError(txtChange, "Password must be at least 8 characters long");
                errorChange.Tag = "0";


            }
            else
            {

                if (!check)
                {
                    errorChange.SetError(txtChange, "Use at least 1 special character!");
                    errorChange.Tag = "0";

                }
                else
                {
                    errorChange.Dispose();
                    errorChange.Tag = "1";

                }

                if (txtChange.Text.Contains(' '))
                {
                    errorChange.SetError(txtChange, "Do not use space please");
                    errorChange.Tag = "0";


                }
            }

            if (txtChange.TextLength == 0)
            {
                errorChange.Tag = "0";
                errorChange.Dispose();
            }



        }


        public void RegexConfirm(string username, string password, string email)
        {

        }

    }
}
