using Etu.StajSistemi.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;

namespace Etu.StajSistemi.Roles;

public static class Role
{
    public static EtuStaticRole Ogrenci { get; } = new EtuStaticRole
    {
        Id = Guid.Parse("0537BAE5-261B-4AC5-93E9-CBE0F1B76E7D"),
        Name = "Öğrenci",
        Permissions =
        {
            StajSistemiPermissions.OgrenciStajBasvurusus.Default,
            StajSistemiPermissions.OgrenciStajBasvurusus.Create
        }
    };
    
    public static EtuStaticRole KurumYetkilisi { get; } = new EtuStaticRole
    {
        Id = Guid.Parse("C5F9ADE7-685D-4E00-84BC-604D1098B8AE"),
        Name = "Kurum Yetkilisi",
        Permissions =
        {
            StajSistemiPermissions.OgrenciStajBasvurusus.KurumOnayla
        }
    };
    
    public static EtuStaticRole BolumBaskani { get; } = new EtuStaticRole
    {
        Id = Guid.Parse("D89F1524-3AE1-4124-BF71-72BCC37027E2"),
        Name = "Bölüm Başkanı",
        Permissions =
        {
            StajSistemiPermissions.OgrenciStajBasvurusus.BolumBaskaniOnayla
        }
    };
    
    public static EtuStaticRole StajKomisyonuBaskani { get; } = new EtuStaticRole
    {
        Id = Guid.Parse("B8A01130-71AA-4B9A-8548-B73B8A7FA3CB"),
        Name = "Staj Komisyonu Başkanı",
        Permissions =
        {
            StajSistemiPermissions.OgrenciStajBasvurusus.StajKomisyonuOnayla
        }
    };
    
    public static EtuStaticRole Dekan { get; } = new EtuStaticRole
    {
        Id = Guid.Parse("D1A3D3A4-3A3D-4A3D-8A3D-7A3D3A3D3A3D"),
        Name = "Dekan",
        Permissions =
        {
            StajSistemiPermissions.OgrenciStajBasvurusus.DekanlikOnayla
        }
    };
    
    public static EtuStaticRole SKSDaireBaskanligiYetkilisi { get; } = new EtuStaticRole
    {
        Id = Guid.Parse("FADBECBF-2270-4B5A-815D-D2AB1981CEB6"),
        Name = "SKS Daire Başkanlığı",
        Permissions =
        {
            StajSistemiPermissions.OgrenciStajBasvurusus.SksDaireBaskanligiOnayla
        }
    };
    
    public static List<EtuStaticRole> AllRoles { get; } = new List<EtuStaticRole>
    {
        Ogrenci,
        KurumYetkilisi,
        BolumBaskani,
        StajKomisyonuBaskani,
        Dekan,
        SKSDaireBaskanligiYetkilisi
    };
}

public class EtuStaticRole
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public List<string> Permissions { get; } = new();
}

public class RoleDataSeeder : IDataSeedContributor, ITransientDependency
{
    private readonly IIdentityRoleRepository _roleRepository;
    private readonly IPermissionDataSeeder _permissionDataSeeder;

    public RoleDataSeeder(IIdentityRoleRepository roleRepository, IPermissionDataSeeder permissionDataSeeder)
    {
        _roleRepository = roleRepository;
        _permissionDataSeeder = permissionDataSeeder;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        foreach (var role in Role.AllRoles)
        {
            await CreateRoleIfNotExistsAsync(role);
        }
    }

    private async Task CreateRoleIfNotExistsAsync(EtuStaticRole role)
    {
        var existingRole = await _roleRepository.FindByNormalizedNameAsync(role.Name.ToUpperInvariant());
        if (existingRole == null)
        {
            await _roleRepository.InsertAsync(new IdentityRole(role.Id, role.Name)
            {
                IsStatic = true
            });
            
            await _permissionDataSeeder.SeedAsync(
                RolePermissionValueProvider.ProviderName,
                role.Name,
                role.Permissions
            );
        }
    }
}
