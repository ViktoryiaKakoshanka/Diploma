using AutoMapper;
using System;
using System.Collections.Generic;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.Extentions
{
    internal static class MasterMapSettings
    {

        public static MasterEntity Map(this Master master)
        {
            return MapperSingleton.Mapper.Map<Master, MasterEntity>(master);
        }

        public static Master Map(this MasterEntity master)
        {
            return MapperSingleton.Mapper.Map<MasterEntity, Master>(master);
        }

        public static IEnumerable<Master> Map(this IEnumerable<MasterEntity> masters)
        {
            return MapperSingleton.Mapper.Map<IEnumerable<MasterEntity>, IEnumerable<Master>>(masters);
        }

        public static IEnumerable<MasterEntity> Map(this IEnumerable<Master> masters)
        {
            return MapperSingleton.Mapper.Map<IEnumerable<Master>, IEnumerable<MasterEntity>>(masters);
        }

        public static Func<MasterEntity, bool> Map(this Func<Master, bool> masters)
        {
            return MapperSingleton.Mapper.Map<Func<Master, bool>, Func<MasterEntity, bool>>(masters);
        }
    }
}
