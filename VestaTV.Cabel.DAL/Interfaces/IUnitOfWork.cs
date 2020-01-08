using System;
using VestaTV.Cabel.Core.Models;

namespace VestaTV.Cabel.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //IGenericRepository<Master> Masters { get; }
        IMasterRepositoryWrapper Masters { get; }        
        //IGenericRepository<CableTvProblem> CableTVProblems { get; }
        //IGenericRepository<OrderOnCableTV> OrdersOnCableTV { get; }
        //IGenericRepository<OrderRepairAndRestruction> OrdersRepairAndRestruction { get; }

        //IGenericRepository<City> Cities { get; }
        //IGenericRepository<Street> Streets { get; }

        //IGenericRepository<Subscriber> Subscribers { get; }
        //IGenericRepository<HistoryOfRelationshipBySubscriber> HistoryOfRelationshipBySubscriber { get; }

        //IGenericRepository<User> Users { get; }
        //IGenericRepository<ActionHistoryByUser> UserActionHistory { get; }

        void Save();
    }
}
