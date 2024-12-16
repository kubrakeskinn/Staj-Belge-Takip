using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Etu.StajSistemi.Pages;

public class IndexModel : AbpPageModel
{
    public IActionResult OnGet()
    {
        if (CurrentUser.IsAuthenticated)
        {
            return Page();
        }
        
        return RedirectToPage("/Account/Login", new { returnUrl = Request.Path });
    }
}