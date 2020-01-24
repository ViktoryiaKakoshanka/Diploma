using System;
using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    internal partial class SubscriberEntity
    {
        public SubscriberEntity()
        {
            OrderOnCableTvs = new HashSet<OrderOnCableTVEntity>();
            SubscriberRelationships = new HashSet<SubscriberRelationshipEntity>();
        }

        public int Id { get; set; }
        public int NumberOfContract { get; set; }
        public DateTime ContractDate { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string SecondMobilePhone { get; set; }
        public RelationshipTypeEntity RelationshipType { get; set; }
        public int? CityId { get; set; }
        public int? StreetId { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }

        public virtual CityEntity City { get; set; }
        public virtual StreetEntity Street { get; set; }
        public virtual ICollection<OrderOnCableTVEntity> OrderOnCableTvs { get; set; }
        public virtual ICollection<SubscriberRelationshipEntity> SubscriberRelationships { get; set; }
    }
}
