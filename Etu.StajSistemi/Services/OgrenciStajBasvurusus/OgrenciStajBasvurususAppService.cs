using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Etu.StajSistemi.Permissions;
using Etu.StajSistemi.OgrenciStajBasvurusus;
using Volo.Abp.BlobStoring;
using Volo.Abp.Content;
using Volo.Abp.Users;

namespace Etu.StajSistemi.OgrenciStajBasvurusus
{
    [Authorize]
    public class OgrenciStajBasvurususAppService : ApplicationService, IOgrenciStajBasvurususAppService
    {
        protected IOgrenciStajBasvurusuRepository _ogrenciStajBasvurusuRepository;
        protected OgrenciStajBasvurusuManager _ogrenciStajBasvurusuManager;
        protected IBlobContainer<StajBasvuruOgrenciVesikalikContainer> OgrenciVesikalikContainer;
        protected IBlobContainer<StajBasvuruOgrenciImzaContainer> OgrenciImzaContainer;
        protected IBlobContainer<StajBasvuruOgrenciBolumBaskaniOnayImzaContainer> BolumBaskaniOnayImzaContainer;
        protected IBlobContainer<StajBasvuruOgrenciDekanlikOnayImzaContainer> DekanlikOnayImzaContainer;
        protected IBlobContainer<StajBasvuruOgrenciSksDaireBaskanligiOnayImzaContainer> SksDaireBaskanligiOnayImzaContainer;
        protected IBlobContainer<StajBasvuruOgrenciStajYeriYetkilisiOnayImzaContainer> StajYeriYetkilisiOnayImzaContainer;
        protected IBlobContainer<StajBasvuruOgrenciBolumStajKomisyonuBaskanOnayImzaContainer> BolumStajKomisyonuBaskanOnayImzaContainer;

        public OgrenciStajBasvurususAppService(IOgrenciStajBasvurusuRepository ogrenciStajBasvurusuRepository,
            OgrenciStajBasvurusuManager ogrenciStajBasvurusuManager, IBlobContainer<StajBasvuruOgrenciVesikalikContainer> ogrenciVesikalikContainer, IBlobContainer<StajBasvuruOgrenciImzaContainer> ogrenciImzaContainer, IBlobContainer<StajBasvuruOgrenciBolumBaskaniOnayImzaContainer> bolumBaskaniOnayImzaContainer, IBlobContainer<StajBasvuruOgrenciDekanlikOnayImzaContainer> dekanlikOnayImzaContainer, IBlobContainer<StajBasvuruOgrenciSksDaireBaskanligiOnayImzaContainer> sksDaireBaskanligiOnayImzaContainer, IBlobContainer<StajBasvuruOgrenciStajYeriYetkilisiOnayImzaContainer> stajYeriYetkilisiOnayImzaContainer, IBlobContainer<StajBasvuruOgrenciBolumStajKomisyonuBaskanOnayImzaContainer> bolumStajKomisyonuBaskanOnayImzaContainer)
        {
            _ogrenciStajBasvurusuRepository = ogrenciStajBasvurusuRepository;
            _ogrenciStajBasvurusuManager = ogrenciStajBasvurusuManager;
            OgrenciVesikalikContainer = ogrenciVesikalikContainer;
            OgrenciImzaContainer = ogrenciImzaContainer;
            BolumBaskaniOnayImzaContainer = bolumBaskaniOnayImzaContainer;
            DekanlikOnayImzaContainer = dekanlikOnayImzaContainer;
            SksDaireBaskanligiOnayImzaContainer = sksDaireBaskanligiOnayImzaContainer;
            StajYeriYetkilisiOnayImzaContainer = stajYeriYetkilisiOnayImzaContainer;
            BolumStajKomisyonuBaskanOnayImzaContainer = bolumStajKomisyonuBaskanOnayImzaContainer;
        }
        
