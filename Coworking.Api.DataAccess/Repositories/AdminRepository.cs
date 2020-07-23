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

        // CRUD: CREATE / READ / UPDATE /DELETE 



        public async Task<IEnumerable<AdminEntity>> GetAll()
        {
            var data = await _coworkingDbContext.Admins.ToListAsync();
            return data;
        }

        public async Task<AdminEntity> Get(int id)
        {
            var resultData = await _coworkingDbContext
                            .Admins.FirstOrDefaultAsync(x => x.Id == id);
            return resultData;
        }

        public async Task<AdminEntity> Add(AdminEntity adminEntity)
        {
            var data = await _coworkingDbContext.Admins.AddAsync(adminEntity);
            await _coworkingDbContext.SaveChangesAsync();
            return adminEntity;
        }

        public async Task<AdminEntity> Update(AdminEntity adminEntity)
        {
         
            var updateEntity =    _coworkingDbContext.Admins.Update(adminEntity);
            await _coworkingDbContext.SaveChangesAsync();

            return updateEntity.Entity;

        }

        public async Task DeleteAsync(int id)
        {
           var dataEntity =  await Get(id);
            _coworkingDbContext.Admins.Remove(dataEntity);
            await _coworkingDbContext.SaveChangesAsync();

        }

        public async Task<bool> Exist(int id)
        {
            var dataExist = await Get(id);
            bool existAdmin = false;
            if (dataExist != null)
            {
                existAdmin = true;
                return existAdmin;
            }

            return existAdmin;
        }

  

   
    }
}
