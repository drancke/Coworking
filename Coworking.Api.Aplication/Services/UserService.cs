using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Coworking.Api.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Aplication.Services
{
   public class UserService : IAdminService
    {

        private readonly IAdminRepository _adminRepository;

        public UserService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }


        public async Task<IEnumerable<Admin>> GetAll()
        {
            var dataEntity = await _adminRepository.GetAll();
            return dataEntity.Select(AdminMapper.Map);
        }

        public async Task<Admin> GetAdmin(int id)
        {
            var data = await _adminRepository.Get(id);            
            return AdminMapper.Map(data);
        }

        public async Task<Admin> AddAdmin(Admin admin)
        {
            var data = await _adminRepository.Add(AdminMapper.Map(admin));
            return admin;
        }

        public async Task<Admin> UpdateAdmin(Admin admin)
        {
            var data = await _adminRepository.Update(admin.Id,AdminMapper.Map(admin));
            return admin;
        }

        public async Task Delete (int id)
        {
           await _adminRepository.DeleteAsync(id);
        }

    }
}
