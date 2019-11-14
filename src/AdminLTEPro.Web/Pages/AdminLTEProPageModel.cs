using AdminLTEPro.Localization;
using Microsoft.AspNetCore.Mvc.Filters;
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

        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            ViewData["CopyrightUrl"] = "http://adminlte.io";
            ViewData["Version"] = "1.1";
            base.OnPageHandlerExecuting(context);
        }
    }
}