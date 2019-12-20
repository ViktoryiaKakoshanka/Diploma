using System;
using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    public partial class Subscriber
    {
        public Subscriber()
        {
            OrderOnCableTvs = new HashSet<OrderOnCableTV>();
            SubscriberRelationships = new HashSet<SubscriberRelationship>();
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
        public int RelationshipType { get; set; }
        public int? CityId { get; set; }
        public int? StreetId { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }

        public virtual City City { get; set; }
        public virtual Street Street { get; set; }
        public virtual ICollection<OrderOnCableTV> OrderOnCableTvs { get; set; }
        public virtual ICollection<SubscriberRelationship> SubscriberRelationships { get; set; }
    }
}
