namespace Application.Features.Workflows.Storage;

using Entities;

public interface IWorkflowRepository
{
    Task<bool> CreateAsync(Workflow workflow);
    Task<Workflow?> GetByIdAsync(int id);
    Task<List<Workflow>> GetAllAsync();
}