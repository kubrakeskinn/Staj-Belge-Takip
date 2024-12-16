using Etu.StajSistemi.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Etu.StajSistemi.Permissions;

public class StajSistemiPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StajSistemiPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(StajSistemiPermissions.MyPermission1, L("Permission:MyPermission1"));

        var ogrenciStajBasvurusuPermission = myGroup.AddPermission(StajSistemiPermissions.OgrenciStajBasvurusus.Default, L("Permission:OgrenciStajBasvurusus"));
        ogrenciStajBasvurusuPermission.AddChild(StajSistemiPermissions.OgrenciStajBasvurusus.Create, L("Permission:Create"));
        ogrenciStajBasvurusuPermission.AddChild(StajSistemiPermissions.OgrenciStajBasvurusus.Edit, L("Permission:Edit"));
        ogrenciStajBasvurusuPermission.AddChild(StajSistemiPermissions.OgrenciStajBasvurusus.Delete, L("Permission:Delete"));
        ogrenciStajBasvurusuPermission.AddChild(StajSistemiPermissions.OgrenciStajBasvurusus.StajKomisyonuOnayla, L("Permission:StajKomisyonuOnayla"));
        ogrenciStajBasvurusuPermission.AddChild(StajSistemiPermissions.OgrenciStajBasvurusus.BolumBaskaniOnayla, L("Permission:BolumBaskaniOnayla"));
        ogrenciStajBasvurusuPermission.AddChild(StajSistemiPermissions.OgrenciStajBasvurusus.DekanlikOnayla, L("Permission:DekanlikOnayla"));
        ogrenciStajBasvurusuPermission.AddChild(StajSistemiPermissions.OgrenciStajBasvurusus.SksDaireBaskanligiOnayla, L("Permission:SksDaireBaskanligiOnayla"));
        ogrenciStajBasvurusuPermission.AddChild(StajSistemiPermissions.OgrenciStajBasvurusus.KurumOnayla, L("Permission:KurumOnayla"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StajSistemiResource>(name);
    }
}