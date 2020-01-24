using System;
using System.Collections.Generic;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.Extentions
{
    internal static class UserMapSettings
    {

        public static UserEntity Map(this User user)
        {
            return MapperSingleton.Mapper.Map<User, UserEntity>(user);
        }

        public static User Map(this UserEntity user)
        {
            return MapperSingleton.Mapper.Map<UserEntity, User>(user);
        }

        public static IEnumerable<User> Map(this IEnumerable<UserEntity> users)
        {
            return MapperSingleton.Mapper.Map<IEnumerable<UserEntity>, IEnumerable<User>>(users);
        }

        public static IEnumerable<UserEntity> Map(this IEnumerable<User> users)
        {
            return MapperSingleton.Mapper.Map<IEnumerable<User>, IEnumerable<UserEntity>>(users);
        }

        public static Func<UserEntity, bool> Map(this Func<User, bool> users)
        {
            return MapperSingleton.Mapper.Map<Func<User, bool>, Func<UserEntity, bool>>(users);
        }
    }
}
