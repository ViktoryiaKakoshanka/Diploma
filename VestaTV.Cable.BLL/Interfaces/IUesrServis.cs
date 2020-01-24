using System;
using System.Collections.Generic;
using VestaTV.Cabel.Core.Models;

namespace VestaTV.Cable.BLL.Interfaces
{
    public interface IUserServis
    {
        void AddNewUser(User user);
        User GetUser(int id);
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsers(Func<User, bool> predicate);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
