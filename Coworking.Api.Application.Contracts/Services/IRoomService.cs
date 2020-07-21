using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts.Services
{
   public interface IRoomService
    {
        Task<IEnumerable<Room>> GetAll();
        Task<Room> Get(int id);
        Task<Room> Add(Room room);
        Task<Room> Update(Room room);
        Task Delete(int id);
        Task<bool> Exits(int id);


    }
}
