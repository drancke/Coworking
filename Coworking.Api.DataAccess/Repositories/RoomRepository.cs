using Coworking.Api.DataAccess.Contracts;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ICoworkingDbContext _coworkingDbContext;
        public RoomRepository(ICoworkingDbContext coworkingDbContext)
        {
            _coworkingDbContext = coworkingDbContext;
        }
     

        public async Task<RoomEntity> Add(RoomEntity element)
        {
            await _coworkingDbContext.Rooms.AddAsync(element);
            await _coworkingDbContext.SaveChangesAsync();
            return element;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _coworkingDbContext.Rooms.SingleAsync(x=>x.Id == id);
            _coworkingDbContext.Rooms.Remove(entity);
            await _coworkingDbContext.SaveChangesAsync();

        }

        public async Task<bool> Exist(int id)
        {
            var result =  await Get(id);
            var existData = false;
            if (result != null)
            {
                existData = true;
            }

            return existData;
        }

        public async Task<RoomEntity> Get (int id)
        {
            var result = await _coworkingDbContext.Rooms.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<IEnumerable<RoomEntity>> GetAll()
        {
            var result = await _coworkingDbContext.Rooms.ToListAsync();
            return result;
        }

        public async Task<RoomEntity> Update(int id, RoomEntity entity)
        {
            var entry = await Get(id);
            _coworkingDbContext.Rooms.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
