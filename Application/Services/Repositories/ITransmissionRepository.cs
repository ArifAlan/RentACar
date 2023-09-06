using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface ITransmissionRepository : Core.Persistence.Repositories.IAsyncRepository<Transmission, Guid>, Core.Persistence.Repositories.IRepository<Transmission, Guid>
    {
    }

}
