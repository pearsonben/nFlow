using Application.Core;
using Application.Features.Workflow.DTOs;
using Application.Features.Workflows.Map;
using Application.Features.Workflows.Requests;
using Application.Features.Workflows.Storage;

namespace Application.Features.Workflows.Services;

using Entities;
public class WorkflowService : IWorkflowService
{
    private readonly IWorkflowRepository _workflowRepository;

    public WorkflowService(IWorkflowRepository workflowRepository)
    {
        _workflowRepository = workflowRepository;
    }
    
    public async Task<Result<WorkflowDto>> GetByIdAsync(int id)
    {
        // validate that ID is > 0 
        
        var workflow = await _workflowRepository.GetByIdAsync(id);

        // Validate.
        return workflow is null 
            ? Result<WorkflowDto>.Failure("Workflow not found.") 
            : Result<WorkflowDto>.Success(workflow.ToDto());
    }

    public async Task<Result<bool>> CreateWorkflowAsync(CreateWorkflowCommand command)
    {
        // validate createcommand here. 
        // if success, continue.

        var result = await _workflowRepository.CreateAsync(command.ToWorkflow());
        
        if(result is false) return Result<bool>.Failure("Failed to create workflow.");

        return Result<bool>.Success(result);
    }
}