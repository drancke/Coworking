using Coworking.Api.Business.Models;
using Coworking.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Mapper
{
    public static class AdminMapper
    {

        public static Admin Map(AdminModel dto)
        {
            return new Admin()
            {
                Email = dto.Email,
                Name = dto.Name,
                Phone = dto.Phone,
                HireDate = DateTime.Now
                
            };
        }
     
    }
}
