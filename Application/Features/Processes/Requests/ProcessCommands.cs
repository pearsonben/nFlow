namespace Application.Features.Processes.Requests;


public record CreateProcessCommand(int WorkflowId, string Name, string Path, string Args = "");
public record UpdateProcessCommand(int WorkflowId, string Name, string Path, string Args = "");
