namespace VestaTV.Cabel.DAL.Entities
{
    internal partial class MasterCityEntity
    {
        public int MasterId { get; set; }
        public int CityId { get; set; }

        public virtual CityEntity City { get; set; }
        public virtual MasterEntity Master { get; set; }
    }
}
