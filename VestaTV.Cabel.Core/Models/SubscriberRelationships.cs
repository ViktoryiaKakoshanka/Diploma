using System;

namespace VestaTV.Cabel.Core.Models
{
    public partial class HistoryOfRelationship
    {
        public int Id { get; set; }
        public DateTime RelationshipDate { get; set; }
        public int SubscriberId { get; set; }
        public RelationshipType RelationshipType { get; set; }

        public virtual Subscriber Subscriber { get; set; }
    }
}
