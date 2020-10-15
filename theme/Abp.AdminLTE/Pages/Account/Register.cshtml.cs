using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Account;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Account
{
    public class RegisterModel : Volo.Abp.Account.Web.Pages.Account.RegisterModel
    {
        public RegisterModel(IAccountAppService accountAppService) : base(accountAppService)
        {
        }

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
