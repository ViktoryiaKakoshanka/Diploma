using System.Collections.Generic;

namespace VestaTV.Cabel.Core.Models
{
    public partial class User
    {
        public User()
        {
            ActionHistoryByUser = new HashSet<ActionHistoryByUser>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public byte AdminRole { get; set; }

        public virtual ICollection<ActionHistoryByUser> ActionHistoryByUser { get; set; }
    }
}
