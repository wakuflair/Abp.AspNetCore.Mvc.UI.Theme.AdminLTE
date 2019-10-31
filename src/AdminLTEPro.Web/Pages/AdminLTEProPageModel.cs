using AdminLTEPro.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AdminLTEPro.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AdminLTEProPageModel : AbpPageModel
    {
        protected AdminLTEProPageModel()
        {
            LocalizationResourceType = typeof(AdminLTEProResource);
        }
    }
}