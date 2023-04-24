using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borromeo_Filomeno_FinalProject
{
    internal class clsRegister
    {
        List<clsAccount> accounts = new List<clsAccount>();

        public clsRegister()
        {
            
        }

        public void AddAccount(string username, string password, string email)
        {
            accounts.Add(new clsAccount(username, password, email));
        }
      
        public bool IsUserExists(string username)
        {
            return accounts.Any(user => user.Username == username); 
        }

        
        


    }
}
