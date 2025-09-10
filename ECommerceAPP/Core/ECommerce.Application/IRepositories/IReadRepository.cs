using ECommerceAPP.Domain.Entities;
using System.Linq.Expressions;

namespace ECommerceAPP.Application.IRepositories;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
    Task<T> GetSingleAsync(Expression<Func<T, bool>> expression);
    Task<T> GetByIdAsync(string id);

}
