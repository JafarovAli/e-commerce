using ECommerceAPP.Application.IRepositories;
using ECommerceAPP.Domain.Entities;
using ECommerceAPP.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPP.Persistence.Repositories
{
    public class WriteRepository<T>(ECommerceAPPDbContext dbContext) : IWriteRepository<T> where T : BaseEntity
    {
        public DbSet<T> Table => dbContext.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            var entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T entity)
        {
            var entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var entity = await Table.FirstOrDefaultAsync(e=> e.Id == Guid.Parse(id));
            return Remove(entity);
        }
        public bool Update(T entity)
        {
            var entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveChangeAsync()
        => await dbContext.SaveChangesAsync();

    }
}
