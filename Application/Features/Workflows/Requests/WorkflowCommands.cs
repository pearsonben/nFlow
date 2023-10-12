namespace Application.Features.Workflows.Requests;


/// <summary>
/// Command for Creating a workflow.
/// </summary>
/// <param name="Name"></param>
/// <param name="Description"></param>
public record CreateWorkflowCommand(string Name, string Description);

/// <summary>
/// Command for updating a workflow.
/// </summary>
/// <param name="Name"></param>
/// <param name="Description"></param>
public record UpdateWorkflowCommand(string Name, string Description);