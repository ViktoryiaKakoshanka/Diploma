using System;
using System.Collections.Generic;
using VestaTV.Cabel.Core.Models;

namespace VestaTV.Cable.BLL.Interfaces
{
    public interface IMasterServis
    {
        void AddNewMaster(Master master);
        Master GetMaster(int id);
        IEnumerable<Master> GetMasters();
        IEnumerable<Master> GetMasters(Func<Master, bool> predicate);
        void UpdateMaster(Master master);
        void FireMaster(int id);
    }
}