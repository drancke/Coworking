using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts.Services
{
   public interface IServicesService
    {
        Task<IEnumerable<Service>> GetAll();
        Task<Service> Get(int id);
        Task<Service> Add(Service service);
        Task<Service> Update(Service service);
        Task Delete(int id);
        Task<bool> Exits(int id);


    }
}
