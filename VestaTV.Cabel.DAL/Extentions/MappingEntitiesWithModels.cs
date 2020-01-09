using AutoMapper;
using System;
using System.Collections.Generic;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.Extentions
{
    internal static class MappingEntitiesWithModels
    {
        private static readonly IMapper mapper;

        static MappingEntitiesWithModels()
        {
            MapperConfiguration configuration = new MapperConfiguration(cnf =>
            {
                cnf.AddProfile<AutoMappingProfile>();
            });
            mapper = configuration.CreateMapper();
        }

        public static MasterEntity Map(this Master master)
        {
            return mapper.Map<Master, MasterEntity>(master);
        }

        public static Master Map(this MasterEntity master)
        {
            return mapper.Map<MasterEntity, Master>(master);
        }

        public static IEnumerable<Master> Map(this IEnumerable<MasterEntity> masters)
        {
            return mapper.Map<IEnumerable<MasterEntity>, IEnumerable<Master>>(masters);
        }

        public static IEnumerable<MasterEntity> Map(this IEnumerable<Master> masters)
        {
            return mapper.Map<IEnumerable<Master>, IEnumerable<MasterEntity>>(masters);
        }

        public static Func<MasterEntity, bool> Map(this Func<Master, bool> masters)
        {
            return mapper.Map<Func<Master, bool>, Func<MasterEntity, bool>>(masters);
        }
    }
}
