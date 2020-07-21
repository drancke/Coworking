using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.ViewModel
{
    public class BookingModel
    {
        
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateDate { get; set; }
        public int OfficeId { get; set; }
        public bool RentWorkSpace { get; set; }
        public int? IdRoom { get; set; }
    }
}
