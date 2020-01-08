using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    internal partial class CityEntity
    {
        public CityEntity()
        {
            Masters = new HashSet<MasterCityEntity>();
            OrderRepairAndRestructions = new HashSet<OrderRepairAndRestructionEntity>();
            Streets = new HashSet<StreetEntity>();
            Subscribers = new HashSet<SubscriberEntity>();
        }

        public int Id { get; set; }
        public string ShortNameOfCityType { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<MasterCityEntity> Masters { get; set; }
        public virtual ICollection<OrderRepairAndRestructionEntity> OrderRepairAndRestructions { get; set; }
        public virtual ICollection<StreetEntity> Streets { get; set; }
        public virtual ICollection<SubscriberEntity> Subscribers { get; set; }
    }
}
