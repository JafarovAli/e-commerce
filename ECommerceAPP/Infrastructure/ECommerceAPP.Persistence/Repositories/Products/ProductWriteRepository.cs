using ECommerceAPP.Application.IRepositories.Products;
using ECommerceAPP.Domain.Entities;
using ECommerceAPP.Persistence.Contexts;

namespace ECommerceAPP.Persistence.Repositories.Products;

public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
{
    public ProductWriteRepository(ECommerceAPPDbContext dbContext) : base(dbContext)
    {
    }
}