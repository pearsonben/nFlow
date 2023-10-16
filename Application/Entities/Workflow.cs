

namespace Application.Entities;

public class Workflow : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    
    
    // navigation
    public List<CustomProcess> Processes { get; set; } = new();
}