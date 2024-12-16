using Etu.StajSistemi.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using JetBrains.Annotations;

using Volo.Abp;

namespace Etu.StajSistemi.OgrenciStajBasvurusus
{
    public class OgrenciStajBasvurusu : FullAuditedAggregateRoot<Guid>
    {
        public virtual int GunSayisi { get; set; }

        [NotNull]
        public virtual string BolumBaskaniAdiSoyadi { get; set; }

        [CanBeNull]
        public virtual string? BolumBaskaniImzasi { get; set; }

        [CanBeNull]
        public virtual string? BolumBaskaniImzasiContentType { get; set; }

        [NotNull]
        public virtual string OgrenciAdiSoyadi { get; set; }

        [NotNull]
        public virtual string OgrenciNo { get; set; }

        [NotNull]
        public virtual string OgrenciBolumu { get; set; }

        [NotNull]
        public virtual string OgrenciOgretimYili { get; set; }

        [NotNull]
        public virtual string OgrenciTelefonNo { get; set; }

        [NotNull]
        public virtual string OgrenciEposta { get; set; }

        [NotNull]
        public virtual string OgrenciAdresi { get; set; }

        [CanBeNull]
        public virtual string? OgrenciVesikalikFileName { get; set; }

        [CanBeNull]
        public virtual string? OgrenciVesikalikFileContentType { get; set; }

        [NotNull]
        public virtual string KurulusAdi { get; set; }

        [NotNull]
        public virtual string KurulusTelefonNo { get; set; }

        [NotNull]
        public virtual string KurulusAdresi { get; set; }

        [CanBeNull]
        public virtual string? StajYeriYetkilisiAdiSoyadi { get; set; }

        [CanBeNull]
        public virtual string? StajYeriYetkilisiGorevVeUnvani { get; set; }

        [CanBeNull]
        public virtual string? StajYeriYetkilisiEpostaAdresi { get; set; }

        public virtual DateTime? StajYeriYetkilisiOnayTarihi { get; set; }

        [CanBeNull]
        public virtual string? StajYeriYetkilisiImzaFileName { get; set; }

        [CanBeNull]
        public virtual string? StajYeriYetkilisiImzaContentType { get; set; }

        public virtual DateTime OgrenciStajBaslamaTarihi { get; set; }

        public virtual DateTime OgrenciStajBitisTarihi { get; set; }

        [NotNull]
        public virtual string OgrenciAdi { get; set; }

        [NotNull]
        public virtual string OgrenciSoyadi { get; set; }

        [NotNull]
        public virtual string OgrenciTcKimlikNo { get; set; }

        [CanBeNull]
        public virtual string? OgrenciSskNo { get; set; }

        [NotNull]
        public virtual string OgrenciBabaAdi { get; set; }

        [NotNull]
        public virtual string OgrenciAnaAdi { get; set; }

        [NotNull]
        public virtual string OgrenciDogumYeri { get; set; }

        public virtual DateTime OgrenciDogumTarihi { get; set; }

        public virtual OgrenciSaglikGuvencesi OgrenciSaglikGuvencesi { get; set; }

        public virtual DateTime? BolumStajKomisyonuBaskanOnayiTarihi { get; set; }

        [CanBeNull]
        public virtual string? BolumStajKomisyonuBaskanOnayiImzaFileName { get; set; }

        [CanBeNull]
        public virtual string? BolumStajKomisyonuBaskanOnayiImzaContentType { get; set; }

        public virtual DateTime? DekanlikOnayTarihi { get; set; }

        [CanBeNull]
        public virtual string? DekanlikOnayImzaFileName { get; set; }

        [CanBeNull]
        public virtual string? DekanlikOnayImzaFileContentType { get; set; }

        public virtual DateTime? SksDaireBaskanligiOnayTarihi { get; set; }

        [CanBeNull]
        public virtual string? SksDaireBaskanligiOnayImzaFileName { get; set; }

        [CanBeNull]
        public virtual string? SksDaireBaskanligiOnayImzaFileContentType { get; set; }

        [CanBeNull]
        public virtual string? OgrenciImzaFileName { get; set; }

        [CanBeNull]
        public virtual string? OgrenciImzaFileContentType { get; set; }

        public DateTime? BolumBaskaniOnayTarihi { get; set; }
        
        public virtual BasvuruDurumu BasvuruDurumu { get; set; }
        
        public virtual string? BasvuruRedAciklamasi { get; set; }
        
        public virtual DateTime? BasvuruRedTarihi { get; set; }

        protected OgrenciStajBasvurusu()
        {

        }

