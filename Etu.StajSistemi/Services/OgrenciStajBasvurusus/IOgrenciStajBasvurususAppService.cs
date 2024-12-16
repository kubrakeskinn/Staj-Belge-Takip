using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Content;

namespace Etu.StajSistemi.OgrenciStajBasvurusus
{
    public interface IOgrenciStajBasvurususAppService : IApplicationService
    {

        Task<PagedResultDto<OgrenciStajBasvurusuDto>> GetListAsync(GetOgrenciStajBasvurususInput input);
        Task<PagedResultDto<OgrenciStajBasvurusuDto>> GetListStajKomisyonOnayiBekleyenlerAsync(GetOgrenciStajBasvurususInput input);
        Task<PagedResultDto<OgrenciStajBasvurusuDto>> GetListBolumBaskaniOnayBekleyenlerAsync(GetOgrenciStajBasvurususInput input);
        Task<PagedResultDto<OgrenciStajBasvurusuDto>> GetListDekanlikOnayBekleyenlerAsync(GetOgrenciStajBasvurususInput input);
        Task<PagedResultDto<OgrenciStajBasvurusuDto>> GetListSksOnayBekleyenlerAsync(GetOgrenciStajBasvurususInput input);

        Task<OgrenciStajBasvurusuDto> GetAsync(Guid id);

        Task DeleteAsync(Guid id);

        Task<OgrenciStajBasvurusuDto> CreateAsync(OgrenciStajBasvurusuCreateDto input);
        
        Task KurumOnaylaAsync(Guid id, KurumOnayDto dto);
        Task BolumStajKomisyonuBaskanOnaylaAsync(Guid id, IRemoteStreamContent dto);
        Task BolumBaskaniOnaylaAsync(Guid id, IRemoteStreamContent dto);
        Task DekanlikOnaylaAsync(Guid id, IRemoteStreamContent dto);
        Task SksDaireBaskanligiOnaylaAsync(Guid id, IRemoteStreamContent dto);
        
        Task<IRemoteStreamContent> GetBolumBaskaniOnayiAsync(Guid id);
        Task<IRemoteStreamContent> GetDekanlikOnayiAsync(Guid id);
        Task<IRemoteStreamContent> GetSksDaireBaskanligiOnayiAsync(Guid id);
        Task<IRemoteStreamContent> GetOgrenciImzaAsync(Guid id);
        Task<IRemoteStreamContent> GetOgrenciVesikalikAsync(Guid id);
        Task<IRemoteStreamContent> GetStajYeriYetkilisiImzaAsync(Guid id);
        Task<IRemoteStreamContent> GetBolumStajKomisyonuBaskanOnayiAsync(Guid id);
    }

    public class KurumOnayDto
    {
        public string YetkiliAdiSoyadi { get; set; }
        public string YetkiliGorevVeUnvani { get; set; }
        public string YetkiliEpostaAdresi { get; set; }
        public IRemoteStreamContent Imza { get; set; }
    }
}