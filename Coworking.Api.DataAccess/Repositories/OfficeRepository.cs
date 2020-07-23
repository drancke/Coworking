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
    public class OfficeRepository : IOfficeRepository
    {
        private readonly ICoworkingDbContext _coworkingDbContext;
        public OfficeRepository(ICoworkingDbContext coworkingDbContext)
        {
            _coworkingDbContext = coworkingDbContext;
        }
     

        public async Task<OfficeEntity> Add(OfficeEntity element)
        {
            await _coworkingDbContext.Offices.AddAsync(element);
            await _coworkingDbContext.SaveChangesAsync();
            return element;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _coworkingDbContext.Offices.SingleAsync(x=>x.Id == id);
            _coworkingDbContext.Offices.Remove(entity);
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

        public async Task<OfficeEntity> Get (int id)
        {
            var result = await _coworkingDbContext.Offices.Include(x=>x.Booking).FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<IEnumerable<OfficeEntity>> GetAll()
        {
            var result = await _coworkingDbContext.Offices.Include(x => x.Booking).ToListAsync();
            return result;
        }

        public async Task<OfficeEntity> Update(OfficeEntity entity)
        {
          
            var updateEntity = _coworkingDbContext.Offices.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();
            return updateEntity.Entity;
        }
    }
}
