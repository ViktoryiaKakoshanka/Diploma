using System;
using VestaTV.Cabel.DAL.Entities;

namespace VestaTV.Cabel.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<MasterEntity> Masters { get; }
        IGenericRepository<CableTvProblemEntity> CableTVProblems { get; }
        IGenericRepository<OrderOnCableTVEntity> OrdersOnCableTV { get; }
        IGenericRepository<OrderRepairAndRestructionEntity> OrdersRepairAndRestruction { get; }

        IGenericRepository<CityEntity> Cities { get; }
        IGenericRepository<StreetEntity> Streets { get; }

        IGenericRepository<SubscriberEntity> Subscribers { get; }
        IGenericRepository<SubscriberRelationshipEntity> SubscriberRelationships { get; }

        IGenericRepository<UserEntity> Users { get; }
        IGenericRepository<UserHistoryEntity> UserActionHistory { get; }

        void Save();
    }
}
