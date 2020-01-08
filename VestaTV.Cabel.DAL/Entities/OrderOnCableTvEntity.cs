using System;

namespace VestaTV.Cabel.DAL.Entities
{
    internal partial class OrderOnCableTVEntity
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

        public virtual CableTvProblemEntity CableTvproblem { get; set; }
        public virtual MasterEntity Master { get; set; }
        public virtual SubscriberEntity Subscriber { get; set; }
    }
}
