using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AdminLTEPro.Web
{
    [Dependency(ReplaceServices = true)]
    public class AdminLTEProBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AdminLTEPro";
    }
}
