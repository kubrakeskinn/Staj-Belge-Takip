using Etu.StajSistemi.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Volo.Abp.Account;
using Volo.Abp.Account.Emailing;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;

namespace Etu.StajSistemi.Services;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(Volo.Abp.Account.AccountAppService), typeof(IAccountAppService))]
public class AccountAppService : Volo.Abp.Account.AccountAppService
{
    public AccountAppService(IdentityUserManager userManager, IIdentityRoleRepository roleRepository, IAccountEmailer accountEmailer, IdentitySecurityLogManager identitySecurityLogManager, IOptions<IdentityOptions> identityOptions) : base(userManager, roleRepository, accountEmailer, identitySecurityLogManager, identityOptions)
    {
    }

    public override async Task<IdentityUserDto> RegisterAsync(RegisterDto input)
    {
        var result = await base.RegisterAsync(input);

        var user = await UserManager.GetByIdAsync(result.Id);
        user.AddRole(Role.KurumYetkilisi.Id);
        (await UserManager.UpdateAsync(user)).CheckErrors();
        return result;
    }
}