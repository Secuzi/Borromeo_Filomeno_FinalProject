using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Borromeo_Filomeno_FinalProject
{
    public class clsLogin : clsAccount
    {
        public List<clsAccount> accounts;

        public clsLogin()
        {
            accounts = new List<clsAccount>();
        }

        public bool CheckLoginStatus(string logInput, string password)
        {
            bool userValid = accounts.Any(a => a.Username == logInput);
            bool emailValid = accounts.Any(a => a.Email == logInput);
            bool passwordValid = accounts.Any(a => a.Password == password);

            if (!userValid && !logInput.Contains('@'))
            {
                MessageBox.Show($"The account {logInput} has not been created.");
                return false;
            }
            else if (!emailValid && logInput.Contains('@'))
            {
                MessageBox.Show($"The email {logInput} has not been registered.");
                return false;
            }
            else if ((userValid && !passwordValid) || (emailValid && !passwordValid))
            {
                //if (logInput == Email && password != Password)
                MessageBox.Show($"Wrong password, please try again");
                return false;
            }
            else
            {
                MessageBox.Show($"Welcome to Compound Games!");
                return true;
            }

        }

    }
}
