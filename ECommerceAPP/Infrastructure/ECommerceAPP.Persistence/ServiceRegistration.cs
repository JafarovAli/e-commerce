using ECommerceAPP.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceAPP.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<ECommerceAPPDbContext>(options=>options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    }
}
