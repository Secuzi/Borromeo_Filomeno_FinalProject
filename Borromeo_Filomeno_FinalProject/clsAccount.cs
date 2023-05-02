﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public class clsAccount
    {
        private string username;
        private string password;
        private string email;
        private decimal balance;
        

        //Make another class that accepts clsAccount to form a list

        public string Password { get { return password; } set { password = value; } }
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
            Balance = 0;

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
