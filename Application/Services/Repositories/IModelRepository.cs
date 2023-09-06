using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IModelRepository : Core.Persistence.Repositories.IAsyncRepository<Model, Guid>, Core.Persistence.Repositories.IRepository<Model, Guid>
    {
    }

}
