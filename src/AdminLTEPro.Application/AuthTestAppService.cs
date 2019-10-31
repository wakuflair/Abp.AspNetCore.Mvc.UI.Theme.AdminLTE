using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdminLTEPro
{
    [Authorize]
    public class AuthTestAppService : AdminLTEProAppService
    {
        public string GetAuth()
        {
            return "ok!";
        }
    }
}
