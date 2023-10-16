using Application.Persistence.Storage;

namespace Application.Features.Workflows.Storage;

using Entities;

public interface IWorkflowRepository : IRepository<Workflow>
{
}