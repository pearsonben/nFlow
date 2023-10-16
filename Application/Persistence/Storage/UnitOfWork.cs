using Application.Features.Processes.Storage;
using Application.Features.Workflows.Storage;

namespace Application.Persistence.Storage;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    public IWorkflowRepository WorkflowRepository { get; }
    public IProcessRepository ProcessRepository { get; }

    public UnitOfWork(AppDbContext context, IWorkflowRepository workflowRepository, IProcessRepository processRepository)
    {
        _context = context;
        WorkflowRepository = workflowRepository;
        ProcessRepository = processRepository;
    }
    
    public async Task<bool> SaveChangesAsync() => await _context.SaveChangesAsync() > 0;
}