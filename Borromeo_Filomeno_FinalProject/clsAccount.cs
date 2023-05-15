using System;
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
        private int score;
        

        //Make another class that accepts clsAccount to form a list

        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int Score { get { return score; } set { score = value; } }
        public string Username { get { return username; } set { username = value; } }


        public clsAccount()
        {
            
        }

        public clsAccount(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
            Score = 0;

        }


      


        //public string CheckLoginStatusUsername(string username, string password)
        //{
        //    if (username != Username)
        //    {             
        //        return $"The account {username} has not been created.";
        //    }
        //    else if (username == Username && password != Password)
        //    {               
        //        return $"Wrong password, please try again";
        //    }
        //    else
        //    {                
        //        return $"Welcome to Compound Games!";
        //    }

        //}

        //public string CheckLoginStatusEmail(string email, string password)
        //{
        //    if (email != Email)
        //    {
        //        return $"The email {email} has not been registered.";
        //    }
        //    else if (username == Username && password != Password)
        //    {
        //        return $"Wrong password, please try again";
        //    }
        //    else
        //    {
        //        return $"Welcome to Compound Games!";
        //    }

        //}

    }
}
