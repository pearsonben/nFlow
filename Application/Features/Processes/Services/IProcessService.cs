using Application.Core;
using Application.Features.Processes.DTOs;
using Application.Features.Processes.Requests;
using Application.Features.Workflow.DTOs;

namespace Application.Features.Processes.Services;

public interface IProcessService
{
    Task<Result<ProcessDto>> GetByIdAsync(int id);
    Task<Result<bool>> CreateAsync(CreateProcessCommand command);
    Task<Result<List<ProcessDto>>> GetAllAsync();
}