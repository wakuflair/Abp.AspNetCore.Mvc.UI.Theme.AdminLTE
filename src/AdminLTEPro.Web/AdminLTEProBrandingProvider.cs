using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace AdminLTEPro.Web
{
    [Dependency(ReplaceServices = true)]
    public class AdminLTEProBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AdminLTE Pro";
    }
}
