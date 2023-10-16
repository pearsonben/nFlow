using Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Workflow> Workflows { get; set; }
    public DbSet<CustomProcess> Processes { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Workflow>()
            .HasMany(x => x.Processes)
            .WithOne(x => x.Workflow)
            .HasForeignKey(x => x.WorkflowId);
        
    }
}