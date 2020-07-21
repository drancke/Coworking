using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.ViewModel
{
    public class OfficeModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public bool Acctive { get; set; }
        public int IdAdmin { get; set; }
        public int HasIndividualWorkSpace { get; set; }
        public int NumberWorSpace { get; set; }
        public double PriceWorkSpaceMonth { get; set; }
        public double PriceWorKpaceDay { get; set; }

    }
}
