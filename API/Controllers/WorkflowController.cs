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
    public async Task<ActionResult<bool>> CreateAsync(CreateWorkflowCommand command)
        => HandleResult(await _workflowService.CreateAsync(command));
    
    [HttpGet("{id}")]
    public async Task<ActionResult<WorkflowDto>> GetById([FromRoute] int id) 
        => HandleResult(await _workflowService.GetByIdAsync(id));
    
    [HttpGet]
    public async Task<ActionResult<List<WorkflowDto>>> GetAll()
        => HandleResult(await _workflowService.GetAllAsync());
}