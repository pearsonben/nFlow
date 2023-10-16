using Application.Core;
using Application.Features.Workflow.DTOs;
using Application.Features.Workflows.Map;
using Application.Features.Workflows.Requests;
using Application.Features.Workflows.Storage;
using Application.Persistence.Storage;

namespace Application.Features.Workflows.Services;

public class WorkflowService : IWorkflowService
{
    private readonly IUnitOfWork _unitOfWork;

    public WorkflowService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<Result<WorkflowDto>> GetByIdAsync(int id)
    {
        // validate that ID is > 0 
        
        var workflow = await _unitOfWork.WorkflowRepository.GetByIdAsync(id);

        // Validate.
        return workflow is null 
            ? Result<WorkflowDto>.Failure("Workflow not found.") 
            : Result<WorkflowDto>.Success(workflow.ToDto());
    }

    public async Task<Result<bool>> CreateAsync(CreateWorkflowCommand command)
    {
        // validate createcommand here. 
        // if success, continue.

        _unitOfWork.WorkflowRepository.Create(command.ToWorkflow());
        var result = await _unitOfWork.SaveChangesAsync();
        
        if(result is false) return Result<bool>.Failure("Failed to create workflow.");

        return Result<bool>.Success(result);
    }

    public async Task<Result<List<WorkflowDto>>> GetAllAsync()
        => Result<List<WorkflowDto>>.Success(
            (await  _unitOfWork.WorkflowRepository.GetAllAsync())
            .Select(x => x.ToDto()).ToList());
}