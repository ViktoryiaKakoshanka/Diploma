using System;
using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    public partial class MasterCities
    {
        public int MasterId { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual Master Master { get; set; }
    }
}
