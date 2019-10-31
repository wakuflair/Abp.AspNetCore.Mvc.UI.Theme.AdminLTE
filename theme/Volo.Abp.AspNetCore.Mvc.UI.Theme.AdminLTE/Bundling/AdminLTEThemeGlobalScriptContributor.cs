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
            context.Files.Clear();

            context.Files.Add("/libs/abp/core/abp.js");
            context.Files.Add("/libs/jquery/jquery.min.js");
            context.Files.Add("/libs/abp/jquery/abp.jquery.js");
            context.Files.Add("/libs/jquery-validation/jquery.validate.js");
            context.Files.Add("/libs/bootstrap/js/bootstrap.js");
            context.Files.Add("/themes/adminlte/js/adminlte.js");
            context.Files.Add("/themes/adminlte/js/layout.js");
        }
    }
}
