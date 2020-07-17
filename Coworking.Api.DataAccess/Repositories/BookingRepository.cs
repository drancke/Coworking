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
    public class BookingRepository : IBookingRepository
    {
        private readonly ICoworkingDbContext _coworkingDbContext;

        public BookingRepository(ICoworkingDbContext coworkingDbContext)
        {
            _coworkingDbContext = coworkingDbContext;
        }
     

        public async Task<BookingEntity> Add(BookingEntity element)
        {
            await _coworkingDbContext.bookingEntities.AddAsync(element);
            await _coworkingDbContext.SaveChangesAsync();
            return element;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _coworkingDbContext.bookingEntities.SingleAsync(x=>x.Id == id);
            _coworkingDbContext.bookingEntities.Remove(entity);
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

        public async Task<BookingEntity> Get (int id)
        {
            var result = await _coworkingDbContext.bookingEntities.Include(x=>x.Office).Include(x=>x.User).FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<IEnumerable<BookingEntity>> GetAll()
        {
            var result = await _coworkingDbContext.bookingEntities.Include(x => x.Office).ToListAsync();
            return result;
        }

        public async Task<BookingEntity> Update(int id, BookingEntity entity)
        {
            var entry = await Get(id);
            _coworkingDbContext.bookingEntities.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
