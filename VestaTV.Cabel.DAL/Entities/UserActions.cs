using System;
using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    public partial class UserAction
    {
        public int Id { get; set; }
        public DateTime DateOfAction { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
