using Application.Entities;

namespace Application.Features.Processes.DTOs;

public class ProcessDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public string Args { get; set; } = string.Empty;
}