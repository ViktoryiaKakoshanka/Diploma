using System;

namespace VestaTV.Cabel.DAL.Entities
{
    internal partial class SubscriberRelationshipEntity
    {
        public int Id { get; set; }
        public DateTime RelationshipDate { get; set; }
        public int SubscriberId { get; set; }
        public RelationshipTypeEntity RelationshipType { get; set; }

        public virtual SubscriberEntity Subscriber { get; set; }
    }
}
