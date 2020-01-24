using System.Collections.Generic;

namespace VestaTV.Cabel.Core.Models
{
    public partial class City
    {
        public City()
        {
            Masters = new HashSet<Master>();
            Streets = new HashSet<Street>();
        }

        public int Id { get; set; }
        public string ShortNameOfCityType { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Master> Masters { get; set; }
        public virtual ICollection<Street> Streets { get; set; }
    }
}
