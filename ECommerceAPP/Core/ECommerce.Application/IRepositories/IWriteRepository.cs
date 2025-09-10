using ECommerceAPP.Domain.Entities;

namespace ECommerceAPP.Application.IRepositories;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    Task<bool> AddAsync(T entity);
    Task<bool> AddRangeAsync(List<T> datas);
    bool Remove(T entity);
    Task<bool> RemoveAsync(string id);
    bool Update(T entity);
    Task<int> SaveChangeAsync();
}
