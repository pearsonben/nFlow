using Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Workflow> Workflows { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Workflow>()
            .HasKey(x => x.Id);
    }
}