using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
   public class OfficeEntity
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public bool  Acctive { get; set; }
        public int IdAdmin { get; set; }
        public int HasIndividualWorkSpace { get; set; }
        public int NumberWorSpace { get; set; }
        public double PriceWorkSpaceMonth { get; set; }
        public double PriceWorKpaceDay { get; set; }

        public virtual AdminEntity Admin { get; set; }
        public virtual ICollection<Office2RoomEntity> Office2Room { get; set; }
        public virtual BookingEntity Booking { get; set; }
    }
}
