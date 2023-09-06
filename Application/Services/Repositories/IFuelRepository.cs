using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories
{
    public interface IFuelRepository : Core.Persistence.Repositories.IAsyncRepository<Fuel, Guid>, Core.Persistence.Repositories.IRepository<Fuel, Guid>
    {
    }

}
