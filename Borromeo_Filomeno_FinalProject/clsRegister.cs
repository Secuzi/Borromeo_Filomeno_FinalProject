using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Borromeo_Filomeno_FinalProject
{
    internal class clsRegister : clsAccount, IAuthentication
    {

        public bool isAuthenticated(string username, string password, string email)
        {
            if (Username == username)


            return true;
        }


        public void RegexConfirm(string username, string password, string email)
        {

        }

    }
}
