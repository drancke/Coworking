using Coworking.Api.Business.Models;
using Coworking.Api.DataAccess.Contracts.Entities;
using Coworking.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.Mapper
{
   public static class UserMapper
    {
        public static User Map (UserModel userEntity)
        {
            return new User
            {
                Name = userEntity.Name,
                Email = userEntity.Email,
                SurName = userEntity.SurName,
                Active = userEntity.Active,
                CreateDate = userEntity.CreateDate
            };

        }
    

    }
}
