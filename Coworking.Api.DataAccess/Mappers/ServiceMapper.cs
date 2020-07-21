using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Mappers
{
   public static  class ServiceMapper
    {

        public static ServiceEntity Map(Service dto)
        {
            return new ServiceEntity()
            {
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price,
                Active = dto.Active,

            };
        }
        public static Service Map(ServiceEntity dto)
        {
            return new Service()
            {
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price,
                Active = dto.Active,


            };
        }

    }
}
