using Application.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Workflows.Storage;

using Entities;

public class WorkflowRepository : IWorkflowRepository
{
    private readonly AppDbContext _context;

    public WorkflowRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<bool> CreateAsync(Workflow workflow)
    {
        _context.Workflows.Add(workflow);

        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<Workflow?> GetByIdAsync(int id)
        => await _context.Workflows.FirstOrDefaultAsync(x => x.Id == id);
    //=> await _context.Workflows.FirstOrDefaultAsync(x => x.Id == id);
}