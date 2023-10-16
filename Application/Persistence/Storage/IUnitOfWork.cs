using Application.Features.Processes.Storage;
using Application.Features.Workflows.Storage;

namespace Application.Persistence.Storage;

public interface IUnitOfWork
{
    public IWorkflowRepository WorkflowRepository { get; }
    public IProcessRepository ProcessRepository { get; }
    Task<bool> SaveChangesAsync();
}