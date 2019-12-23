using System;

namespace VestaTV.Cabel.DAL.Entities
{
    public partial class OrderRepairAndRestruction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? ResponsibleMasterId { get; set; }
        public int? MasterPerformerId { get; set; }
        public int? CityId { get; set; }
        public int? StreetId { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string Problem { get; set; }
        public string Remark { get; set; }
        public byte Status { get; set; }
        public DateTime DateOfExecution { get; set; }
        public DateTime DateOfCallback { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime EstimatedCompletionDate { get; set; }

        public virtual City City { get; set; }
        public virtual Master MasterPerformer { get; set; }
        public virtual Master ResponsibleMaster { get; set; }
        public virtual Street Street { get; set; }
        public virtual User User { get; set; }
    }
}
