using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AspNetCore.Mvc.UI.Alerts;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Themes.AdminLTE.Components.PageAlerts
{
    public class PageAlertsViewComponent : AbpViewComponent
    {
        private readonly IAlertManager _alertManager;

        public PageAlertsViewComponent(IAlertManager alertManager)
        {
            _alertManager = alertManager;
        }

        public IViewComponentResult Invoke(string name)
        {
            return View("~/Themes/AdminLTE/Components/PageAlerts/Default.cshtml", _alertManager.Alerts);
        }
    }
}
