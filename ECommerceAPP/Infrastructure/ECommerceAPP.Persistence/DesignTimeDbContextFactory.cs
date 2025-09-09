using ECommerceAPP.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ECommerceAPP.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceAPPDbContext>
{
    public ECommerceAPPDbContext CreateDbContext(string[] args)
    {
        ConfigurationManager configurationManager = new();
        configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceAPP.API"));
        configurationManager.AddJsonFile("appsettings.json");

        DbContextOptionsBuilder<ECommerceAPPDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseNpgsql(configurationManager.GetConnectionString("DefaultConnection"));
        return new(dbContextOptionsBuilder.Options);
    }
}