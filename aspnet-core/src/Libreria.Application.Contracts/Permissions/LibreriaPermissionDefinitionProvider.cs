using Libreria.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Libreria.Permissions;

public class LibreriaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(LibreriaPermissions.GroupName, L("Permission:Libreria"));

        var booksPermission = bookStoreGroup.AddPermission(LibreriaPermissions.Books.Default, L("Permission:Books"));

        booksPermission.AddChild(LibreriaPermissions.Books.Create, L("Permission:Books.Create"));

        booksPermission.AddChild(LibreriaPermissions.Books.Edit, L("Permission:Books.Edit"));

        booksPermission.AddChild(LibreriaPermissions.Books.Delete, L("Permission:Books.Delete"));


        var authorsPermission = 
            bookStoreGroup.AddPermission(
            LibreriaPermissions.Authors.Default, L("Permission:Authors"));

            authorsPermission.AddChild(
                LibreriaPermissions.Authors.Create, L("Permission:Authors.Create"));

            authorsPermission.AddChild(
                LibreriaPermissions.Authors.Edit, L("Permission:Authors.Edit"));

            authorsPermission.AddChild(
                LibreriaPermissions.Authors.Delete, L("Permission:Authors.Delete"));
            
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LibreriaPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LibreriaResource>(name);
    }
}
