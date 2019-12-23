using System;

namespace VestaTV.Cabel.DAL.Entities
{
    public partial class UserHistory
    {
        public int Id { get; set; }
        public DateTime DateOfAction { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
