using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.Identity;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Users
{
    public class CreateModalModel : Volo.Abp.Identity.Web.Pages.Identity.Users.CreateModalModel
    {
        public CreateModalModel(IIdentityUserAppService identityUserAppService, IIdentityRoleAppService identityRoleAppService)
            : base(identityUserAppService, identityRoleAppService)
        {

        }
    }
}
