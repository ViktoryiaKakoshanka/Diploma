using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    internal partial class MasterEntity
    {
        public MasterEntity()
        {
            Cities = new HashSet<MasterCityEntity>();
            OrderOnCableTvs = new HashSet<OrderOnCableTVEntity>();
            OrderRepairAndRestructionsMasterPerformer = new HashSet<OrderRepairAndRestructionEntity>();
            OrderRepairAndRestructionsResponsibleMaster = new HashSet<OrderRepairAndRestructionEntity>();
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

        public virtual ICollection<MasterCityEntity> Cities { get; set; }
        public virtual ICollection<OrderOnCableTVEntity> OrderOnCableTvs { get; set; }
        public virtual ICollection<OrderRepairAndRestructionEntity> OrderRepairAndRestructionsMasterPerformer { get; set; }
        public virtual ICollection<OrderRepairAndRestructionEntity> OrderRepairAndRestructionsResponsibleMaster { get; set; }
    }
}
