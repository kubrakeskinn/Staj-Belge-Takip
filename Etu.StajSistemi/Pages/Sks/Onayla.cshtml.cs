using Etu.StajSistemi.OgrenciStajBasvurusus;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.Content;

namespace Etu.StajSistemi.Pages.Sks;

public class Onayla : AbpPageModel
{
    private readonly IOgrenciStajBasvurususAppService _ogrenciStajBasvurususAppService;
    
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    public OgrenciStajBasvurusuDto OgrenciStajBasvurusu { get; set; }
    
    [BindProperty]
    public IFormFile Imza { get; set; }

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
        var dto = ObjectMapper.Map<IFormFile, IRemoteStreamContent>(Imza);
        await _ogrenciStajBasvurususAppService.SksDaireBaskanligiOnaylaAsync(Id, dto);
        return Redirect("/view/" + Id);
    }
}