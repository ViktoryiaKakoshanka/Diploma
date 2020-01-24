using System.Collections.Generic;

namespace VestaTV.Cabel.Core.Models
{
    public partial class Master
    {
        public Master()
        {
            Cities = new HashSet<City>();
            OrderOnCableTvs = new HashSet<OrderOnCableTV>();
            OrderRepairAndRestructionsMasterPerformer = new HashSet<OrderRepairAndRestruction>();
            OrderRepairAndRestructionsResponsibleMaster = new HashSet<OrderRepairAndRestruction>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string WorkPhone { get; set; }
        public string SecondWorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string SecondHomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string SecondMobilePhone { get; set; }
        public bool Brigade { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<OrderOnCableTV> OrderOnCableTvs { get; set; }
        public virtual ICollection<OrderRepairAndRestruction> OrderRepairAndRestructionsMasterPerformer { get; set; }
        public virtual ICollection<OrderRepairAndRestruction> OrderRepairAndRestructionsResponsibleMaster { get; set; }
    }
}
