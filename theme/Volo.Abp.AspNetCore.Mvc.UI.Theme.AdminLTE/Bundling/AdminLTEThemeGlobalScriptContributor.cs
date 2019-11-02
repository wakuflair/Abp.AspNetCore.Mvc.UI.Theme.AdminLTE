using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Bundling
{
    public class AdminLTEThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            //context.Files.Clear();
            // || t.Contains("/libs/datatables.net")
            context.Files.RemoveAll(t => t.Contains("/libs/jquery/") || t.Contains("/libs/bootstrap/"));

            context.Files.Insert(1, "/libs/jquery/jquery.min.js");

            context.Files.Insert(3, "/libs/bootstrap/js/bootstrap.js");
            context.Files.Add("/themes/adminlte/js/adminlte.js");
            context.Files.Add("/themes/adminlte/js/layout.js");
        }
    }
}
