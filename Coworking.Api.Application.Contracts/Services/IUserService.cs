using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts.Services
{
   public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> Get(int id);
        Task<User> Add(User user);
        Task<User> Update(User user);
        Task Delete(int id);
        Task<bool> Exits(int id);


    }
}
