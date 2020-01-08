using System;

namespace VestaTV.Cabel.Core.Models
{
    public partial class ActionHistoryByUser
    {
        public int Id { get; set; }
        public DateTime DateOfAction { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
