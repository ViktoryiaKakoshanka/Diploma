namespace VestaTV.Cabel.Core.Models
{
    public class Address
    {
        public int? CityId { get; set; }
        public int? StreetId { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }

        public virtual City City { get; set; }
        public virtual Street Street { get; set; }
    }
}
