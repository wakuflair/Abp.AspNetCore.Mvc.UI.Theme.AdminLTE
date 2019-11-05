using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Themes.AdminLTE.Components.Toolbar
{
    public class UserMenuViewComponent : AbpViewComponent
    {
        private readonly IMenuManager _menuManager;

        public UserMenuViewComponent(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menu = await _menuManager.GetAsync(StandardMenus.User);
            return View("~/Themes/AdminLTE/Components/Toolbar/UserMenu/Default.cshtml", menu);
        }
    }
}
