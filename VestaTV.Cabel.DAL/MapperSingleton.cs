using AutoMapper;

namespace VestaTV.Cabel.DAL
{
    internal class MapperSingleton
    {
        public static IMapper Mapper { get; }

        static MapperSingleton()
        {
            MapperConfiguration configuration = new MapperConfiguration(cnf =>
            {
                cnf.AddProfile<AutoMappingProfile>();
            });
            Mapper = configuration.CreateMapper();
        }


    }
}
