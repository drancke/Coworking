using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Repositories
{
    public interface IBookingRepository : IRepository<BookingEntity>
    {
        Task<BookingEntity> Add(BookingEntity element);
        Task<BookingEntity> Update( BookingEntity entity);
        Task DeleteAsync(int id);
        Task<bool> Exist(int id);
        Task<BookingEntity> Get(int id);
        Task<IEnumerable<BookingEntity>> GetAll();
    }
}
