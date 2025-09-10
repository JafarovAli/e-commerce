using ECommerceAPP.Application.IRepositories.Customers;
using ECommerceAPP.Domain.Entities;
using ECommerceAPP.Persistence.Contexts;

namespace ECommerceAPP.Persistence.Repositories.Customers;

public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(ECommerceAPPDbContext dbContext) : base(dbContext)
    {
    }
}