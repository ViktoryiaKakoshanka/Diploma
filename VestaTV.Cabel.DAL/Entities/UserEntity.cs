using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Entities
{
    internal partial class UserEntity
    {
        public UserEntity()
        {
            OrderRepairAndRestructions = new HashSet<OrderRepairAndRestructionEntity>();
            UserHistory = new HashSet<UserHistoryEntity>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public byte AdminRole { get; set; }

        public virtual ICollection<OrderRepairAndRestructionEntity> OrderRepairAndRestructions { get; set; }
        public virtual ICollection<UserHistoryEntity> UserHistory { get; set; }
    }
}
