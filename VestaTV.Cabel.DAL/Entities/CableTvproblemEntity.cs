using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    internal partial class CableTvProblemEntity
    {
        public CableTvProblemEntity()
        {
            OrderOnCableTvs = new HashSet<OrderOnCableTVEntity>();
        }

        public int Id { get; set; }
        public string NameOfProblem { get; set; }

        public virtual ICollection<OrderOnCableTVEntity> OrderOnCableTvs { get; set; }
    }
}
