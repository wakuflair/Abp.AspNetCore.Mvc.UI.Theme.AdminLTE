using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Bundling
{
    public class AdminLTEThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            ////context.Files.Clear();
            //// || t.Contains("/libs/datatables.net")
            //context.Files.RemoveAll(t => t.Contains("/libs/jquery/") || t.Contains("/libs/bootstrap/"));

            //context.Files.Insert(1, "/plugins/jquery/jquery.min.js");

            //context.Files.Insert(3, "/plugins/bootstrap/js/bootstrap.js");
            context.Files.Add("/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js");
            context.Files.Add("/themes/adminlte/js/adminlte.js");
            context.Files.Add("/themes/adminlte/js/layout.js");
        }
    }
}
