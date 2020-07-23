using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Repositories
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> Add(UserEntity element);
        Task<UserEntity> Update(UserEntity entity);
        Task DeleteAsync(int id);
        Task<bool> Exist(int id);
        Task<UserEntity> Get(int id);
        Task<IEnumerable<UserEntity>> GetAll();
    }
}
