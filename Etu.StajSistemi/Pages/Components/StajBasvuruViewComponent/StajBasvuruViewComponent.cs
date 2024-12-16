using Etu.StajSistemi.OgrenciStajBasvurusus;
using Etu.StajSistemi.Pages.Kurum;
using Etu.StajSistemi.Pages.OgrenciStajBasvurusus;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Etu.StajSistemi.Pages.Components.StajBasvuruViewComponent;

public class StajBasvuruViewComponent : AbpViewComponent
{
    private readonly IOgrenciStajBasvurususAppService _ogrenciStajBasvurususAppService;

    public StajBasvuruViewComponent(IOgrenciStajBasvurususAppService ogrenciStajBasvurususAppService)
    {
        _ogrenciStajBasvurususAppService = ogrenciStajBasvurususAppService;
    }
    
    public async Task<IViewComponentResult> InvokeAsync(Guid id, Reference reference)
    {
        var model = new StajBasvuruViewComponentModel
        {
            Id = id,
            Reference = reference,
            OgrenciStajBasvurusu = reference == Reference.Create ? new OgrenciStajBasvurusuDto() : await _ogrenciStajBasvurususAppService.GetAsync(id),
            Input = new Create.CreateOgrenciStajBasvurusuModel(),
        };
        
        return View("~/Pages/Components/StajBasvuruViewComponent/Default.cshtml", model);
    }
}

public class StajBasvuruViewComponentModel
{
    public Guid Id { get; set; }
    public Reference Reference { get; set; }
    public IFormFile Imza { get; set; }
    public Create.CreateOgrenciStajBasvurusuModel Input { get; set; }
    public Onayla.KurumOnayViewModel Onay { get; set; }
    public OgrenciStajBasvurusuDto OgrenciStajBasvurusu { get; set; }
}

public enum Reference
{
    Create,
    ViewOnly,
    KurumOnay,
    StajKomisyonuOnay,
    BolumBaskaniOnay,
    DekanlikOnay,
    SksDaireBaskanligiOnay
}