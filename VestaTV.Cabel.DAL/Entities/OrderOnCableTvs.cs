using System;
using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    public partial class OrderOnCableTV
    {
        public int Id { get; set; }
        public int SubscriberId { get; set; }
        public string UserLocation { get; set; }
        public string PhoneNumber { get; set; }
        public string Remark { get; set; }
        public int? CableTvproblemId { get; set; }
        public string NonStandardProblem { get; set; }
        public int? MasterId { get; set; }
        public byte OrderStatus { get; set; }
        public DateTime? ExecutionDate { get; set; }
        public DateTime? CallbackDate { get; set; }
        public bool IsCollectiveOrder { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EstimatedCompletionDate { get; set; }

        public virtual CableTvProblem CableTvproblem { get; set; }
        public virtual Master Master { get; set; }
        public virtual Subscriber Subscriber { get; set; }
    }
}
