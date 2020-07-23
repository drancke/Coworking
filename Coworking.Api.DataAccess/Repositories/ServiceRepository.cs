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
    public class ServiceRepository : IServiceRepository
    {
        private readonly ICoworkingDbContext _coworkingDbContext;
        public ServiceRepository(ICoworkingDbContext coworkingDbContext)
        {
            _coworkingDbContext = coworkingDbContext;
        }
     

        public async Task<ServiceEntity> Add(ServiceEntity element)
        {
            await _coworkingDbContext.Services.AddAsync(element);
            await _coworkingDbContext.SaveChangesAsync();
            return element;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _coworkingDbContext.Services.SingleAsync(x=>x.Id == id);
            _coworkingDbContext.Services.Remove(entity);
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

        public async Task<ServiceEntity> Get (int id)
        {
            var result = await _coworkingDbContext.Services.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<IEnumerable<ServiceEntity>> GetAll()
        {
            var result = await _coworkingDbContext.Services.ToListAsync();
            return result;
        }

        public async Task<ServiceEntity> Update( ServiceEntity entity)
        {
            
            var updateEntity = _coworkingDbContext.Services.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
