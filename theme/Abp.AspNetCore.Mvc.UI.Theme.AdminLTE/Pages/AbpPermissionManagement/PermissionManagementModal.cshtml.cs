using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.PermissionManagement;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Pages.AbpPermissionManagement
{
    public class PermissionManagementModal : Volo.Abp.PermissionManagement.Web.Pages.AbpPermissionManagement.PermissionManagementModal
    {
        public PermissionManagementModal(IPermissionAppService permissionAppService)
            : base(permissionAppService)
        {

        }
    }
}
