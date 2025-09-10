using ECommerceAPP.Application.IRepositories.Products;
using ECommerceAPP.Domain.Entities;
using ECommerceAPP.Persistence.Contexts;

namespace ECommerceAPP.Persistence.Repositories.Products;

public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(ECommerceAPPDbContext dbContext) : base(dbContext)
    {
    }
}