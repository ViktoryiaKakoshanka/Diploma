using System;
using System.Collections.Generic;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cabel.DAL;
using VestaTV.Cabel.DAL.Interfaces;
using VestaTV.Cable.BLL.Interfaces;

namespace VestaTV.Cable.BLL.Services
{
    public class MasterServis : IMasterServis
    {
        private readonly IDataAccess _dataAccess;

        public MasterServis()
        {
            _dataAccess = DataAccess.Instance;
        }

        public MasterServis(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddNewMaster(Master master)
        {
            _dataAccess.AddNewMaster(master);
        }

        public void FireMaster(int id)
        {
            _dataAccess.FireMaster(id);
        }

        public Master GetMaster(int id)
        {
            return _dataAccess.GatMasterById(id);
        }

        public IEnumerable<Master> GetMasters()
        {
            return _dataAccess.GetMasters();
        }

        public IEnumerable<Master> GetMasters(Func<Master, bool> predicate)
        {
            return _dataAccess.GetMasters(predicate);
        }
        
        public void UpdateMaster(Master master)
        {
            _dataAccess.UpdateMaster(master);
        }
    }
}
