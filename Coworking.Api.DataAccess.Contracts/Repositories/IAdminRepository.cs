using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Repositories
{
   public interface IAdminRepository : IRepository<AdminEntity>
    {
        Task<IEnumerable<AdminEntity>> GetAll();
        Task<AdminEntity> Get(int id);
        Task<AdminEntity> Add(AdminEntity adminEntity);
        Task<AdminEntity> Update(int id,AdminEntity adminEntity);
        Task DeleteAsync(int id);
        Task<bool> Exist(int id);
    }
}
