using Application.Entities;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace Application.Persistence.Storage;

public class Repository<T> : IRepository<T> where T : Entity
{
    private readonly AppDbContext _context;

    protected Repository(AppDbContext context)
    {
        _context = context;
    }

    public void Create(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public async Task<T?> GetByIdAsync(int id)
        => await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

    public async Task<List<T>> GetAllAsync()
        => await _context.Set<T>().ToListAsync();
}