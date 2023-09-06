using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class TransmisiionRepository : EfRepositoryBase<Transmission, Guid, BaseDbContext>, ITransmissionRepository
    {
        public TransmisiionRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
