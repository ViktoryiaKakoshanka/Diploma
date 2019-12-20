using System;
using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    public partial class Street
    {
        public Street()
        {
            OrderRepairAndRestructions = new HashSet<OrderRepairAndRestruction>();
            Subscribers = new HashSet<Subscriber>();
        }

        public int Id { get; set; }
        public string StreetName { get; set; }
        public int StreetTypes { get; set; }
        public int? CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<OrderRepairAndRestruction> OrderRepairAndRestructions { get; set; }
        public virtual ICollection<Subscriber> Subscribers { get; set; }
    }
}
