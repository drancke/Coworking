using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
   public class Office2RoomEntity
    {
        public int IdRoom { get; set; }
        public int IdOffice { get; set; }

        public virtual RoomEntity Room { get; set; }
        public virtual OfficeEntity Office { get; set; }

    }
}
