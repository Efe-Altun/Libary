using Libary.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Libary.Permissions;

public class LibaryPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LibaryPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(LibaryPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(LibaryPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(LibaryPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(LibaryPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LibaryPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LibaryResource>(name);
    }
}
