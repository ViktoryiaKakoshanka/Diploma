using System;
using System.Collections.Generic;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cabel.DAL.Extentions;
using VestaTV.Cabel.DAL.Interfaces;

namespace VestaTV.Cabel.DAL
{
    public class DataAccess : IDataAccess
    {
        private readonly IUnitOfWork _unitOfWork;

        public static IDataAccess Instance { get
            {
                return new DataAccess();
            }
        }

        private DataAccess()
        {
            _unitOfWork = new UnitOfWork();
        }

        public void AddNewMaster(Master master)
        {
            _unitOfWork.Masters.Create(master.Map());
            _unitOfWork.Save();
        }

        public void AddNewUser(User user)
        {
            _unitOfWork.Users.Create(user.Map());
            _unitOfWork.Save();
        }

        public void DeleteUser(int id)
        {
            _unitOfWork.Users.Delete(id);
            _unitOfWork.Save();
        }

        public void FireMaster(int id)
        {
            _unitOfWork.Masters.Delete(id);
            _unitOfWork.Save();
        }

        public Master GatMasterById(int id)
        {
            return _unitOfWork.Masters.FindById(id).Map();
        }

        public User GatUserById(int id)
        {
            return _unitOfWork.Users.FindById(id).Map();
        }

        public IEnumerable<Master> GetMasters()
        {
            return _unitOfWork.Masters.GetAll().Map();
        }

        public IEnumerable<Master> GetMasters(Func<Master, bool> predicate)
        {
            return _unitOfWork.Masters.Get(predicate.Map()).Map();
        }

        public IEnumerable<User> GetUsers()
        {
            return _unitOfWork.Users.GetAll().Map();
        }

        public IEnumerable<User> GetUsers(Func<User, bool> predicate)
        {
            return _unitOfWork.Users.Get(predicate.Map()).Map();
        }

        public void UpdateMaster(Master master)
        {
            _unitOfWork.Masters.Update(master.Map());
            _unitOfWork.Save();
        }

        public void UpdateUser(User user)
        {
            _unitOfWork.Users.Update(user.Map());
            _unitOfWork.Save();
        }
    }
}
