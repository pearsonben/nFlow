using Application.Features.Processes.DTOs;
using Application.Features.Processes.Requests;
using Application.Features.Processes.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class ProcessController : ApiControllerBase
{
    private readonly IProcessService _processService;

    public ProcessController(IProcessService processService)
    {
        _processService = processService;
    }
    
    [HttpPost]
    public async Task<ActionResult<bool>> CreateAsync(CreateProcessCommand command)
        => HandleResult(await _processService.CreateAsync(command));
    
    [HttpGet("{id}")]
    public async Task<ActionResult<ProcessDto>> GetById([FromRoute] int id) 
        => HandleResult(await _processService.GetByIdAsync(id));
    
    [HttpGet]
    public async Task<ActionResult<List<ProcessDto>>> GetAll()
        => HandleResult(await _processService.GetAllAsync());
    
    
}