using Etu.StajSistemi.Entities;
using Etu.StajSistemi.OgrenciStajBasvurusus;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Etu.StajSistemi.Pages.BolumBaskani
{
    public class IndexModel : AbpPageModel
    {
        public int? GunSayisiFilterMin { get; set; }

        public int? GunSayisiFilterMax { get; set; }
        public string? BolumBaskaniAdiSoyadiFilter { get; set; }
        public string? OgrenciAdiSoyadiFilter { get; set; }
        public string? OgrenciNoFilter { get; set; }
        public string? OgrenciBolumuFilter { get; set; }
        public string? OgrenciOgretimYiliFilter { get; set; }
        public string? OgrenciTelefonNoFilter { get; set; }
        public string? OgrenciEpostaFilter { get; set; }
        public string? OgrenciAdresiFilter { get; set; }
        public string? KurulusAdiFilter { get; set; }
        public string? KurulusTelefonNoFilter { get; set; }
        public string? KurulusAdresiFilter { get; set; }
        public string? StajYeriYetkilisiAdiSoyadiFilter { get; set; }
        public string? StajYeriYetkilisiGorevVeUnvaniFilter { get; set; }
        public string? StajYeriYetkilisiEpostaAdresiFilter { get; set; }
        public DateTime? StajYeriYetkilisiOnayTarihiFilterMin { get; set; }

        public DateTime? StajYeriYetkilisiOnayTarihiFilterMax { get; set; }
        public DateTime? OgrenciStajBaslamaTarihiFilterMin { get; set; }

        public DateTime? OgrenciStajBaslamaTarihiFilterMax { get; set; }
        public DateTime? OgrenciStajBitisTarihiFilterMin { get; set; }

        public DateTime? OgrenciStajBitisTarihiFilterMax { get; set; }
        public string? OgrenciAdiFilter { get; set; }
        public string? OgrenciSoyadiFilter { get; set; }
        public string? OgrenciTcKimlikNoFilter { get; set; }
        public string? OgrenciSskNoFilter { get; set; }
        public string? OgrenciBabaAdiFilter { get; set; }
        public string? OgrenciAnaAdiFilter { get; set; }
        public string? OgrenciDogumYeriFilter { get; set; }
        public DateTime? OgrenciDogumTarihiFilterMin { get; set; }

        public DateTime? OgrenciDogumTarihiFilterMax { get; set; }
        public OgrenciSaglikGuvencesi? OgrenciSaglikGuvencesiFilter { get; set; }
        public DateTime? BolumStajKomisyonuBaskanOnayiTarihiFilterMin { get; set; }

        public DateTime? BolumStajKomisyonuBaskanOnayiTarihiFilterMax { get; set; }
        public DateTime? DekanlikOnayTarihiFilterMin { get; set; }

        public DateTime? DekanlikOnayTarihiFilterMax { get; set; }
        public DateTime? SksDaireBaskanligiOnayTarihiFilterMin { get; set; }

        public DateTime? SksDaireBaskanligiOnayTarihiFilterMax { get; set; }

        protected IOgrenciStajBasvurususAppService _ogrenciStajBasvurususAppService;

        public IndexModel(IOgrenciStajBasvurususAppService ogrenciStajBasvurususAppService)
        {
            _ogrenciStajBasvurususAppService = ogrenciStajBasvurususAppService;
        }

        public virtual async Task OnGetAsync()
        {

            await Task.CompletedTask;
        }
    }
}