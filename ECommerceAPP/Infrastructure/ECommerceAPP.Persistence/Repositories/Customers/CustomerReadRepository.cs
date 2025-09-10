using ECommerceAPP.Application.IRepositories.Customers;
using ECommerceAPP.Domain.Entities;
using ECommerceAPP.Persistence.Contexts;

namespace ECommerceAPP.Persistence.Repositories.Customers;

public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(ECommerceAPPDbContext dbContext) : base(dbContext)
    {
    }
}