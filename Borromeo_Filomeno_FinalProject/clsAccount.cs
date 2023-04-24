using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    internal class clsAccount
    {
        private string username;
        private string password;
        private byte age;
        private string email;
        private decimal balance;
        private bool loggedIn;

        //Make another class that accepts clsAccount to form a list

        public bool SetLoggedIn { set { loggedIn = value; } }
        public bool GetLoggedIn { get { return loggedIn; } }
        public string Password { get { return password; } set { password = value; } }
        public byte Age { get { return age; } set { age = value; } }
        public string Email { get { return email; } set { email = value; } }
        public decimal Balance { get { return balance; } set { balance = value; } }
        public string Username { get { return username; } set { username = value; } }


        public clsAccount()
        {
            
        }

        public clsAccount(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;

        }


        public string ShowInfo()
        {           
            return $"Username: {Username}\nPassword: {Password}\nEmail: {Email}\nBalance: {Balance}";
        }


        public string CheckLoginStatus(string username, string password)
        {
            if (username != Username)
            {
                SetLoggedIn = false;
                return $"The account {username} has not been created.";
            }
            else if (username == Username && password != Password)
            {
                SetLoggedIn = false;
                return $"Wrong password, please try again";
            }
            else
            {
                SetLoggedIn = true;
                return $"Welcome to Compound Games!";
            }

        }



    }
}
