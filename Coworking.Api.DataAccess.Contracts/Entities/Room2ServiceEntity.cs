using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
   public class Room2ServiceEntity
    {
        public int IdService { get; set; }

        public int IdRoom { get; set; }

        public virtual RoomEntity Room { get; set; }

        public virtual ServiceEntity Service { get; set; }
    }
}
