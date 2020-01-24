using AutoMapper;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<Master, MasterEntity>().ReverseMap();
            CreateMap<User, UserEntity>().ReverseMap();
        }
    }
}
