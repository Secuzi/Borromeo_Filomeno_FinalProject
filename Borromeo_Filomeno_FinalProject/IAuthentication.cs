﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borromeo_Filomeno_FinalProject
{
    internal interface IAuthentication
    {
        bool isAuthenticated(string username, string password, string email);
    }
}
