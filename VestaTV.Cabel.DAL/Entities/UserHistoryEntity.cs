using System;

namespace VestaTV.Cabel.DAL.Entities
{
    internal partial class UserHistoryEntity
    {
        public int Id { get; set; }
        public DateTime DateOfAction { get; set; }
        public int UserId { get; set; }

        public virtual UserEntity User { get; set; }
    }
}
