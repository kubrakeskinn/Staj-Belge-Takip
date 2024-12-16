using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Etu.StajSistemi.Data;

public class StajSistemiDbContextFactory : IDesignTimeDbContextFactory<StajSistemiDbContext>
{
    public StajSistemiDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<StajSistemiDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new StajSistemiDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
