using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    public partial class CableTvProblem
    {
        public CableTvProblem()
        {
            OrderOnCableTvs = new HashSet<OrderOnCableTV>();
        }

        public int Id { get; set; }
        public string NameOfProblem { get; set; }

        public virtual ICollection<OrderOnCableTV> OrderOnCableTvs { get; set; }
    }
}
