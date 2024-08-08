using System.Threading.Tasks;
using Libary.Localization;
using Libary.Permissions;
using Libary.MultiTenancy;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.Identity.Blazor;

namespace Libary.Blazor.Menus;

public class LibaryMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }



   private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
 {
     var l = context.GetLocalizer<LibaryResource>();
     context.Menu.Items.Insert(
         0,
         new ApplicationMenuItem(
             LibaryMenus.Home,
             l["Menu:Home"],
             "/",
             icon: "fas fa-home",
             order: 1
         )
     );
        
     

        //Administration
        var administration = context.Menu.GetAdministration();
        administration.Order = 4;
    
        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }





                //administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        //administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);
        context.Menu.AddItem(
    new ApplicationMenuItem(
        "BooksStore",
        l["Menu:Library_1"],
        icon: "fa fa-book"
    ).AddItem(
        new ApplicationMenuItem(
            "BooksStore.Books",
            l["Menu:Books"],
            url: "/books"
        )
    ).
    
    
    
    AddItem(
        new ApplicationMenuItem(
            "BooksStore.Readers",
            l["Menu:Readers"],
            url: "/readers"
        )
    )
      
 
        );


        return Task.CompletedTask;
        
    }
}
