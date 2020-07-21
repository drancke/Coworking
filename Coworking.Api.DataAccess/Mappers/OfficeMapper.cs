using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Mappers
{
   public static class OfficeMapper
    {
        public static Office Map(OfficeEntity dto)
        {
            return new Office
            {
               Id = dto.Id,
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
        public static OfficeEntity Map(Office dto)
        {
            return new OfficeEntity
            {
                Id = dto.Id,
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
