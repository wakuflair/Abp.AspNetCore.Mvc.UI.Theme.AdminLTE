using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.Identity;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Account
{
    public class ManageModel : Volo.Abp.Account.Web.Pages.Account.ManageModel
    {
        public ManageModel(IProfileAppService profileAppService)
            : base(profileAppService)
        {

        }
    }
}
