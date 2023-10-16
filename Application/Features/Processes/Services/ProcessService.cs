
using System.Diagnostics;
using Application.Core;
using Application.Features.Processes.DTOs;
using Application.Features.Processes.Requests;
using Application.Persistence.Storage;
using Application.Features.Processes.Map;

namespace Application.Features.Processes.Services;

public class ProcessService : IProcessService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProcessService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<Result<ProcessDto>> GetByIdAsync(int id)
    {
        // validate that ID is > 0 
        
        var process = await _unitOfWork.ProcessRepository.GetByIdAsync(id);

        // Validate.
        return process is null 
            ? Result<ProcessDto>.Failure("Process not found.") 
            : Result<ProcessDto>.Success(process.ToDto());
    }

    public async Task<Result<bool>> CreateAsync(CreateProcessCommand command)
    {
        _unitOfWork.ProcessRepository.Create(command.ToProcess());
        var result = await _unitOfWork.SaveChangesAsync();
        
        if(result is false) return Result<bool>.Failure("Failed to create process.");

        return Result<bool>.Success(result);
    }

    public async Task<Result<List<ProcessDto>>> GetAllAsync() => Result<List<ProcessDto>>.Success(
        (await  _unitOfWork.ProcessRepository.GetAllAsync())
        .Select(x => x.ToDto()).ToList());
}