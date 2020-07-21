using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Mappers
{
   public static class UserMapper
    {
        public static User Map (UserEntity userEntity)
        {
            return new User
            {
                Id = userEntity.Id,
                Name = userEntity.Name,
                Email = userEntity.Email,
                SurName = userEntity.SurName,
                Active = userEntity.Active,
                CreateDate = userEntity.CreateDate
            };

        }
        public static UserEntity Map(User userEntity)
        {
            return new UserEntity
            {
                Id = userEntity.Id,
                Name = userEntity.Name,
                Email = userEntity.Email,
                SurName = userEntity.SurName,
                Active = userEntity.Active,
                CreateDate = userEntity.CreateDate
            };

        }

    }
}
