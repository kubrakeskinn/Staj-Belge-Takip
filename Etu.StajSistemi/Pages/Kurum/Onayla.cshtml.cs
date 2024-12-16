using Etu.StajSistemi.OgrenciStajBasvurusus;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Etu.StajSistemi.Pages.Kurum;

public class Onayla : AbpPageModel
{
    private readonly IOgrenciStajBasvurususAppService _ogrenciStajBasvurususAppService;
    
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    public OgrenciStajBasvurusuDto OgrenciStajBasvurusu { get; set; }
    
    [BindProperty]
    public KurumOnayViewModel Onay { get; set; }

    public Onayla(IOgrenciStajBasvurususAppService ogrenciStajBasvurususAppService)
    {
        _ogrenciStajBasvurususAppService = ogrenciStajBasvurususAppService;
    }
    
    public async Task OnGetAsync()
    {
        OgrenciStajBasvurusu = await _ogrenciStajBasvurususAppService.GetAsync(Id);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _ogrenciStajBasvurususAppService.KurumOnaylaAsync(Id, ObjectMapper.Map<KurumOnayViewModel, KurumOnayDto>(Onay));
        return Redirect("/view/" + Id);
    }
    
    public class KurumOnayViewModel
    {
        public string YetkiliAdiSoyadi { get; set; }
        public string YetkiliGorevVeUnvani { get; set; }
        public string YetkiliEpostaAdresi { get; set; }
        public IFormFile Imza { get; set; }
    }
}