using Application.Core;
using Application.Features.Workflow.DTOs;
using Application.Features.Workflows.Requests;

namespace Application.Features.Workflows.Services;

public interface IWorkflowService
{
    Task<Result<WorkflowDto>> GetByIdAsync(int id);
    Task<Result<bool>> CreateWorkflowAsync(CreateWorkflowCommand command);
}