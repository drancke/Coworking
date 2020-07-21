using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts.Services
{
   public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetAll();
        Task<Booking> Get(int id);
        Task<Booking> Add(Booking admin);
        Task<Booking> Update(Booking admin);
        Task Delete(int id);
        Task<bool> Exits(int id);


    }
}
