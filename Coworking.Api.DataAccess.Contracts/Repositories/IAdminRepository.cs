using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Repositories
{
   public interface IAdminRepository : IRepository<AdminEntity>
    {
        Task<AdminEntity> Add(AdminEntity element);

        Task<AdminEntity> Update(int id, AdminEntity entity);
        Task DeleteAsync(int id);
        Task<bool> Exist(int id);
        Task<AdminEntity> Get(int id);
        Task<IEnumerable<AdminEntity>> GetAll();
    }
}
