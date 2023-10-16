using Application.Entities;
using Application.Persistence.Storage;

namespace Application.Features.Processes.Storage;

public interface IProcessRepository : IRepository<CustomProcess>
{
}