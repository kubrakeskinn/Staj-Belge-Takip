using Etu.StajSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Etu.StajSistemi.Data;

namespace Etu.StajSistemi.OgrenciStajBasvurusus
{
    public class EfCoreOgrenciStajBasvurusuRepository : EfCoreRepository<StajSistemiDbContext, OgrenciStajBasvurusu, Guid>, IOgrenciStajBasvurusuRepository
    {
        public EfCoreOgrenciStajBasvurusuRepository(IDbContextProvider<StajSistemiDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public virtual async Task<List<OgrenciStajBasvurusu>> GetListAsync(
            string? filterText = null,
            int? gunSayisiMin = null,
            int? gunSayisiMax = null,
            string? bolumBaskaniAdiSoyadi = null,
            string? ogrenciAdiSoyadi = null,
            string? ogrenciNo = null,
            string? ogrenciBolumu = null,
            string? ogrenciOgretimYili = null,
            string? ogrenciTelefonNo = null,
            string? ogrenciEposta = null,
            string? ogrenciAdresi = null,
            string? kurulusAdi = null,
            string? kurulusTelefonNo = null,
            string? kurulusAdresi = null,
            string? stajYeriYetkilisiAdiSoyadi = null,
            string? stajYeriYetkilisiGorevVeUnvani = null,
            string? stajYeriYetkilisiEpostaAdresi = null,
            DateTime? stajYeriYetkilisiOnayTarihiMin = null,
            DateTime? stajYeriYetkilisiOnayTarihiMax = null,
            DateTime? ogrenciStajBaslamaTarihiMin = null,
            DateTime? ogrenciStajBaslamaTarihiMax = null,
            DateTime? ogrenciStajBitisTarihiMin = null,
            DateTime? ogrenciStajBitisTarihiMax = null,
            string? ogrenciAdi = null,
            string? ogrenciSoyadi = null,
            string? ogrenciTcKimlikNo = null,
            string? ogrenciSskNo = null,
            string? ogrenciBabaAdi = null,
            string? ogrenciAnaAdi = null,
            string? ogrenciDogumYeri = null,
            DateTime? ogrenciDogumTarihiMin = null,
            DateTime? ogrenciDogumTarihiMax = null,
            OgrenciSaglikGuvencesi? ogrenciSaglikGuvencesi = null,
            DateTime? bolumStajKomisyonuBaskanOnayiTarihiMin = null,
            DateTime? bolumStajKomisyonuBaskanOnayiTarihiMax = null,
            DateTime? dekanlikOnayTarihiMin = null,
            DateTime? dekanlikOnayTarihiMax = null,
            DateTime? sksDaireBaskanligiOnayTarihiMin = null,
            DateTime? sksDaireBaskanligiOnayTarihiMax = null,
            string? sorting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            BasvuruDurumu? basvuruDurumu = null,
            Guid? creatorId = null,
            CancellationToken cancellationToken = default)
        {
            var query = ApplyFilter((await GetQueryableAsync()), filterText, gunSayisiMin, gunSayisiMax, bolumBaskaniAdiSoyadi, ogrenciAdiSoyadi, ogrenciNo, ogrenciBolumu, ogrenciOgretimYili, ogrenciTelefonNo, ogrenciEposta, ogrenciAdresi, kurulusAdi, kurulusTelefonNo, kurulusAdresi, stajYeriYetkilisiAdiSoyadi, stajYeriYetkilisiGorevVeUnvani, stajYeriYetkilisiEpostaAdresi, stajYeriYetkilisiOnayTarihiMin, stajYeriYetkilisiOnayTarihiMax, ogrenciStajBaslamaTarihiMin, ogrenciStajBaslamaTarihiMax, ogrenciStajBitisTarihiMin, ogrenciStajBitisTarihiMax, ogrenciAdi, ogrenciSoyadi, ogrenciTcKimlikNo, ogrenciSskNo, ogrenciBabaAdi, ogrenciAnaAdi, ogrenciDogumYeri, ogrenciDogumTarihiMin, ogrenciDogumTarihiMax, ogrenciSaglikGuvencesi, bolumStajKomisyonuBaskanOnayiTarihiMin, bolumStajKomisyonuBaskanOnayiTarihiMax, dekanlikOnayTarihiMin, dekanlikOnayTarihiMax, sksDaireBaskanligiOnayTarihiMin, sksDaireBaskanligiOnayTarihiMax, basvuruDurumu, creatorId);
            query = query.OrderBy(string.IsNullOrWhiteSpace(sorting) ? OgrenciStajBasvurusuConsts.GetDefaultSorting(false) : sorting);
            return await query.PageBy(skipCount, maxResultCount).ToListAsync(cancellationToken);
        }

        public virtual async Task<long> GetCountAsync(string? filterText = null,
            int? gunSayisiMin = null,
            int? gunSayisiMax = null,
            string? bolumBaskaniAdiSoyadi = null,
            string? ogrenciAdiSoyadi = null,
            string? ogrenciNo = null,
            string? ogrenciBolumu = null,
            string? ogrenciOgretimYili = null,
            string? ogrenciTelefonNo = null,
            string? ogrenciEposta = null,
            string? ogrenciAdresi = null,
            string? kurulusAdi = null,
            string? kurulusTelefonNo = null,
            string? kurulusAdresi = null,
            string? stajYeriYetkilisiAdiSoyadi = null,
            string? stajYeriYetkilisiGorevVeUnvani = null,
            string? stajYeriYetkilisiEpostaAdresi = null,
            DateTime? stajYeriYetkilisiOnayTarihiMin = null,
            DateTime? stajYeriYetkilisiOnayTarihiMax = null,
            DateTime? ogrenciStajBaslamaTarihiMin = null,
            DateTime? ogrenciStajBaslamaTarihiMax = null,
            DateTime? ogrenciStajBitisTarihiMin = null,
            DateTime? ogrenciStajBitisTarihiMax = null,
            string? ogrenciAdi = null,
            string? ogrenciSoyadi = null,
            string? ogrenciTcKimlikNo = null,
            string? ogrenciSskNo = null,
            string? ogrenciBabaAdi = null,
            string? ogrenciAnaAdi = null,
            string? ogrenciDogumYeri = null,
            DateTime? ogrenciDogumTarihiMin = null,
            DateTime? ogrenciDogumTarihiMax = null,
            OgrenciSaglikGuvencesi? ogrenciSaglikGuvencesi = null,
            DateTime? bolumStajKomisyonuBaskanOnayiTarihiMin = null,
            DateTime? bolumStajKomisyonuBaskanOnayiTarihiMax = null,
            DateTime? dekanlikOnayTarihiMin = null,
            DateTime? dekanlikOnayTarihiMax = null,
            DateTime? sksDaireBaskanligiOnayTarihiMin = null,
            DateTime? sksDaireBaskanligiOnayTarihiMax = null,
            BasvuruDurumu? basvuruDurumu = null,
            Guid? creatorId = null,
            CancellationToken cancellationToken = default)
        {
            var query = ApplyFilter((await GetDbSetAsync()), filterText, gunSayisiMin, gunSayisiMax, bolumBaskaniAdiSoyadi, ogrenciAdiSoyadi, ogrenciNo, ogrenciBolumu, ogrenciOgretimYili, ogrenciTelefonNo, ogrenciEposta, ogrenciAdresi, kurulusAdi, kurulusTelefonNo, kurulusAdresi, stajYeriYetkilisiAdiSoyadi, stajYeriYetkilisiGorevVeUnvani, stajYeriYetkilisiEpostaAdresi, stajYeriYetkilisiOnayTarihiMin, stajYeriYetkilisiOnayTarihiMax, ogrenciStajBaslamaTarihiMin, ogrenciStajBaslamaTarihiMax, ogrenciStajBitisTarihiMin, ogrenciStajBitisTarihiMax, ogrenciAdi, ogrenciSoyadi, ogrenciTcKimlikNo, ogrenciSskNo, ogrenciBabaAdi, ogrenciAnaAdi, ogrenciDogumYeri, ogrenciDogumTarihiMin, ogrenciDogumTarihiMax, ogrenciSaglikGuvencesi, bolumStajKomisyonuBaskanOnayiTarihiMin, bolumStajKomisyonuBaskanOnayiTarihiMax, dekanlikOnayTarihiMin, dekanlikOnayTarihiMax, sksDaireBaskanligiOnayTarihiMin, sksDaireBaskanligiOnayTarihiMax, basvuruDurumu, creatorId);
            return await query.LongCountAsync(GetCancellationToken(cancellationToken));
        }

        protected virtual IQueryable<OgrenciStajBasvurusu> ApplyFilter(
            IQueryable<OgrenciStajBasvurusu> query,
            string? filterText = null,
            int? gunSayisiMin = null,
            int? gunSayisiMax = null,
            string? bolumBaskaniAdiSoyadi = null,
            string? ogrenciAdiSoyadi = null,
            string? ogrenciNo = null,
            string? ogrenciBolumu = null,
            string? ogrenciOgretimYili = null,
            string? ogrenciTelefonNo = null,
            string? ogrenciEposta = null,
            string? ogrenciAdresi = null,
            string? kurulusAdi = null,
            string? kurulusTelefonNo = null,
            string? kurulusAdresi = null,
            string? stajYeriYetkilisiAdiSoyadi = null,
            string? stajYeriYetkilisiGorevVeUnvani = null,
            string? stajYeriYetkilisiEpostaAdresi = null,
            DateTime? stajYeriYetkilisiOnayTarihiMin = null,
            DateTime? stajYeriYetkilisiOnayTarihiMax = null,
            DateTime? ogrenciStajBaslamaTarihiMin = null,
            DateTime? ogrenciStajBaslamaTarihiMax = null,
            DateTime? ogrenciStajBitisTarihiMin = null,
            DateTime? ogrenciStajBitisTarihiMax = null,
            string? ogrenciAdi = null,
            string? ogrenciSoyadi = null,
            string? ogrenciTcKimlikNo = null,
            string? ogrenciSskNo = null,
            string? ogrenciBabaAdi = null,
            string? ogrenciAnaAdi = null,
            string? ogrenciDogumYeri = null,
            DateTime? ogrenciDogumTarihiMin = null,
            DateTime? ogrenciDogumTarihiMax = null,
            OgrenciSaglikGuvencesi? ogrenciSaglikGuvencesi = null,
            DateTime? bolumStajKomisyonuBaskanOnayiTarihiMin = null,
            DateTime? bolumStajKomisyonuBaskanOnayiTarihiMax = null,
            DateTime? dekanlikOnayTarihiMin = null,
            DateTime? dekanlikOnayTarihiMax = null,
            DateTime? sksDaireBaskanligiOnayTarihiMin = null,
            DateTime? sksDaireBaskanligiOnayTarihiMax = null,
            BasvuruDurumu? basvuruDurumu = null,
            Guid? creatorId = null)
        {
            return query
                    .WhereIf(!string.IsNullOrWhiteSpace(filterText), e => e.BolumBaskaniAdiSoyadi!.Contains(filterText!) || e.OgrenciAdiSoyadi!.Contains(filterText!) || e.OgrenciNo!.Contains(filterText!) || e.OgrenciBolumu!.Contains(filterText!) || e.OgrenciOgretimYili!.Contains(filterText!) || e.OgrenciTelefonNo!.Contains(filterText!) || e.OgrenciEposta!.Contains(filterText!) || e.OgrenciAdresi!.Contains(filterText!) || e.KurulusAdi!.Contains(filterText!) || e.KurulusTelefonNo!.Contains(filterText!) || e.KurulusAdresi!.Contains(filterText!) || e.StajYeriYetkilisiAdiSoyadi!.Contains(filterText!) || e.StajYeriYetkilisiGorevVeUnvani!.Contains(filterText!) || e.StajYeriYetkilisiEpostaAdresi!.Contains(filterText!) || e.OgrenciAdi!.Contains(filterText!) || e.OgrenciSoyadi!.Contains(filterText!) || e.OgrenciTcKimlikNo!.Contains(filterText!) || e.OgrenciSskNo!.Contains(filterText!) || e.OgrenciBabaAdi!.Contains(filterText!) || e.OgrenciAnaAdi!.Contains(filterText!) || e.OgrenciDogumYeri!.Contains(filterText!))
                    .WhereIf(gunSayisiMin.HasValue, e => e.GunSayisi >= gunSayisiMin!.Value)
                    .WhereIf(gunSayisiMax.HasValue, e => e.GunSayisi <= gunSayisiMax!.Value)
                    .WhereIf(!string.IsNullOrWhiteSpace(bolumBaskaniAdiSoyadi), e => e.BolumBaskaniAdiSoyadi.Contains(bolumBaskaniAdiSoyadi))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciAdiSoyadi), e => e.OgrenciAdiSoyadi.Contains(ogrenciAdiSoyadi))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciNo), e => e.OgrenciNo.Contains(ogrenciNo))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciBolumu), e => e.OgrenciBolumu.Contains(ogrenciBolumu))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciOgretimYili), e => e.OgrenciOgretimYili.Contains(ogrenciOgretimYili))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciTelefonNo), e => e.OgrenciTelefonNo.Contains(ogrenciTelefonNo))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciEposta), e => e.OgrenciEposta.Contains(ogrenciEposta))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciAdresi), e => e.OgrenciAdresi.Contains(ogrenciAdresi))
                    .WhereIf(!string.IsNullOrWhiteSpace(kurulusAdi), e => e.KurulusAdi.Contains(kurulusAdi))
                    .WhereIf(!string.IsNullOrWhiteSpace(kurulusTelefonNo), e => e.KurulusTelefonNo.Contains(kurulusTelefonNo))
                    .WhereIf(!string.IsNullOrWhiteSpace(kurulusAdresi), e => e.KurulusAdresi.Contains(kurulusAdresi))
                    .WhereIf(!string.IsNullOrWhiteSpace(stajYeriYetkilisiAdiSoyadi), e => e.StajYeriYetkilisiAdiSoyadi.Contains(stajYeriYetkilisiAdiSoyadi))
                    .WhereIf(!string.IsNullOrWhiteSpace(stajYeriYetkilisiGorevVeUnvani), e => e.StajYeriYetkilisiGorevVeUnvani.Contains(stajYeriYetkilisiGorevVeUnvani))
                    .WhereIf(!string.IsNullOrWhiteSpace(stajYeriYetkilisiEpostaAdresi), e => e.StajYeriYetkilisiEpostaAdresi.Contains(stajYeriYetkilisiEpostaAdresi))
                    .WhereIf(stajYeriYetkilisiOnayTarihiMin.HasValue, e => e.StajYeriYetkilisiOnayTarihi >= stajYeriYetkilisiOnayTarihiMin!.Value)
                    .WhereIf(stajYeriYetkilisiOnayTarihiMax.HasValue, e => e.StajYeriYetkilisiOnayTarihi <= stajYeriYetkilisiOnayTarihiMax!.Value)
                    .WhereIf(ogrenciStajBaslamaTarihiMin.HasValue, e => e.OgrenciStajBaslamaTarihi >= ogrenciStajBaslamaTarihiMin!.Value)
                    .WhereIf(ogrenciStajBaslamaTarihiMax.HasValue, e => e.OgrenciStajBaslamaTarihi <= ogrenciStajBaslamaTarihiMax!.Value)
                    .WhereIf(ogrenciStajBitisTarihiMin.HasValue, e => e.OgrenciStajBitisTarihi >= ogrenciStajBitisTarihiMin!.Value)
                    .WhereIf(ogrenciStajBitisTarihiMax.HasValue, e => e.OgrenciStajBitisTarihi <= ogrenciStajBitisTarihiMax!.Value)
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciAdi), e => e.OgrenciAdi.Contains(ogrenciAdi))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciSoyadi), e => e.OgrenciSoyadi.Contains(ogrenciSoyadi))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciTcKimlikNo), e => e.OgrenciTcKimlikNo.Contains(ogrenciTcKimlikNo))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciSskNo), e => e.OgrenciSskNo.Contains(ogrenciSskNo))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciBabaAdi), e => e.OgrenciBabaAdi.Contains(ogrenciBabaAdi))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciAnaAdi), e => e.OgrenciAnaAdi.Contains(ogrenciAnaAdi))
                    .WhereIf(!string.IsNullOrWhiteSpace(ogrenciDogumYeri), e => e.OgrenciDogumYeri.Contains(ogrenciDogumYeri))
                    .WhereIf(ogrenciDogumTarihiMin.HasValue, e => e.OgrenciDogumTarihi >= ogrenciDogumTarihiMin!.Value)
                    .WhereIf(ogrenciDogumTarihiMax.HasValue, e => e.OgrenciDogumTarihi <= ogrenciDogumTarihiMax!.Value)
                    .WhereIf(ogrenciSaglikGuvencesi.HasValue, e => e.OgrenciSaglikGuvencesi == ogrenciSaglikGuvencesi)
                    .WhereIf(bolumStajKomisyonuBaskanOnayiTarihiMin.HasValue, e => e.BolumStajKomisyonuBaskanOnayiTarihi >= bolumStajKomisyonuBaskanOnayiTarihiMin!.Value)
                    .WhereIf(bolumStajKomisyonuBaskanOnayiTarihiMax.HasValue, e => e.BolumStajKomisyonuBaskanOnayiTarihi <= bolumStajKomisyonuBaskanOnayiTarihiMax!.Value)
                    .WhereIf(dekanlikOnayTarihiMin.HasValue, e => e.DekanlikOnayTarihi >= dekanlikOnayTarihiMin!.Value)
                    .WhereIf(dekanlikOnayTarihiMax.HasValue, e => e.DekanlikOnayTarihi <= dekanlikOnayTarihiMax!.Value)
                    .WhereIf(sksDaireBaskanligiOnayTarihiMin.HasValue, e => e.SksDaireBaskanligiOnayTarihi >= sksDaireBaskanligiOnayTarihiMin!.Value)
                    .WhereIf(sksDaireBaskanligiOnayTarihiMax.HasValue, e => e.SksDaireBaskanligiOnayTarihi <= sksDaireBaskanligiOnayTarihiMax!.Value)
                    .WhereIf(basvuruDurumu.HasValue, e => e.BasvuruDurumu == basvuruDurumu)
                    .WhereIf(creatorId.HasValue, e => e.CreatorId == creatorId);
        }
    }
}