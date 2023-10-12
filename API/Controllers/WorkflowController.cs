using Application.Core;
using Application.Features.Workflow.DTOs;
using Application.Features.Workflows.Requests;
using Application.Features.Workflows.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class WorkflowController : ApiControllerBase
{
    private readonly IWorkflowService _workflowService;

    public WorkflowController(IWorkflowService workflowService)
    {
        _workflowService = workflowService;
    }

    [HttpPost]
    public async Task<ActionResult<bool>> CreateWorkflow(CreateWorkflowCommand command)
        => HandleResult(await _workflowService.CreateWorkflowAsync(command));

    [HttpGet("/{id}")]
    public async Task<ActionResult<WorkflowDto>> GetWorkflowById([FromRoute] int id)
    {
        return HandleResult(await _workflowService.GetByIdAsync(id));
    }

}