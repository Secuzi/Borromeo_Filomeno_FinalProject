using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borromeo_Filomeno_FinalProject
{
    public interface IAuthentication
    {
        bool IsPasswordValid(ErrorProvider errorChange, TextBox txtChange);
        bool IsUsernameValid (ErrorProvider errorChange, TextBox txtChange);

        bool IsEmailValid(ErrorProvider errorChange, TextBox txtChange);
    
    }
}
