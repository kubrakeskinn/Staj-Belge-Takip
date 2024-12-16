using Etu.StajSistemi.Permissions;
using Etu.StajSistemi.Localization;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Etu.StajSistemi.Menus;

public class StajSistemiMenuContributor : IMenuContributor
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
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<StajSistemiResource>();


        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                StajSistemiMenus.Home,
                "Ana Sayfa",
                "/",
                icon: "fas fa-home",
                order: 0,
                cssClass: "menu-item"
            )
        );

        context.Menu.AddItem(
            new ApplicationMenuItem(
                StajSistemiMenus.OgrenciStajBasvurususCreate,
                "Başvuru Yap",
                url: "/OgrenciStajBasvurusus/Create",
                icon: "fa fa-file-alt",
                cssClass: "menu-item",
                requiredPermissionName: StajSistemiPermissions.OgrenciStajBasvurusus.Create)
        );


        context.Menu.AddItem(
            new ApplicationMenuItem(
                StajSistemiMenus.OgrenciStajBasvurusus,
                "Başvurularım",
                url: "/OgrenciStajBasvurusus",
                icon: "fa fa-file-alt",
                cssClass: "menu-item",
                requiredPermissionName: StajSistemiPermissions.OgrenciStajBasvurusus.Default)
        );
        context.Menu.AddItem(
            new ApplicationMenuItem(
                StajSistemiMenus.StajKomisyonu,
                "Staj Komisyonu Onay Bekleyenler",
                url: "/StajKomisyonu",
                icon: "fa fa-file-alt",
                cssClass: "menu-item",
                requiredPermissionName: StajSistemiPermissions.OgrenciStajBasvurusus.StajKomisyonuOnayla)
        );

        context.Menu.AddItem(
            new ApplicationMenuItem(
                StajSistemiMenus.BolumBaskaniOnayBekleyenler,
                "Bölüm Başkanı Onay Bekleyenler",
                url: "/BolumBaskani",
                icon: "fa fa-file-alt",
                cssClass: "menu-item",
                requiredPermissionName: StajSistemiPermissions.OgrenciStajBasvurusus.BolumBaskaniOnayla)
        );


        context.Menu.AddItem(
            new ApplicationMenuItem(
                StajSistemiMenus.Dekanlik,
                "Dekanlık Onay Bekleyenler",
                url: "/Dekanlik",
                icon: "fa fa-file-alt",
                cssClass: "menu-item",
                requiredPermissionName: StajSistemiPermissions.OgrenciStajBasvurusus.DekanlikOnayla)
        );

        context.Menu.AddItem(
            new ApplicationMenuItem(
                StajSistemiMenus.SksDaireBaskanligi,
                "SKS Daire Başkanlığı Onay Bekleyenler",
                url: "/Sks",
                icon: "fa fa-file-alt",
                cssClass: "menu-item",
                requiredPermissionName: StajSistemiPermissions.OgrenciStajBasvurusus.SksDaireBaskanligiOnayla)
        );
        if (StajSistemiModule.IsMultiTenant)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }


        return Task.CompletedTask;
    }
}