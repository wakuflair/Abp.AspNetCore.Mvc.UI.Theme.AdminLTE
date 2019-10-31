using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using AdminLTEPro.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AdminLTEPro.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits AdminLTEPro.Web.Pages.AdminLTEProPage
     */
    public abstract class AdminLTEProPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AdminLTEProResource> L { get; set; }
    }
}
