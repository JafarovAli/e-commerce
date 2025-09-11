using ECommerceAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPP.Persistence.Contexts;

public class ECommerceAPPDbContext : DbContext
{
    public ECommerceAPPDbContext(DbContextOptions options) : base(options)
    { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var datas = ChangeTracker.Entries<BaseEntity>();

        foreach (var data in datas)
        {
            _ = data.State switch
            {
                EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                EntityState.Modified => data.Entity.UpdateDate = DateTime.UtcNow
            };
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}