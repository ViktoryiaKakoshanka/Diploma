using System;

namespace VestaTV.Cabel.Core.Models
{
    public partial class OrderRepairAndRestruction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? ResponsibleMasterId { get; set; }
        public int? MasterPerformerId { get; set; }
        public Address Address { get; set; }
        public string Problem { get; set; }
        public string Remark { get; set; }
        public byte Status { get; set; }
        public DateTime DateOfExecution { get; set; }
        public DateTime DateOfCallback { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime EstimatedCompletionDate { get; set; }

        public virtual Master MasterPerformer { get; set; }
        public virtual Master ResponsibleMaster { get; set; }
        public virtual User User { get; set; }
    }
}
