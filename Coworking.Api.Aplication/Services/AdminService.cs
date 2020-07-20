using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Aplication.Services
{
   public class AdminService : IAdminService
    {

        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task<string> GetNameAdmin(int id)
        {
            var data = await _adminRepository.Get(id);
            var NameAdmin = data.Name;

            return NameAdmin;
        }

    }
}
