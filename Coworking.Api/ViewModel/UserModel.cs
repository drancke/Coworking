using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.ViewModel
{
    public class UserModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
