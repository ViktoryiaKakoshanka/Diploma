using System;
using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    public partial class City
    {
        public City()
        {
            MasterCities = new HashSet<MasterCities>();
            OrderRepairAndRestructions = new HashSet<OrderRepairAndRestruction>();
            Streets = new HashSet<Street>();
            Subscribers = new HashSet<Subscriber>();
        }

        public int Id { get; set; }
        public string ShortNameOfCityType { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<MasterCities> MasterCities { get; set; }
        public virtual ICollection<OrderRepairAndRestruction> OrderRepairAndRestructions { get; set; }
        public virtual ICollection<Street> Streets { get; set; }
        public virtual ICollection<Subscriber> Subscribers { get; set; }
    }
}
