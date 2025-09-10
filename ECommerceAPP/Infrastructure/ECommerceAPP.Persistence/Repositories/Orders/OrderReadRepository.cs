using ECommerceAPP.Application.IRepositories.Orders;
using ECommerceAPP.Domain.Entities;
using ECommerceAPP.Persistence.Contexts;

namespace ECommerceAPP.Persistence.Repositories.Orders;

public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
{
    public OrderReadRepository(ECommerceAPPDbContext dbContext) : base(dbContext)
    {
    }
}