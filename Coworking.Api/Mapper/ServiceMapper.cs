using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.Mapper
{
   public static  class ServiceMapper
    {

        public static Service Map(ServiceModel dto)
        {
            return new Service()
            {
               
                Name = dto.Name,
                Price = dto.Price,
                Active = dto.Active,

            };
        }
      

    }
}
