using ECommerceAPP.Application.IRepositories;
using ECommerceAPP.Domain.Entities;
using ECommerceAPP.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerceAPP.Persistence.Repositories;

public class ReadRepository<T>(ECommerceAPPDbContext dbContext) : IReadRepository<T> where T : BaseEntity
{
    public DbSet<T> Table => dbContext.Set<T>();

    public IQueryable<T> GetAll()
        => Table.AsNoTracking();
    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
    => Table.Where(expression).AsNoTracking();

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
    => await Table.AsQueryable().AsNoTracking().FirstOrDefaultAsync(expression);

    public async Task<T> GetByIdAsync(string id)
    // => await Table.FirstOrDefaultAsync(e => e.Id == Guid.Parse(id));
    => await Table.AsQueryable().AsNoTracking().FirstOrDefaultAsync(e => e.Id == Guid.Parse(id));
}
