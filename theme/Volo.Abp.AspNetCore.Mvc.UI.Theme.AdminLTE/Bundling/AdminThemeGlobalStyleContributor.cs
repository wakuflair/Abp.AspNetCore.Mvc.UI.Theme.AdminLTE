using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Bundling
{
    public class AdminThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            // 移除默认的style
            context.Files.Clear();

            context.Files.Add("/libs/abp/core/abp.css");
            context.Files.Add("/libs/bootstrap/css/bootstrap.min.css");
            context.Files.Add("/libs/font-awesome/css/font-awesome.css");
            context.Files.Add("/libs/Ionicons/css/ionicons.min.css");
            context.Files.Add("/themes/adminlte/css/AdminLTE.min.css");
            context.Files.Add("/themes/adminlte/css/skins/_all-skins.css");
        }
    }
}
