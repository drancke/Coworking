using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts.Services
{
   public interface IAdminService
    {

        Task<string> GetNameAdmin(int id);
    }
}
