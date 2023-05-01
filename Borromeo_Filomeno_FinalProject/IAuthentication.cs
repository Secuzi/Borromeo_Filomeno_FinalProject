using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    internal interface IAuthentication
    {
        void isPasswordValid(string username, string password, string email, ErrorProvider errorChange, TextBox txtChange);
        void isUsernameValid (string username, string password, string email, ErrorProvider errorChange, TextBox txtChange);
    
    }
}
