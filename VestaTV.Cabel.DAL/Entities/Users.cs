using System;
using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    public partial class User
    {
        public User()
        {
            OrderRepairAndRestructions = new HashSet<OrderRepairAndRestruction>();
            UserActions = new HashSet<UserAction>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public byte AdminRole { get; set; }

        public virtual ICollection<OrderRepairAndRestruction> OrderRepairAndRestructions { get; set; }
        public virtual ICollection<UserAction> UserActions { get; set; }
    }
}
