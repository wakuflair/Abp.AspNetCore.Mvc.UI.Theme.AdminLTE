using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.Account.Web.Pages.Account;
using Volo.Abp.Account.Web.Settings;
using Volo.Abp.Settings;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Account
{
    public class RegisterModel : Volo.Abp.Account.Web.Pages.Account.RegisterModel
    {
        public override async Task<IActionResult> OnPostAsync()
        {
            try
            {
                return await base.OnPostAsync();
            }
            catch(Exception e)
            {
                Alerts.Danger(e.Message);
                return Page();
            }
        }
    }
}
