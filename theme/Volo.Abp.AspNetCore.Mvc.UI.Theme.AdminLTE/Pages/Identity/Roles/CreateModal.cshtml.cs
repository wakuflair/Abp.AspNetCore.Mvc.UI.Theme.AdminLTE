using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.Identity;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Roles
{
    public class CreateModalModel : Volo.Abp.Identity.Web.Pages.Identity.Roles.CreateModalModel
    {
        public CreateModalModel(IIdentityRoleAppService identityRoleAppService) 
            : base(identityRoleAppService)
        {

        }
    }
}
