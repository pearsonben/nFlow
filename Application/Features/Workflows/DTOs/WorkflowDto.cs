namespace Application.Features.Workflow.DTOs;

using Entities;

public class WorkflowDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public static WorkflowDto ToDto(Workflow workflow)
        => new ()
        {
            Name = workflow.Name,
            Description = workflow.Description
        };
}