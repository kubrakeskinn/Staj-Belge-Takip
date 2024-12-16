using Etu.StajSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.Data;

namespace Etu.StajSistemi.OgrenciStajBasvurusus
{
    public class OgrenciStajBasvurusuManager : DomainService
    {
        protected IOgrenciStajBasvurusuRepository _ogrenciStajBasvurusuRepository;

        public OgrenciStajBasvurusuManager(IOgrenciStajBasvurusuRepository ogrenciStajBasvurusuRepository)
        {
            _ogrenciStajBasvurusuRepository = ogrenciStajBasvurusuRepository;
        }

        public virtual async Task<OgrenciStajBasvurusu> CreateAsync(
        int gunSayisi, string bolumBaskaniAdiSoyadi, string ogrenciAdiSoyadi, string ogrenciNo, string ogrenciBolumu, string ogrenciOgretimYili, string ogrenciTelefonNo, string ogrenciEposta, string ogrenciAdresi, string kurulusAdi, string kurulusTelefonNo, string kurulusAdresi, DateTime ogrenciStajBaslamaTarihi, DateTime ogrenciStajBitisTarihi, string ogrenciAdi, string ogrenciSoyadi, string ogrenciTcKimlikNo, string ogrenciBabaAdi, string ogrenciAnaAdi, string ogrenciDogumYeri, DateTime ogrenciDogumTarihi, OgrenciSaglikGuvencesi ogrenciSaglikGuvencesi, string? stajYeriYetkilisiAdiSoyadi = null, string? stajYeriYetkilisiGorevVeUnvani = null, string? stajYeriYetkilisiEpostaAdresi = null, DateTime? stajYeriYetkilisiOnayTarihi = null, string? ogrenciSskNo = null, DateTime? bolumStajKomisyonuBaskanOnayiTarihi = null, DateTime? dekanlikOnayTarihi = null, DateTime? sksDaireBaskanligiOnayTarihi = null)
        {
            Check.Range(gunSayisi, nameof(gunSayisi), OgrenciStajBasvurusuConsts.GunSayisiMinLength, OgrenciStajBasvurusuConsts.GunSayisiMaxLength);
            Check.NotNullOrWhiteSpace(bolumBaskaniAdiSoyadi, nameof(bolumBaskaniAdiSoyadi));
            Check.Length(bolumBaskaniAdiSoyadi, nameof(bolumBaskaniAdiSoyadi), OgrenciStajBasvurusuConsts.BolumBaskaniAdiSoyadiMaxLength, OgrenciStajBasvurusuConsts.BolumBaskaniAdiSoyadiMinLength);
            Check.NotNullOrWhiteSpace(ogrenciAdiSoyadi, nameof(ogrenciAdiSoyadi));
            Check.Length(ogrenciAdiSoyadi, nameof(ogrenciAdiSoyadi), OgrenciStajBasvurusuConsts.OgrenciAdiSoyadiMaxLength, OgrenciStajBasvurusuConsts.OgrenciAdiSoyadiMinLength);
            Check.NotNullOrWhiteSpace(ogrenciNo, nameof(ogrenciNo));
            Check.Length(ogrenciNo, nameof(ogrenciNo), OgrenciStajBasvurusuConsts.OgrenciNoMaxLength, OgrenciStajBasvurusuConsts.OgrenciNoMinLength);
            Check.NotNullOrWhiteSpace(ogrenciBolumu, nameof(ogrenciBolumu));
            Check.Length(ogrenciBolumu, nameof(ogrenciBolumu), OgrenciStajBasvurusuConsts.OgrenciBolumuMaxLength, OgrenciStajBasvurusuConsts.OgrenciBolumuMinLength);
            Check.NotNullOrWhiteSpace(ogrenciOgretimYili, nameof(ogrenciOgretimYili));
            Check.Length(ogrenciOgretimYili, nameof(ogrenciOgretimYili), OgrenciStajBasvurusuConsts.OgrenciOgretimYiliMaxLength);
            Check.NotNullOrWhiteSpace(ogrenciTelefonNo, nameof(ogrenciTelefonNo));
            Check.NotNullOrWhiteSpace(ogrenciEposta, nameof(ogrenciEposta));
            Check.Length(ogrenciEposta, nameof(ogrenciEposta), OgrenciStajBasvurusuConsts.OgrenciEpostaMaxLength);
            Check.NotNullOrWhiteSpace(ogrenciAdresi, nameof(ogrenciAdresi));
            Check.Length(ogrenciAdresi, nameof(ogrenciAdresi), OgrenciStajBasvurusuConsts.OgrenciAdresiMaxLength);
            Check.NotNullOrWhiteSpace(kurulusAdi, nameof(kurulusAdi));
            Check.Length(kurulusAdi, nameof(kurulusAdi), OgrenciStajBasvurusuConsts.KurulusAdiMaxLength);
            Check.NotNullOrWhiteSpace(kurulusTelefonNo, nameof(kurulusTelefonNo));
            Check.Length(kurulusTelefonNo, nameof(kurulusTelefonNo), OgrenciStajBasvurusuConsts.KurulusTelefonNoMaxLength);
            Check.NotNullOrWhiteSpace(kurulusAdresi, nameof(kurulusAdresi));
            Check.Length(kurulusAdresi, nameof(kurulusAdresi), OgrenciStajBasvurusuConsts.KurulusAdresiMaxLength);
            Check.NotNull(ogrenciStajBaslamaTarihi, nameof(ogrenciStajBaslamaTarihi));
            Check.NotNull(ogrenciStajBitisTarihi, nameof(ogrenciStajBitisTarihi));
            Check.NotNullOrWhiteSpace(ogrenciAdi, nameof(ogrenciAdi));
            Check.Length(ogrenciAdi, nameof(ogrenciAdi), OgrenciStajBasvurusuConsts.OgrenciAdiMaxLength);
            Check.NotNullOrWhiteSpace(ogrenciSoyadi, nameof(ogrenciSoyadi));
            Check.Length(ogrenciSoyadi, nameof(ogrenciSoyadi), OgrenciStajBasvurusuConsts.OgrenciSoyadiMaxLength);
            Check.NotNullOrWhiteSpace(ogrenciTcKimlikNo, nameof(ogrenciTcKimlikNo));
            Check.Length(ogrenciTcKimlikNo, nameof(ogrenciTcKimlikNo), OgrenciStajBasvurusuConsts.OgrenciTcKimlikNoMaxLength);
            Check.NotNullOrWhiteSpace(ogrenciBabaAdi, nameof(ogrenciBabaAdi));
            Check.Length(ogrenciBabaAdi, nameof(ogrenciBabaAdi), OgrenciStajBasvurusuConsts.OgrenciBabaAdiMaxLength);
            Check.NotNullOrWhiteSpace(ogrenciAnaAdi, nameof(ogrenciAnaAdi));
            Check.Length(ogrenciAnaAdi, nameof(ogrenciAnaAdi), OgrenciStajBasvurusuConsts.OgrenciAnaAdiMaxLength);
            Check.NotNullOrWhiteSpace(ogrenciDogumYeri, nameof(ogrenciDogumYeri));
            Check.Length(ogrenciDogumYeri, nameof(ogrenciDogumYeri), OgrenciStajBasvurusuConsts.OgrenciDogumYeriMaxLength);
            Check.NotNull(ogrenciDogumTarihi, nameof(ogrenciDogumTarihi));
            Check.NotNull(ogrenciSaglikGuvencesi, nameof(ogrenciSaglikGuvencesi));
            Check.Length(stajYeriYetkilisiAdiSoyadi, nameof(stajYeriYetkilisiAdiSoyadi), OgrenciStajBasvurusuConsts.StajYeriYetkilisiAdiSoyadiMaxLength);
            Check.Length(stajYeriYetkilisiGorevVeUnvani, nameof(stajYeriYetkilisiGorevVeUnvani), OgrenciStajBasvurusuConsts.StajYeriYetkilisiGorevVeUnvaniMaxLength);
            Check.Length(stajYeriYetkilisiEpostaAdresi, nameof(stajYeriYetkilisiEpostaAdresi), OgrenciStajBasvurusuConsts.StajYeriYetkilisiEpostaAdresiMaxLength);
            Check.Length(ogrenciSskNo, nameof(ogrenciSskNo), OgrenciStajBasvurusuConsts.OgrenciSskNoMaxLength);

            var ogrenciStajBasvurusu = new OgrenciStajBasvurusu(
             GuidGenerator.Create(),
             gunSayisi, bolumBaskaniAdiSoyadi, ogrenciAdiSoyadi, ogrenciNo, ogrenciBolumu, ogrenciOgretimYili, ogrenciTelefonNo, ogrenciEposta, ogrenciAdresi, kurulusAdi, kurulusTelefonNo, kurulusAdresi, ogrenciStajBaslamaTarihi, ogrenciStajBitisTarihi, ogrenciAdi, ogrenciSoyadi, ogrenciTcKimlikNo, ogrenciBabaAdi, ogrenciAnaAdi, ogrenciDogumYeri, ogrenciDogumTarihi, ogrenciSaglikGuvencesi, stajYeriYetkilisiAdiSoyadi, stajYeriYetkilisiGorevVeUnvani, stajYeriYetkilisiEpostaAdresi, stajYeriYetkilisiOnayTarihi, ogrenciSskNo, bolumStajKomisyonuBaskanOnayiTarihi, dekanlikOnayTarihi, sksDaireBaskanligiOnayTarihi
             );

            return await _ogrenciStajBasvurusuRepository.InsertAsync(ogrenciStajBasvurusu);
        }

    }
}