         private async Task<PagedResultDto<OgrenciStajBasvurusuDto>> GetListAsync(
            GetOgrenciStajBasvurususInput input, BasvuruDurumu? basvuruDurumu, Guid? creatorId = null)
        {
            var totalCount = await _ogrenciStajBasvurusuRepository.GetCountAsync(input.FilterText, input.GunSayisiMin,
                input.GunSayisiMax, input.BolumBaskaniAdiSoyadi, input.OgrenciAdiSoyadi, input.OgrenciNo,
                input.OgrenciBolumu, input.OgrenciOgretimYili, input.OgrenciTelefonNo, input.OgrenciEposta,
                input.OgrenciAdresi, input.KurulusAdi, input.KurulusTelefonNo, input.KurulusAdresi,
                input.StajYeriYetkilisiAdiSoyadi, input.StajYeriYetkilisiGorevVeUnvani,
                input.StajYeriYetkilisiEpostaAdresi, input.StajYeriYetkilisiOnayTarihiMin,
                input.StajYeriYetkilisiOnayTarihiMax, input.OgrenciStajBaslamaTarihiMin,
                input.OgrenciStajBaslamaTarihiMax, input.OgrenciStajBitisTarihiMin, input.OgrenciStajBitisTarihiMax,
                input.OgrenciAdi, input.OgrenciSoyadi, input.OgrenciTcKimlikNo, input.OgrenciSskNo,
                input.OgrenciBabaAdi, input.OgrenciAnaAdi, input.OgrenciDogumYeri, input.OgrenciDogumTarihiMin,
                input.OgrenciDogumTarihiMax, input.OgrenciSaglikGuvencesi, input.BolumStajKomisyonuBaskanOnayiTarihiMin,
                input.BolumStajKomisyonuBaskanOnayiTarihiMax, input.DekanlikOnayTarihiMin, input.DekanlikOnayTarihiMax,
                input.SksDaireBaskanligiOnayTarihiMin, input.SksDaireBaskanligiOnayTarihiMax, basvuruDurumu, creatorId);
            var items = await _ogrenciStajBasvurusuRepository.GetListAsync(input.FilterText, input.GunSayisiMin,
                input.GunSayisiMax, input.BolumBaskaniAdiSoyadi, input.OgrenciAdiSoyadi, input.OgrenciNo,
                input.OgrenciBolumu, input.OgrenciOgretimYili, input.OgrenciTelefonNo, input.OgrenciEposta,
                input.OgrenciAdresi, input.KurulusAdi, input.KurulusTelefonNo, input.KurulusAdresi,
                input.StajYeriYetkilisiAdiSoyadi, input.StajYeriYetkilisiGorevVeUnvani,
                input.StajYeriYetkilisiEpostaAdresi, input.StajYeriYetkilisiOnayTarihiMin,
                input.StajYeriYetkilisiOnayTarihiMax, input.OgrenciStajBaslamaTarihiMin,
                input.OgrenciStajBaslamaTarihiMax, input.OgrenciStajBitisTarihiMin, input.OgrenciStajBitisTarihiMax,
                input.OgrenciAdi, input.OgrenciSoyadi, input.OgrenciTcKimlikNo, input.OgrenciSskNo,
                input.OgrenciBabaAdi, input.OgrenciAnaAdi, input.OgrenciDogumYeri, input.OgrenciDogumTarihiMin,
                input.OgrenciDogumTarihiMax, input.OgrenciSaglikGuvencesi, input.BolumStajKomisyonuBaskanOnayiTarihiMin,
                input.BolumStajKomisyonuBaskanOnayiTarihiMax, input.DekanlikOnayTarihiMin, input.DekanlikOnayTarihiMax,
                input.SksDaireBaskanligiOnayTarihiMin, input.SksDaireBaskanligiOnayTarihiMax, input.Sorting,
                input.MaxResultCount, input.SkipCount, basvuruDurumu, creatorId);

            return new PagedResultDto<OgrenciStajBasvurusuDto>
            {
                TotalCount = totalCount,
                Items = ObjectMapper.Map<List<OgrenciStajBasvurusu>, List<OgrenciStajBasvurusuDto>>(items)
            };
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.Default)]
        public virtual async Task<PagedResultDto<OgrenciStajBasvurusuDto>> GetListAsync(
            GetOgrenciStajBasvurususInput input)
        {
            return await GetListAsync(input, null, CurrentUser.GetId());
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.StajKomisyonuOnayla)]
        public Task<PagedResultDto<OgrenciStajBasvurusuDto>> GetListStajKomisyonOnayiBekleyenlerAsync(GetOgrenciStajBasvurususInput input)
        {
            return GetListAsync(input, BasvuruDurumu.StajKomisyonuBaskanOnayiBekleniyor);
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.BolumBaskaniOnayla)]
        public async Task<PagedResultDto<OgrenciStajBasvurusuDto>> GetListBolumBaskaniOnayBekleyenlerAsync(GetOgrenciStajBasvurususInput input)
        {
            return await GetListAsync(input, BasvuruDurumu.BolumBaskaniOnayiBekleniyor);
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.DekanlikOnayla)]
        public Task<PagedResultDto<OgrenciStajBasvurusuDto>> GetListDekanlikOnayBekleyenlerAsync(GetOgrenciStajBasvurususInput input)
        {
            return GetListAsync(input, BasvuruDurumu.DekanlikOnayiBekleniyor);
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.SksDaireBaskanligiOnayla)]
        public Task<PagedResultDto<OgrenciStajBasvurusuDto>> GetListSksOnayBekleyenlerAsync(GetOgrenciStajBasvurususInput input)
        {
            return GetListAsync(input, BasvuruDurumu.SksDaireBaskanligiOnayiBekleniyor);
        }
        
        
        public virtual async Task<OgrenciStajBasvurusuDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<OgrenciStajBasvurusu, OgrenciStajBasvurusuDto>(
                await _ogrenciStajBasvurusuRepository.GetAsync(id));
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.Delete)]
        public virtual async Task DeleteAsync(Guid id)
        {
            await _ogrenciStajBasvurusuRepository.DeleteAsync(id);
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.Create)]
        public virtual async Task<OgrenciStajBasvurusuDto> CreateAsync(OgrenciStajBasvurusuCreateDto input)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuManager.CreateAsync(
                input.GunSayisi, input.BolumBaskaniAdiSoyadi, input.OgrenciAdiSoyadi, input.OgrenciNo,
                input.OgrenciBolumu, input.OgrenciOgretimYili, input.OgrenciTelefonNo, input.OgrenciEposta,
                input.OgrenciAdresi, input.KurulusAdi, input.KurulusTelefonNo, input.KurulusAdresi,
                input.OgrenciStajBaslamaTarihi, input.OgrenciStajBitisTarihi, input.OgrenciAdi, input.OgrenciSoyadi,
                input.OgrenciTcKimlikNo, input.OgrenciBabaAdi, input.OgrenciAnaAdi, input.OgrenciDogumYeri,
                input.OgrenciDogumTarihi, input.OgrenciSaglikGuvencesi, ogrenciSskNo: input.OgrenciSskNo
            );
            
            await using var vesikalikStream = input.OgrenciVesikalikFile.GetStream();
            var blobName = $"{ogrenciStajBasvurusu.Id}{Path.GetExtension(input.OgrenciVesikalikFile.FileName)}";
            await OgrenciVesikalikContainer.SaveAsync(blobName, vesikalikStream, true);
            
            ogrenciStajBasvurusu.OgrenciVesikalikFileName = blobName;
            ogrenciStajBasvurusu.OgrenciVesikalikFileContentType = input.OgrenciVesikalikFile.ContentType;
            
            await using var imzaStream = input.OgrenciImzasi.GetStream();
            blobName = $"{ogrenciStajBasvurusu.Id}{Path.GetExtension(input.OgrenciImzasi.FileName)}";
            await OgrenciImzaContainer.SaveAsync(blobName, imzaStream, true);
            
            ogrenciStajBasvurusu.OgrenciImzaFileName = blobName;
            ogrenciStajBasvurusu.OgrenciImzaFileContentType = input.OgrenciImzasi.ContentType;
            
            await _ogrenciStajBasvurusuRepository.UpdateAsync(ogrenciStajBasvurusu);

            return ObjectMapper.Map<OgrenciStajBasvurusu, OgrenciStajBasvurusuDto>(ogrenciStajBasvurusu);
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.KurumOnayla)]
        public async Task KurumOnaylaAsync(Guid id, KurumOnayDto dto)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            await using var stream = dto.Imza.GetStream();
            var blobName = $"{ogrenciStajBasvurusu.Id}.{Path.GetExtension(dto.Imza.FileName)}";
            await StajYeriYetkilisiOnayImzaContainer.SaveAsync(blobName, stream, true);
            
            ogrenciStajBasvurusu.StajYeriYetkilisiImzaFileName = blobName;
            ogrenciStajBasvurusu.StajYeriYetkilisiImzaContentType = dto.Imza.ContentType;
            ogrenciStajBasvurusu.StajYeriYetkilisiOnayTarihi = DateTime.Now;
            ogrenciStajBasvurusu.BasvuruDurumu = BasvuruDurumu.StajKomisyonuBaskanOnayiBekleniyor;
            ogrenciStajBasvurusu.StajYeriYetkilisiAdiSoyadi = dto.YetkiliAdiSoyadi;
            ogrenciStajBasvurusu.StajYeriYetkilisiGorevVeUnvani = dto.YetkiliGorevVeUnvani;
            ogrenciStajBasvurusu.StajYeriYetkilisiEpostaAdresi = dto.YetkiliEpostaAdresi;
            
            await _ogrenciStajBasvurusuRepository.UpdateAsync(ogrenciStajBasvurusu);
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.StajKomisyonuOnayla)]
        public async Task BolumStajKomisyonuBaskanOnaylaAsync(Guid id, IRemoteStreamContent dto)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            await using var stream = dto.GetStream();
            var blobName = $"{ogrenciStajBasvurusu.Id}.{Path.GetExtension(dto.FileName)}";
            await BolumStajKomisyonuBaskanOnayImzaContainer.SaveAsync(blobName, stream, true);
            
            ogrenciStajBasvurusu.BolumStajKomisyonuBaskanOnayiImzaFileName = blobName;
            ogrenciStajBasvurusu.BolumStajKomisyonuBaskanOnayiImzaContentType = dto.ContentType;
            ogrenciStajBasvurusu.BolumStajKomisyonuBaskanOnayiTarihi = DateTime.Now;
            ogrenciStajBasvurusu.BasvuruDurumu = BasvuruDurumu.BolumBaskaniOnayiBekleniyor;
            
            await _ogrenciStajBasvurusuRepository.UpdateAsync(ogrenciStajBasvurusu);
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.BolumBaskaniOnayla)]
        public async Task BolumBaskaniOnaylaAsync(Guid id, IRemoteStreamContent dto)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            await using var stream = dto.GetStream();
            var blobName = $"{ogrenciStajBasvurusu.Id}.{Path.GetExtension(dto.FileName)}";
            await BolumBaskaniOnayImzaContainer.SaveAsync(blobName, stream, true);
            
            ogrenciStajBasvurusu.BolumBaskaniImzasi = blobName;
            ogrenciStajBasvurusu.BolumBaskaniImzasiContentType = dto.ContentType;
            ogrenciStajBasvurusu.BolumBaskaniOnayTarihi = DateTime.Now;
            ogrenciStajBasvurusu.BasvuruDurumu = BasvuruDurumu.DekanlikOnayiBekleniyor;
            
            await _ogrenciStajBasvurusuRepository.UpdateAsync(ogrenciStajBasvurusu);
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.DekanlikOnayla)]
        public async Task DekanlikOnaylaAsync(Guid id, IRemoteStreamContent dto)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            await using var stream = dto.GetStream();
            var blobName = $"{ogrenciStajBasvurusu.Id}.{Path.GetExtension(dto.FileName)}";
            await DekanlikOnayImzaContainer.SaveAsync(blobName, stream, true);
            
            ogrenciStajBasvurusu.DekanlikOnayImzaFileName = blobName;
            ogrenciStajBasvurusu.DekanlikOnayImzaFileContentType = dto.ContentType;
            ogrenciStajBasvurusu.DekanlikOnayTarihi = DateTime.Now;
            ogrenciStajBasvurusu.BasvuruDurumu = BasvuruDurumu.SksDaireBaskanligiOnayiBekleniyor;
            
            await _ogrenciStajBasvurusuRepository.UpdateAsync(ogrenciStajBasvurusu);
        }

        [Authorize(StajSistemiPermissions.OgrenciStajBasvurusus.SksDaireBaskanligiOnayla)]
        public async Task SksDaireBaskanligiOnaylaAsync(Guid id, IRemoteStreamContent dto)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            await using var stream = dto.GetStream();
            var blobName = $"{ogrenciStajBasvurusu.Id}.{Path.GetExtension(dto.FileName)}";
            await SksDaireBaskanligiOnayImzaContainer.SaveAsync(blobName, stream, true);
            
            ogrenciStajBasvurusu.SksDaireBaskanligiOnayImzaFileName = blobName;
            ogrenciStajBasvurusu.SksDaireBaskanligiOnayImzaFileContentType = dto.ContentType;
            ogrenciStajBasvurusu.SksDaireBaskanligiOnayTarihi = DateTime.Now;
            ogrenciStajBasvurusu.BasvuruDurumu = BasvuruDurumu.Tamamlandi;
            
            await _ogrenciStajBasvurusuRepository.UpdateAsync(ogrenciStajBasvurusu);
        }

        public async Task<IRemoteStreamContent> GetBolumBaskaniOnayiAsync(Guid id)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            if (ogrenciStajBasvurusu.BolumBaskaniImzasi == null)
            {
                throw new UserFriendlyException("Bölüm başkanı onayı henüz yüklenmemiş.");
            }
            var stream = await BolumBaskaniOnayImzaContainer.GetAsync(ogrenciStajBasvurusu.BolumBaskaniImzasi);
            return new RemoteStreamContent(stream, ogrenciStajBasvurusu.BolumBaskaniImzasi, ogrenciStajBasvurusu.BolumBaskaniImzasiContentType);
        }

        public async Task<IRemoteStreamContent> GetDekanlikOnayiAsync(Guid id)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            if (ogrenciStajBasvurusu.DekanlikOnayImzaFileName == null)
            {
                throw new UserFriendlyException("Dekanlık onayı henüz yüklenmemiş.");
            }
            var stream = await DekanlikOnayImzaContainer.GetAsync(ogrenciStajBasvurusu.DekanlikOnayImzaFileName);
            return new RemoteStreamContent(stream, ogrenciStajBasvurusu.DekanlikOnayImzaFileName, ogrenciStajBasvurusu.DekanlikOnayImzaFileContentType);
        }

        public async Task<IRemoteStreamContent> GetSksDaireBaskanligiOnayiAsync(Guid id)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            if (ogrenciStajBasvurusu.SksDaireBaskanligiOnayImzaFileName == null)
            {
                throw new UserFriendlyException("SKS Daire Başkanlığı onayı henüz yüklenmemiş.");
            }
            var stream = await SksDaireBaskanligiOnayImzaContainer.GetAsync(ogrenciStajBasvurusu.SksDaireBaskanligiOnayImzaFileName);
            return new RemoteStreamContent(stream, ogrenciStajBasvurusu.SksDaireBaskanligiOnayImzaFileName, ogrenciStajBasvurusu.SksDaireBaskanligiOnayImzaFileContentType);
        }

        public async Task<IRemoteStreamContent> GetOgrenciImzaAsync(Guid id)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            var stream = await OgrenciImzaContainer.GetAsync(ogrenciStajBasvurusu.OgrenciImzaFileName);
            return new RemoteStreamContent(stream, ogrenciStajBasvurusu.OgrenciImzaFileName, ogrenciStajBasvurusu.OgrenciImzaFileContentType);
        }

        public async Task<IRemoteStreamContent> GetOgrenciVesikalikAsync(Guid id)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            var stream = await OgrenciVesikalikContainer.GetAsync(ogrenciStajBasvurusu.OgrenciVesikalikFileName);
            return new RemoteStreamContent(stream, ogrenciStajBasvurusu.OgrenciVesikalikFileName, ogrenciStajBasvurusu.OgrenciVesikalikFileContentType);
        }

        public async Task<IRemoteStreamContent> GetStajYeriYetkilisiImzaAsync(Guid id)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            if (ogrenciStajBasvurusu.StajYeriYetkilisiImzaFileName == null)
            {
                throw new UserFriendlyException("Staj yeri yetkilisi onayı henüz yüklenmemiş.");
            }
            var stream = await StajYeriYetkilisiOnayImzaContainer.GetAsync(ogrenciStajBasvurusu.StajYeriYetkilisiImzaFileName);
            return new RemoteStreamContent(stream, ogrenciStajBasvurusu.StajYeriYetkilisiImzaFileName, ogrenciStajBasvurusu.StajYeriYetkilisiImzaContentType);
        }

        public async Task<IRemoteStreamContent> GetBolumStajKomisyonuBaskanOnayiAsync(Guid id)
        {
            var ogrenciStajBasvurusu = await _ogrenciStajBasvurusuRepository.GetAsync(id);
            if (ogrenciStajBasvurusu.BolumStajKomisyonuBaskanOnayiImzaFileName == null)
            {
                throw new UserFriendlyException("Bölüm staj komisyonu başkanı onayı henüz yüklenmemiş.");
            }
            var stream = await BolumStajKomisyonuBaskanOnayImzaContainer.GetAsync(ogrenciStajBasvurusu.BolumStajKomisyonuBaskanOnayiImzaFileName);
            return new RemoteStreamContent(stream, ogrenciStajBasvurusu.BolumStajKomisyonuBaskanOnayiImzaFileName, ogrenciStajBasvurusu.BolumStajKomisyonuBaskanOnayiImzaContentType);
        }
    }

    [BlobContainerName(nameof(StajBasvuruOgrenciVesikalikContainer))]
    public class StajBasvuruOgrenciVesikalikContainer
    {
        
    }
    
    [BlobContainerName(nameof(StajBasvuruOgrenciImzaContainer))]
    public class StajBasvuruOgrenciImzaContainer
    {
        
    }
    
    [BlobContainerName(nameof(StajBasvuruOgrenciBolumBaskaniOnayImzaContainer))]
    public class StajBasvuruOgrenciBolumBaskaniOnayImzaContainer
    {
        
    }
    
    [BlobContainerName(nameof(StajBasvuruOgrenciDekanlikOnayImzaContainer))]
    public class StajBasvuruOgrenciDekanlikOnayImzaContainer
    {
        
    }
    
    [BlobContainerName(nameof(StajBasvuruOgrenciSksDaireBaskanligiOnayImzaContainer))]
    public class StajBasvuruOgrenciSksDaireBaskanligiOnayImzaContainer
    {
        
    }
    
    [BlobContainerName(nameof(StajBasvuruOgrenciStajYeriYetkilisiOnayImzaContainer))]
    public class StajBasvuruOgrenciStajYeriYetkilisiOnayImzaContainer
    {
        
    }
    
    [BlobContainerName(nameof(StajBasvuruOgrenciBolumStajKomisyonuBaskanOnayImzaContainer))]
    public class StajBasvuruOgrenciBolumStajKomisyonuBaskanOnayImzaContainer
    {
        
    }
}