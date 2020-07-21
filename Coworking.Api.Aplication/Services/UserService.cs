using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Coworking.Api.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.Aplication.Services
{
   public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public async Task<IEnumerable<User>> GetAll()
        {
            var dataEntity = await _userRepository.GetAll();
            return dataEntity.Select(UserMapper.Map);
        }

        public async Task<User> Get(int id)
        {
            var data = await _userRepository.Get(id);            
            return UserMapper.Map(data);
        }

        public async Task<User> Add(User user)
        {
            var data = await _userRepository.Add(UserMapper.Map(user));
            return user;
        }

        public async Task<User> Update(User user)
        {
            var data = await _userRepository.Update(user.Id, UserMapper.Map(user));
            return user;
        }

        public async Task Delete (int id)
        {
           await _userRepository.DeleteAsync(id);
        }

        public async Task<bool> Exits(int id)
        {
            var data = await _userRepository.Exist(id);
            return data;
        }
    }
}
