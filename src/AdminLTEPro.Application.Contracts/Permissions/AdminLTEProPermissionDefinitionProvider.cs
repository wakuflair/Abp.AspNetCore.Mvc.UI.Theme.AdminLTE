using AdminLTEPro.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AdminLTEPro.Permissions
{
    public class AdminLTEProPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AdminLTEProPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AdminLTEProPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AdminLTEProResource>(name);
        }
    }
}
