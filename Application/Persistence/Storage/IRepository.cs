using Application.Entities;

namespace Application.Persistence.Storage;

public interface IRepository<T> where T : Entity
{
    void Create(T entity);
    Task<T?> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
}