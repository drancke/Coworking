using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Repositories
{
    public interface IOfficeRepository : IRepository<OfficeEntity>
    {
        Task<OfficeEntity> Add(OfficeEntity element);
        Task<OfficeEntity> Update(int id, OfficeEntity entity);
        Task DeleteAsync(int id);
        Task<bool> Exist(int id);
        Task<OfficeEntity> Get(int id);
        Task<IEnumerable<OfficeEntity>> GetAll();
    }
}
