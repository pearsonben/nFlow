using Application.Features.Workflow.DTOs;
using Application.Features.Workflows.Requests;

namespace Application.Features.Workflows.Map;

using Entities;

public static class WorkflowMap
{
    public static WorkflowDto ToDto(this Workflow workflow)
        => new ()
        {
            Name = workflow.Name,
            Description = workflow.Description
        };

    public static Workflow ToWorkflow(this CreateWorkflowCommand command) =>
        new ()
        {
            Name = command.Name,
            Description = command.Description 
        };
    
    public static Workflow ToWorkflow(this UpdateWorkflowCommand command) =>
        new ()
        {
            Name = command.Name,
            Description = command.Description 
        };
}