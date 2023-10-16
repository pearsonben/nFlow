using Application.Entities;
using Application.Features.Processes.DTOs;
using Application.Features.Processes.Requests;

namespace Application.Features.Processes.Map;

public static class ProcessMap
{
    public static ProcessDto ToDto(this CustomProcess process)
        => new ()
        {
            Id = process.Id,
            Name = process.Name,
            Path = process.Path,
            Args = process.Args
        };

    public static CustomProcess ToProcess(this CreateProcessCommand command)
        => new()
        {
            WorkflowId = command.WorkflowId,
            Name = command.Name,
            Path = command.Path,
            Args = command.Args
        };
}