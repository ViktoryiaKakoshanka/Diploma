using AutoMapper;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.Extentions
{
    internal static class MappingEntitiesWithModels
    {
        private static readonly IMapper mapper = UnitOfWork.mapper;
        public static MasterEntity Map(this Master master)
        {
            return mapper.Map<Master, MasterEntity>(master);
        }
    }
}
