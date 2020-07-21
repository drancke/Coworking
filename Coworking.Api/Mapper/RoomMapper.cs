using Coworking.Api.Business.Models;
using Coworking.Api.ViewModel;


namespace Coworking.Api.Mapper
{
    public static class RoomMapper
    {

        public static Room Map(RoomModel dto)
        {
            return new Room()
            {
                   
                     Name = dto.Name,
                     Cantidad = dto.Cantidad,
                 
            };
        }
      




    }
}
