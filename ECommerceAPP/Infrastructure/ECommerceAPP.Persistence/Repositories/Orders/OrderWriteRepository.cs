using ECommerceAPP.Application.IRepositories.Orders;
using ECommerceAPP.Domain.Entities;
using ECommerceAPP.Persistence.Contexts;

namespace ECommerceAPP.Persistence.Repositories.Orders;

public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
{
    public OrderWriteRepository(ECommerceAPPDbContext dbContext) : base(dbContext)
    {
    }
}