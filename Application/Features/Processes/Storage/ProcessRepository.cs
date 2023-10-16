using Application.Entities;
using Application.Persistence;
using Application.Persistence.Storage;

namespace Application.Features.Processes.Storage;

public class ProcessRepository : Repository<CustomProcess>, IProcessRepository
{

    public ProcessRepository(AppDbContext context) : base(context)
    {
    }

}