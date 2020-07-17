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
    public class UserRepository : IUserRepository
    {
        private readonly ICoworkingDbContext _coworkingDbContext;
        public UserRepository(ICoworkingDbContext coworkingDbContext)
        {
            _coworkingDbContext = coworkingDbContext;
        }
     

        public async Task<UserEntity> Add(UserEntity element)
        {
            await _coworkingDbContext.Users.AddAsync(element);
            await _coworkingDbContext.SaveChangesAsync();
            return element;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _coworkingDbContext.Users.SingleAsync(x=>x.Id == id);
            _coworkingDbContext.Users.Remove(entity);
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

        public async Task<UserEntity> Get (int id)
        {
            var result = await _coworkingDbContext.Users.Include(x=>x.Booking).FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            var result = await _coworkingDbContext.Users.Include(x => x.Booking).ToListAsync();
            return result;
        }

        public async Task<UserEntity> Update(int id, UserEntity entity)
        {
            var entry = await Get(id);
            _coworkingDbContext.Users.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
