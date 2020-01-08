using System.Collections.Generic;

namespace VestaTV.Cabel.Core.Models
{
    public partial class Street
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public int StreetTypes { get; set; }
        public int? CityId { get; set; }

        public virtual City City { get; set; }
    }
}
