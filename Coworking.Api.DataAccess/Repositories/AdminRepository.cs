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
    public class AdminRepository  : IAdminRepository
    {
        private readonly ICoworkingDbContext _coworkingDbContext;


        public AdminRepository(ICoworkingDbContext coworkingDbContext)
        {
            _coworkingDbContext = coworkingDbContext;
        }

        //CRUD:CREATE / READ / UPDATE /DELETE

        

        public async Task<AdminEntity> Add(AdminEntity element)
        {
            await _coworkingDbContext.Admins.AddAsync(element);
            await _coworkingDbContext.SaveChangesAsync();
            return element;
        }

        public async Task<AdminEntity> Update(int id, AdminEntity entity)
        {
            var entry = await Get(id);
            entry.Name = entity.Name;

            _coworkingDbContext.Admins.Update(entity);
            await _coworkingDbContext.SaveChangesAsync();

            return entity;
        }
                                                                                                        
        public async Task DeleteAsync(int id)
        {
            var entity = await _coworkingDbContext.Admins.SingleAsync(x => x.Id == id);
            _coworkingDbContext.Admins.Remove(entity);

            await _coworkingDbContext.SaveChangesAsync();

        }

        public async Task<bool> Exist(int id)
        {
           var entity = await Get(id);
            var result = false;
            if (entity != null)
            {
                result = true;
            }
            return result;

        }

        public async Task<AdminEntity> Get(int id)
        {
            var resultData = await _coworkingDbContext
                            .Admins.Include(x=>x.Office).FirstOrDefaultAsync(x => x.Id == id);
            return resultData;
        }

        public async Task<IEnumerable<AdminEntity>> GetAll()
        {
            var data = await _coworkingDbContext.Admins.Include(x=>x.Office).ToListAsync();

            return data;
        }

     
    }
}
