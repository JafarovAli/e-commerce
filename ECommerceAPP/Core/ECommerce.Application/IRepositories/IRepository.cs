using ECommerceAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPP.Application.IRepositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table {  get; }
}
