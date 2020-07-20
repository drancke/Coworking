using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Mappers
{
   public static class BookingMapper
    {
       
          public static BookingEntity Map (Booking dto)
        {

            return  new BookingEntity
            {
              Id = dto.Id,
              CreateDate = dto.CreateDate,
              Date = dto.Date,
              IdRoom = dto.IdRoom,
              OfficeId = dto.OfficeId,
              RentWorkSpace = dto.RentWorkSpace,
              UserId = dto.UserId
            };
           
        }
        public static Booking Map(BookingEntity dto)
        {

            return new Booking
            {
                Id = dto.Id,
                CreateDate = dto.CreateDate,
                Date = dto.Date,
                IdRoom = dto.IdRoom,
                OfficeId = dto.OfficeId,
                RentWorkSpace = dto.RentWorkSpace,
                UserId = dto.UserId
            };

        }

    }
}
