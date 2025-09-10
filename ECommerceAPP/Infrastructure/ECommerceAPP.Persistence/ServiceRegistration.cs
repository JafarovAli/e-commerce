using ECommerceAPP.Application.IRepositories.Customers;
using ECommerceAPP.Application.IRepositories.Orders;
using ECommerceAPP.Application.IRepositories.Products;
using ECommerceAPP.Persistence.Contexts;
using ECommerceAPP.Persistence.Repositories.Customers;
using ECommerceAPP.Persistence.Repositories.Orders;
using ECommerceAPP.Persistence.Repositories.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceAPP.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<ECommerceAPPDbContext>(options=>options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<ICustomerReadRepository,CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository,CustomerWriteRepository>();
        services.AddScoped<IOrderReadRepository,OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository,OrderWriteRepository>();
        services.AddScoped<IProductReadRepository,ProductReadRepository>();
        services.AddScoped<IProductWriteRepository,ProductWriteRepository>();
    }
}