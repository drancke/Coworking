using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
   public class RoomEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cantidad { get; set; }

        public virtual ICollection<Office2RoomEntity> Office2Room { get; set; }
        public virtual ICollection<Room2ServiceEntity> Room2Services { get; set; }

    }
}
