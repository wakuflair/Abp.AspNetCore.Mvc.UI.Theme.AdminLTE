using Volo.Abp.Identity;
using Microsoft.Extensions.Options;
using Volo.Abp.Account.Web.ProfileManagement;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.Account
{
    public class ManageModel : Volo.Abp.Account.Web.Pages.Account.ManageModel
    {
        public ManageModel(IOptions<ProfileManagementPageOptions> options)
            : base(options)
        {

        }
    }
}
