using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Mappers
{
   public static class AdminMapper
    {
        public static AdminEntity Map(Admin dto)
        {
            return new AdminEntity()
            {
                Email = dto.Email,
                Name = dto.Name,
                Id = dto.Id,
                Phone = dto.Phone,
                //HireDate = dto.HireDate
            };
        }
        public static Admin Map(AdminEntity dto)
        {
            return new Admin()
            {
                Email = dto.Email,
                Name = dto.Name,
                Id = dto.Id,
                Phone = dto.Phone,
                //HireDate = dto.HireDate
              
            };
        }
    }
}
