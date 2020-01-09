using System;
using System.Collections.Generic;
using System.Text;
using VestaTV.Cabel.Core.Models;

namespace VestaTV.Cabel.DAL.Interfaces
{
    public interface IDataAccess
    {
        Master GatMasterById(int id);
        IEnumerable<Master> GetMasters();
        IEnumerable<Master> GetMasters(Func<Master, bool> predicate);
        void AddNewMaster(Master master);
        void UpdateMaster(Master master);
        void FireMaster(int id);
    }
}
