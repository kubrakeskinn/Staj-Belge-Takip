using Etu.StajSistemi.OgrenciStajBasvurusus;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BlobStoring.Database.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Etu.StajSistemi.Data;

public class StajSistemiDbContext : AbpDbContext<StajSistemiDbContext>
{
    public DbSet<OgrenciStajBasvurusu> OgrenciStajBasvurusus { get; set; } = null!;
    public const string DbTablePrefix = "App";
    public const string DbSchema = null;
    public StajSistemiDbContext(DbContextOptions<StajSistemiDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();
        builder.ConfigureBlobStoring();
        if (builder.IsHostDatabase())
        {

        }
        if (builder.IsHostDatabase())
        {

        }
        if (builder.IsHostDatabase())
        {
            builder.Entity<OgrenciStajBasvurusu>(b =>
            {
                b.ToTable(DbTablePrefix + "OgrenciStajBasvurusus", DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.GunSayisi).HasColumnName(nameof(OgrenciStajBasvurusu.GunSayisi)).HasMaxLength(OgrenciStajBasvurusuConsts.GunSayisiMaxLength);
                b.Property(x => x.BolumBaskaniAdiSoyadi).HasColumnName(nameof(OgrenciStajBasvurusu.BolumBaskaniAdiSoyadi)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.BolumBaskaniAdiSoyadiMaxLength);
                b.Property(x => x.BolumBaskaniImzasi).HasColumnName(nameof(OgrenciStajBasvurusu.BolumBaskaniImzasi)).HasMaxLength(OgrenciStajBasvurusuConsts.BolumBaskaniImzasiMaxLength);
                b.Property(x => x.BolumBaskaniImzasiContentType).HasColumnName(nameof(OgrenciStajBasvurusu.BolumBaskaniImzasiContentType)).HasMaxLength(OgrenciStajBasvurusuConsts.BolumBaskaniImzasiContentTypeMaxLength);
                b.Property(x => x.OgrenciAdiSoyadi).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciAdiSoyadi)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciAdiSoyadiMaxLength);
                b.Property(x => x.OgrenciNo).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciNo)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciNoMaxLength);
                b.Property(x => x.OgrenciBolumu).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciBolumu)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciBolumuMaxLength);
                b.Property(x => x.OgrenciOgretimYili).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciOgretimYili)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciOgretimYiliMaxLength);
                b.Property(x => x.OgrenciTelefonNo).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciTelefonNo)).IsRequired();
                b.Property(x => x.OgrenciEposta).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciEposta)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciEpostaMaxLength);
                b.Property(x => x.OgrenciAdresi).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciAdresi)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciAdresiMaxLength);
                b.Property(x => x.KurulusAdi).HasColumnName(nameof(OgrenciStajBasvurusu.KurulusAdi)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.KurulusAdiMaxLength);
                b.Property(x => x.KurulusTelefonNo).HasColumnName(nameof(OgrenciStajBasvurusu.KurulusTelefonNo)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.KurulusTelefonNoMaxLength);
                b.Property(x => x.KurulusAdresi).HasColumnName(nameof(OgrenciStajBasvurusu.KurulusAdresi)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.KurulusAdresiMaxLength);
                b.Property(x => x.StajYeriYetkilisiAdiSoyadi).HasColumnName(nameof(OgrenciStajBasvurusu.StajYeriYetkilisiAdiSoyadi)).HasMaxLength(OgrenciStajBasvurusuConsts.StajYeriYetkilisiAdiSoyadiMaxLength);
                b.Property(x => x.StajYeriYetkilisiGorevVeUnvani).HasColumnName(nameof(OgrenciStajBasvurusu.StajYeriYetkilisiGorevVeUnvani)).HasMaxLength(OgrenciStajBasvurusuConsts.StajYeriYetkilisiGorevVeUnvaniMaxLength);
                b.Property(x => x.StajYeriYetkilisiEpostaAdresi).HasColumnName(nameof(OgrenciStajBasvurusu.StajYeriYetkilisiEpostaAdresi)).HasMaxLength(OgrenciStajBasvurusuConsts.StajYeriYetkilisiEpostaAdresiMaxLength);
                b.Property(x => x.StajYeriYetkilisiOnayTarihi).HasColumnName(nameof(OgrenciStajBasvurusu.StajYeriYetkilisiOnayTarihi));
                b.Property(x => x.StajYeriYetkilisiImzaFileName).HasColumnName(nameof(OgrenciStajBasvurusu.StajYeriYetkilisiImzaFileName)).HasMaxLength(OgrenciStajBasvurusuConsts.StajYeriYetkilisiImzaFileNameMaxLength);
                b.Property(x => x.StajYeriYetkilisiImzaContentType).HasColumnName(nameof(OgrenciStajBasvurusu.StajYeriYetkilisiImzaContentType)).HasMaxLength(OgrenciStajBasvurusuConsts.StajYeriYetkilisiImzaContentTypeMaxLength);
                b.Property(x => x.OgrenciStajBaslamaTarihi).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciStajBaslamaTarihi));
                b.Property(x => x.OgrenciStajBitisTarihi).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciStajBitisTarihi));
                b.Property(x => x.OgrenciAdi).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciAdi)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciAdiMaxLength);
                b.Property(x => x.OgrenciSoyadi).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciSoyadi)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciSoyadiMaxLength);
                b.Property(x => x.OgrenciTcKimlikNo).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciTcKimlikNo)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciTcKimlikNoMaxLength);
                b.Property(x => x.OgrenciSskNo).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciSskNo)).HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciSskNoMaxLength);
                b.Property(x => x.OgrenciBabaAdi).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciBabaAdi)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciBabaAdiMaxLength);
                b.Property(x => x.OgrenciAnaAdi).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciAnaAdi)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciAnaAdiMaxLength);
                b.Property(x => x.OgrenciDogumYeri).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciDogumYeri)).IsRequired().HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciDogumYeriMaxLength);
                b.Property(x => x.OgrenciDogumTarihi).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciDogumTarihi));
                b.Property(x => x.OgrenciSaglikGuvencesi).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciSaglikGuvencesi));
                b.Property(x => x.BolumStajKomisyonuBaskanOnayiTarihi).HasColumnName(nameof(OgrenciStajBasvurusu.BolumStajKomisyonuBaskanOnayiTarihi));
                b.Property(x => x.BolumStajKomisyonuBaskanOnayiImzaFileName).HasColumnName(nameof(OgrenciStajBasvurusu.BolumStajKomisyonuBaskanOnayiImzaFileName)).HasMaxLength(OgrenciStajBasvurusuConsts.BolumStajKomisyonuBaskanOnayiImzaFileNameMaxLength);
                b.Property(x => x.BolumStajKomisyonuBaskanOnayiImzaContentType).HasColumnName(nameof(OgrenciStajBasvurusu.BolumStajKomisyonuBaskanOnayiImzaContentType)).HasMaxLength(OgrenciStajBasvurusuConsts.BolumStajKomisyonuBaskanOnayiImzaContentTypeMaxLength);
                b.Property(x => x.DekanlikOnayTarihi).HasColumnName(nameof(OgrenciStajBasvurusu.DekanlikOnayTarihi));
                b.Property(x => x.DekanlikOnayImzaFileName).HasColumnName(nameof(OgrenciStajBasvurusu.DekanlikOnayImzaFileName)).HasMaxLength(OgrenciStajBasvurusuConsts.DekanlikOnayImzaFileNameMaxLength);
                b.Property(x => x.DekanlikOnayImzaFileContentType).HasColumnName(nameof(OgrenciStajBasvurusu.DekanlikOnayImzaFileContentType)).HasMaxLength(OgrenciStajBasvurusuConsts.DekanlikOnayImzaFileContentTypeMaxLength);
                b.Property(x => x.SksDaireBaskanligiOnayTarihi).HasColumnName(nameof(OgrenciStajBasvurusu.SksDaireBaskanligiOnayTarihi));
                b.Property(x => x.SksDaireBaskanligiOnayImzaFileName).HasColumnName(nameof(OgrenciStajBasvurusu.SksDaireBaskanligiOnayImzaFileName)).HasMaxLength(OgrenciStajBasvurusuConsts.SksDaireBaskanligiOnayImzaFileNameMaxLength);
                b.Property(x => x.SksDaireBaskanligiOnayImzaFileContentType).HasColumnName(nameof(OgrenciStajBasvurusu.SksDaireBaskanligiOnayImzaFileContentType)).HasMaxLength(OgrenciStajBasvurusuConsts.SksDaireBaskanligiOnayImzaFileContentTypeMaxLength);
                b.Property(x => x.OgrenciImzaFileName).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciImzaFileName)).HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciImzaFileNameMaxLength);
                b.Property(x => x.OgrenciImzaFileContentType).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciImzaFileContentType)).HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciImzaFileContentTypeMaxLength);
                b.Property(x => x.OgrenciVesikalikFileName).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciVesikalikFileName)).HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciVesikalikFileNameMaxLength);
                b.Property(x => x.OgrenciVesikalikFileContentType).HasColumnName(nameof(OgrenciStajBasvurusu.OgrenciVesikalikFileContentType)).HasMaxLength(OgrenciStajBasvurusuConsts.OgrenciVesikalikFileContentTypeMaxLength);
            });

        }
    }
}