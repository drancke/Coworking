using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts.Services
{
   public interface IOfficeService
    {
        Task<IEnumerable<Office>> GetAll();
        Task<Office> Get(int id);
        Task<Office> Add(Office office);
        Task<Office> Update(Office office);
        Task Delete(int id);
        Task<bool> Exits(int id);


    }
}
