using Volo.Abp.Identity;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Account
{
    public class ManageModel : Volo.Abp.Account.Web.Pages.Account.ManageModel
    {
        public ManageModel(IProfileAppService profileAppService)
            : base(profileAppService)
        {

        }
    }
}
