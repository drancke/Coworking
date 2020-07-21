using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.Mapper
{
   public static class BookingMapper
    {
       
          public static Booking Map (BookingModel dto)
        {

            return  new Booking
            {
              
              CreateDate = dto.CreateDate,
              Date = dto.Date,
              IdRoom = dto.IdRoom,
              OfficeId = dto.OfficeId,                                        
              RentWorkSpace = dto.RentWorkSpace,
              UserId = dto.UserId
            };
           
        }
        public static BookingModel Map(Booking dto)
        {

            return new BookingModel
            {
                
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
