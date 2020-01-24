using System;
using System.Collections.Generic;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cabel.DAL;
using VestaTV.Cabel.DAL.Interfaces;
using VestaTV.Cable.BLL.Interfaces;

namespace VestaTV.Cable.BLL.Services
{
    public class UserServis : IUserServis
    {
        private readonly IDataAccess _dataAccess;

        public UserServis()
        {
            _dataAccess = DataAccess.Instance;
        }

        public UserServis(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddNewUser(User user)
        {
            _dataAccess.AddNewUser(user);
        }

        public void DeleteUser(int id)
        {
            _dataAccess.DeleteUser(id);
        }

        public User GetUser(int id)
        {
           return _dataAccess.GatUserById(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _dataAccess.GetUsers();
        }

        public IEnumerable<User> GetUsers(Func<User, bool> predicate)
        {
            return _dataAccess.GetUsers(predicate);
        }

        public void UpdateUser(User user)
        {
            _dataAccess.UpdateUser(user);
        }
    }
}
