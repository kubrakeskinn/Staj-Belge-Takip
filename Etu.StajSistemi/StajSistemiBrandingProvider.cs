using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Etu.StajSistemi;

[Dependency(ReplaceServices = true)]
public class StajSistemiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ETU Staj Sistemi";
    public override string? LogoUrl => "/Account/etuAmblem.jpg";
}
