using VenueManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace VenueManagement.Permissions;

public class VenueManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(VenueManagementPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(VenueManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<VenueManagementResource>(name);
    }
}
