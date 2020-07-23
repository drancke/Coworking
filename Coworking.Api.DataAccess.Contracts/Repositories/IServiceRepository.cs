using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Repositories
{
    public interface IServiceRepository : IRepository<ServiceEntity>
    {
        Task<ServiceEntity> Add(ServiceEntity element);
        Task<ServiceEntity> Update(ServiceEntity entity);
        Task DeleteAsync(int id);
        Task<bool> Exist(int id);
        Task<ServiceEntity> Get(int id);
        Task<IEnumerable<ServiceEntity>> GetAll();
    }
}
