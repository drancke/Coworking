using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Mappers
{
    public static class RoomMapper
    {

        public static RoomEntity Map(Room dto)
        {
            return new RoomEntity()
            {
                     Id = dto.Id,
                     Name = dto.Name,
                     Cantidad = dto.Cantidad,
                 
            };
        }
        public static Room Map(RoomEntity dto)
        {
            return new Room()
            {
                Id = dto.Id,
                Name = dto.Name,
                Cantidad = dto.Cantidad,

            };
        }





    }
}
