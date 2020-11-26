using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AdminLTEPro.Web
{
    [Dependency(ReplaceServices = true)]
    public class AdminLTEProBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AdminLTE Pro";
    }
}
