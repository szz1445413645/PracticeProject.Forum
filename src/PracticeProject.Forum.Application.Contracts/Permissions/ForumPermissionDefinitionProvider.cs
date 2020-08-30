using PracticeProject.Forum.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PracticeProject.Forum.Permissions
{
    public class ForumPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ForumPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ForumPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ForumResource>(name);
        }
    }
}
