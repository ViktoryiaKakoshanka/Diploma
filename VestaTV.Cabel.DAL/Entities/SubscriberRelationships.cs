using System;
using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    public partial class SubscriberRelationship
    {
        public int Id { get; set; }
        public DateTime RelationshipDate { get; set; }
        public int SubscriberId { get; set; }
        public int RelationshipType { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}
