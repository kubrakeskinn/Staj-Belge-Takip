using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace Etu.StajSistemi.Data;

public class StajSistemiEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public StajSistemiEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the StajSistemiDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StajSistemiDbContext>()
            .Database
            .MigrateAsync();
    }
}
