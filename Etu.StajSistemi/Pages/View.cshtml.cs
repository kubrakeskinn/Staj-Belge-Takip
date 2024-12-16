using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Etu.StajSistemi.Pages;

public class View : PageModel
{
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    public void OnGet()
    {
        
    }
}