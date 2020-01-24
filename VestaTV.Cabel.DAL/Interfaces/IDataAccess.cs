using System;
using System.Collections.Generic;
using System.Text;
using VestaTV.Cabel.Core.Models;

namespace VestaTV.Cabel.DAL.Interfaces
{
    public interface IDataAccess
    {

        User GatUserById(int id);
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsers(Func<User, bool> predicate);
        void AddNewUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);

        Master GatMasterById(int id);
        IEnumerable<Master> GetMasters();
        IEnumerable<Master> GetMasters(Func<Master, bool> predicate);
        void AddNewMaster(Master master);
        void UpdateMaster(Master master);
        void FireMaster(int id);
    }
}
