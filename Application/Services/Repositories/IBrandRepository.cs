using Domain.Entities;
using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories
{
    public interface IBrandRepository: Core.Persistence.Repositories.IAsyncRepository<Brand, Guid>, Core.Persistence.Repositories.IRepository<Brand, Guid>
    {
    }
}