        public OgrenciStajBasvurusu(Guid id, int gunSayisi, string bolumBaskaniAdiSoyadi, string ogrenciAdiSoyadi, string ogrenciNo, string ogrenciBolumu, string ogrenciOgretimYili, string ogrenciTelefonNo, string ogrenciEposta, string ogrenciAdresi, string kurulusAdi, string kurulusTelefonNo, string kurulusAdresi, DateTime ogrenciStajBaslamaTarihi, DateTime ogrenciStajBitisTarihi, string ogrenciAdi, string ogrenciSoyadi, string ogrenciTcKimlikNo, string ogrenciBabaAdi, string ogrenciAnaAdi, string ogrenciDogumYeri, DateTime ogrenciDogumTarihi, OgrenciSaglikGuvencesi ogrenciSaglikGuvencesi, string? stajYeriYetkilisiAdiSoyadi = null, string? stajYeriYetkilisiGorevVeUnvani = null, string? stajYeriYetkilisiEpostaAdresi = null, DateTime? stajYeriYetkilisiOnayTarihi = null, string? ogrenciSskNo = null, DateTime? bolumStajKomisyonuBaskanOnayiTarihi = null, DateTime? dekanlikOnayTarihi = null, DateTime? sksDaireBaskanligiOnayTarihi = null)
        {

            Id = id;
            if (gunSayisi < OgrenciStajBasvurusuConsts.GunSayisiMinLength)
            {
                throw new ArgumentOutOfRangeException(nameof(gunSayisi), gunSayisi, "The value of 'gunSayisi' cannot be lower than " + OgrenciStajBasvurusuConsts.GunSayisiMinLength);
            }

            if (gunSayisi > OgrenciStajBasvurusuConsts.GunSayisiMaxLength)
            {
                throw new ArgumentOutOfRangeException(nameof(gunSayisi), gunSayisi, "The value of 'gunSayisi' cannot be greater than " + OgrenciStajBasvurusuConsts.GunSayisiMaxLength);
            }

            Check.NotNull(bolumBaskaniAdiSoyadi, nameof(bolumBaskaniAdiSoyadi));
            Check.Length(bolumBaskaniAdiSoyadi, nameof(bolumBaskaniAdiSoyadi), OgrenciStajBasvurusuConsts.BolumBaskaniAdiSoyadiMaxLength, OgrenciStajBasvurusuConsts.BolumBaskaniAdiSoyadiMinLength);
            Check.NotNull(ogrenciAdiSoyadi, nameof(ogrenciAdiSoyadi));
            Check.Length(ogrenciAdiSoyadi, nameof(ogrenciAdiSoyadi), OgrenciStajBasvurusuConsts.OgrenciAdiSoyadiMaxLength, OgrenciStajBasvurusuConsts.OgrenciAdiSoyadiMinLength);
            Check.NotNull(ogrenciNo, nameof(ogrenciNo));
            Check.Length(ogrenciNo, nameof(ogrenciNo), OgrenciStajBasvurusuConsts.OgrenciNoMaxLength, OgrenciStajBasvurusuConsts.OgrenciNoMinLength);
            Check.NotNull(ogrenciBolumu, nameof(ogrenciBolumu));
            Check.Length(ogrenciBolumu, nameof(ogrenciBolumu), OgrenciStajBasvurusuConsts.OgrenciBolumuMaxLength, OgrenciStajBasvurusuConsts.OgrenciBolumuMinLength);
            Check.NotNull(ogrenciOgretimYili, nameof(ogrenciOgretimYili));
            Check.Length(ogrenciOgretimYili, nameof(ogrenciOgretimYili), OgrenciStajBasvurusuConsts.OgrenciOgretimYiliMaxLength, 0);
            Check.NotNull(ogrenciTelefonNo, nameof(ogrenciTelefonNo));
            Check.NotNull(ogrenciEposta, nameof(ogrenciEposta));
            Check.Length(ogrenciEposta, nameof(ogrenciEposta), OgrenciStajBasvurusuConsts.OgrenciEpostaMaxLength, 0);
            Check.NotNull(ogrenciAdresi, nameof(ogrenciAdresi));
            Check.Length(ogrenciAdresi, nameof(ogrenciAdresi), OgrenciStajBasvurusuConsts.OgrenciAdresiMaxLength, 0);
            Check.NotNull(kurulusAdi, nameof(kurulusAdi));
            Check.Length(kurulusAdi, nameof(kurulusAdi), OgrenciStajBasvurusuConsts.KurulusAdiMaxLength, 0);
            Check.NotNull(kurulusTelefonNo, nameof(kurulusTelefonNo));
            Check.Length(kurulusTelefonNo, nameof(kurulusTelefonNo), OgrenciStajBasvurusuConsts.KurulusTelefonNoMaxLength, 0);
            Check.NotNull(kurulusAdresi, nameof(kurulusAdresi));
            Check.Length(kurulusAdresi, nameof(kurulusAdresi), OgrenciStajBasvurusuConsts.KurulusAdresiMaxLength, 0);
            Check.NotNull(ogrenciAdi, nameof(ogrenciAdi));
            Check.Length(ogrenciAdi, nameof(ogrenciAdi), OgrenciStajBasvurusuConsts.OgrenciAdiMaxLength, 0);
            Check.NotNull(ogrenciSoyadi, nameof(ogrenciSoyadi));
            Check.Length(ogrenciSoyadi, nameof(ogrenciSoyadi), OgrenciStajBasvurusuConsts.OgrenciSoyadiMaxLength, 0);
            Check.NotNull(ogrenciTcKimlikNo, nameof(ogrenciTcKimlikNo));
            Check.Length(ogrenciTcKimlikNo, nameof(ogrenciTcKimlikNo), OgrenciStajBasvurusuConsts.OgrenciTcKimlikNoMaxLength, 0);
            Check.NotNull(ogrenciBabaAdi, nameof(ogrenciBabaAdi));
            Check.Length(ogrenciBabaAdi, nameof(ogrenciBabaAdi), OgrenciStajBasvurusuConsts.OgrenciBabaAdiMaxLength, 0);
            Check.NotNull(ogrenciAnaAdi, nameof(ogrenciAnaAdi));
            Check.Length(ogrenciAnaAdi, nameof(ogrenciAnaAdi), OgrenciStajBasvurusuConsts.OgrenciAnaAdiMaxLength, 0);
            Check.NotNull(ogrenciDogumYeri, nameof(ogrenciDogumYeri));
            Check.Length(ogrenciDogumYeri, nameof(ogrenciDogumYeri), OgrenciStajBasvurusuConsts.OgrenciDogumYeriMaxLength, 0);
            Check.Length(stajYeriYetkilisiAdiSoyadi, nameof(stajYeriYetkilisiAdiSoyadi), OgrenciStajBasvurusuConsts.StajYeriYetkilisiAdiSoyadiMaxLength, 0);
            Check.Length(stajYeriYetkilisiGorevVeUnvani, nameof(stajYeriYetkilisiGorevVeUnvani), OgrenciStajBasvurusuConsts.StajYeriYetkilisiGorevVeUnvaniMaxLength, 0);
            Check.Length(stajYeriYetkilisiEpostaAdresi, nameof(stajYeriYetkilisiEpostaAdresi), OgrenciStajBasvurusuConsts.StajYeriYetkilisiEpostaAdresiMaxLength, 0);
            Check.Length(ogrenciSskNo, nameof(ogrenciSskNo), OgrenciStajBasvurusuConsts.OgrenciSskNoMaxLength, 0);
            GunSayisi = gunSayisi;
            BolumBaskaniAdiSoyadi = bolumBaskaniAdiSoyadi;
            OgrenciAdiSoyadi = ogrenciAdiSoyadi;
            OgrenciNo = ogrenciNo;
            OgrenciBolumu = ogrenciBolumu;
            OgrenciOgretimYili = ogrenciOgretimYili;
            OgrenciTelefonNo = ogrenciTelefonNo;
            OgrenciEposta = ogrenciEposta;
            OgrenciAdresi = ogrenciAdresi;
            KurulusAdi = kurulusAdi;
            KurulusTelefonNo = kurulusTelefonNo;
            KurulusAdresi = kurulusAdresi;
            OgrenciStajBaslamaTarihi = ogrenciStajBaslamaTarihi;
            OgrenciStajBitisTarihi = ogrenciStajBitisTarihi;
            OgrenciAdi = ogrenciAdi;
            OgrenciSoyadi = ogrenciSoyadi;
            OgrenciTcKimlikNo = ogrenciTcKimlikNo;
            OgrenciBabaAdi = ogrenciBabaAdi;
            OgrenciAnaAdi = ogrenciAnaAdi;
            OgrenciDogumYeri = ogrenciDogumYeri;
            OgrenciDogumTarihi = ogrenciDogumTarihi;
            OgrenciSaglikGuvencesi = ogrenciSaglikGuvencesi;
            StajYeriYetkilisiAdiSoyadi = stajYeriYetkilisiAdiSoyadi;
            StajYeriYetkilisiGorevVeUnvani = stajYeriYetkilisiGorevVeUnvani;
            StajYeriYetkilisiEpostaAdresi = stajYeriYetkilisiEpostaAdresi;
            StajYeriYetkilisiOnayTarihi = stajYeriYetkilisiOnayTarihi;
            OgrenciSskNo = ogrenciSskNo;
            BolumStajKomisyonuBaskanOnayiTarihi = bolumStajKomisyonuBaskanOnayiTarihi;
            DekanlikOnayTarihi = dekanlikOnayTarihi;
            SksDaireBaskanligiOnayTarihi = sksDaireBaskanligiOnayTarihi;
            BasvuruDurumu = BasvuruDurumu.StajYeriYetkilisiOnayiBekleniyor;
        }

    }
}