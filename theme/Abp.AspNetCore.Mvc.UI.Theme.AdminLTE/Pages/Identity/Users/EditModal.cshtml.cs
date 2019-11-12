using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.Identity;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Users
{
    public class EditModalModel : Volo.Abp.Identity.Web.Pages.Identity.Users.EditModalModel
    {
        public EditModalModel(IIdentityUserAppService identityUserAppService, IIdentityRoleAppService identityRoleAppService)
            : base(identityUserAppService, identityRoleAppService)
        {

        }
    }
}
