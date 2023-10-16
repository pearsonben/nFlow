using Application.Features.Workflow.DTOs;
using Application.Persistence;
using Application.Persistence.Storage;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Workflows.Storage;

using Entities;

public class WorkflowRepository : Repository<Workflow>, IWorkflowRepository
{
    public WorkflowRepository(AppDbContext context) : base(context){}
}