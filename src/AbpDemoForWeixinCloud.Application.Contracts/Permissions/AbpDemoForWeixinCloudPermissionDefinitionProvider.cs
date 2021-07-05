using AbpDemoForWeixinCloud.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpDemoForWeixinCloud.Permissions
{
    public class AbpDemoForWeixinCloudPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpDemoForWeixinCloudPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpDemoForWeixinCloudPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpDemoForWeixinCloudResource>(name);
        }
    }
}
