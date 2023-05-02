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

        public clsLogin(List<clsAccount> accounts)
        {
            int i = 0;
            while(accounts.Count > i)
            {
                Username = accounts[i].Username;
                Password = accounts[i].Password;
                Email = accounts[i].Email;
                Balance = accounts[i].Balance;
                i++;
            }
        }


        public bool CheckLoginStatus(string logInput, string password)
        {

            if (logInput != Username && !logInput.Contains('@'))
            {               
                MessageBox.Show($"The account {logInput} has not been created.");
                return false;               
            }
            else if (logInput != Email && logInput.Contains('@'))
            {
                MessageBox.Show($"The email {logInput} has not been registered.");
                return false;
            }
            else if ((logInput == Username && password != Password) || (logInput == Email && password != Password)) 
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
