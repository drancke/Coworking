using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.Mapper
{
   public static class OfficeMapper
    {
        public static Office Map(OfficeModel dto)
        {
            return new Office
            {
               Name = dto.Name,
               Acctive = dto.Acctive,
               Address = dto.Address,
               City = dto.City,
               HasIndividualWorkSpace = dto.HasIndividualWorkSpace,
               IdAdmin = dto.IdAdmin,
               NumberWorSpace = dto.NumberWorSpace,
               Phone = dto.Phone,
               PriceWorKpaceDay = dto.PriceWorKpaceDay,
               PriceWorkSpaceMonth = dto.PriceWorkSpaceMonth
             
            };

        }
     
    }
}
