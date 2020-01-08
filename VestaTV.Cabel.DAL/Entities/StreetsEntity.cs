using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    internal partial class StreetEntity
    {
        public StreetEntity()
        {
            OrderRepairAndRestructions = new HashSet<OrderRepairAndRestructionEntity>();
            Subscribers = new HashSet<SubscriberEntity>();
        }

        public int Id { get; set; }
        public string StreetName { get; set; }
        public int StreetTypes { get; set; }
        public int? CityId { get; set; }

        public virtual CityEntity City { get; set; }
        public virtual ICollection<OrderRepairAndRestructionEntity> OrderRepairAndRestructions { get; set; }
        public virtual ICollection<SubscriberEntity> Subscribers { get; set; }
    }
}
