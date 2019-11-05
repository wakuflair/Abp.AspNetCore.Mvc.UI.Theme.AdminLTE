using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Themes.AdminLTE.Components
{
    public class FooterViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/AdminLTE/Components/Footer/Default.cshtml");
        }
    }
}
