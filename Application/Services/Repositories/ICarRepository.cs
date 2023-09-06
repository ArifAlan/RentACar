using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface ICarRepository : Core.Persistence.Repositories.IAsyncRepository<Car, Guid>, Core.Persistence.Repositories.IRepository<Car, Guid>
    {
    }

}
