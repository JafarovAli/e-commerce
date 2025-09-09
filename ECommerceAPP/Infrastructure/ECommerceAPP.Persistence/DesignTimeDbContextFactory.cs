using ECommerceAPP.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ECommerceAPP.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceAPPDbContext>
{
    public ECommerceAPPDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ECommerceAPPDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ECommerceAPP;Username=postgres;Password=1234");
        return new(dbContextOptionsBuilder.Options);
    }
}
