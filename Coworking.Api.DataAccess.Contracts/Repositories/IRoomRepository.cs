using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Repositories
{
    public interface IRoomRepository : IRepository<RoomEntity>
    {
        Task<RoomEntity> Add(RoomEntity element);
        Task<RoomEntity> Update(RoomEntity entity);
        Task DeleteAsync(int id);
        Task<bool> Exist(int id);
        Task<RoomEntity> Get(int id);
        Task<IEnumerable<RoomEntity>> GetAll();
    }
}
