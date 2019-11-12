using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.Identity;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Identity.Roles
{
    public class EditModalModel : Volo.Abp.Identity.Web.Pages.Identity.Roles.EditModalModel
    {
        public EditModalModel(IIdentityRoleAppService identityRoleAppService)
            : base(identityRoleAppService)
        {

        }
    }
}
