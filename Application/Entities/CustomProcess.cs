using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Application.Entities;

public class CustomProcess : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public string Args { get; set; } = string.Empty;
    
    
    // navigation
    public int WorkflowId { get; set; }
    public Workflow Workflow { get; set; } = null!;
}