using Etu.StajSistemi.Localization;
using Volo.Abp.Application.Services;

namespace Etu.StajSistemi.Services;

/* Inherit your application services from this class. */
public abstract class StajSistemiAppService : ApplicationService
{
    protected StajSistemiAppService()
    {
        LocalizationResource = typeof(StajSistemiResource);
    }
}