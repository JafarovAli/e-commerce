using ECommerceAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPP.Persistence.Contexts;

public class ECommerceAPPDbContext : DbContext
{
    public ECommerceAPPDbContext(DbContextOptions options) : base(options)
    {}

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
}