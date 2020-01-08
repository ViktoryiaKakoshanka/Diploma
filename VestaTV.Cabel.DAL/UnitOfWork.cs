using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using VestaTV.Cabel.DAL.Entities;
using VestaTV.Cabel.DAL.Interfaces;
using VestaTV.Cabel.DAL.Repositories;

namespace VestaTV.Cabel.DAL
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private bool _disposed;
        private static string _connectionString;
        private CableTVContext _db;

        private IGenericRepository<MasterEntity> _masters;
        private IGenericRepository<CableTvProblemEntity> _cableTVProblems;
        private IGenericRepository<OrderOnCableTVEntity> _orderOnCableTV;
        private IGenericRepository<OrderRepairAndRestructionEntity> _orderRepairAndRestruction;
        private IGenericRepository<CityEntity> _cities;
        private IGenericRepository<StreetEntity> _streets;
        private IGenericRepository<SubscriberEntity> _subscribers;
        private IGenericRepository<SubscriberRelationshipEntity> _subscriberrelationships;
        private IGenericRepository<UserEntity> _user;
        private IGenericRepository<UserHistoryEntity> _userActionHistory;

        public IGenericRepository<MasterEntity> Masters
        {
            get => _masters ?? (_masters = new GenericRepository<MasterEntity>(_db, _db.Masters));
        }

        public IGenericRepository<CableTvProblemEntity> CableTVProblems
        {
            get => _cableTVProblems ??
                   (_cableTVProblems = new GenericRepository<CableTvProblemEntity>(_db, _db.CableTvproblems));
        }

        public IGenericRepository<OrderOnCableTVEntity> OrdersOnCableTV
        {
            get => _orderOnCableTV ??
                   (_orderOnCableTV = new GenericRepository<OrderOnCableTVEntity>(_db, _db.OrderOnCableTvs));
        }

        public IGenericRepository<OrderRepairAndRestructionEntity> OrdersRepairAndRestruction
        {
            get => _orderRepairAndRestruction ?? (_orderRepairAndRestruction = new GenericRepository<OrderRepairAndRestructionEntity>(_db, _db.OrderRepairAndRestructions));
        }

        public IGenericRepository<CityEntity> Cities
        {
            get => _cities ?? (_cities = new GenericRepository<CityEntity>(_db, _db.Cities));
        }

        public IGenericRepository<StreetEntity> Streets
        {
            get => _streets ?? (_streets = new GenericRepository<StreetEntity>(_db, _db.Streets));
        }

        public IGenericRepository<SubscriberEntity> Subscribers
        {
            get => _subscribers ?? (_subscribers = new GenericRepository<SubscriberEntity>(_db, _db.Subscribers));
        }

        public IGenericRepository<SubscriberRelationshipEntity> SubscriberRelationships
        {
            get => _subscriberrelationships ?? (_subscriberrelationships =
                       new GenericRepository<SubscriberRelationshipEntity>(_db, _db.SubscriberRelationships));
        }

        public IGenericRepository<UserEntity> Users
        {
            get => _user ?? (_user = new GenericRepository<UserEntity>(_db, _db.Users));
        }

        public IGenericRepository<UserHistoryEntity> UserActionHistory
        {
            get => _userActionHistory ?? (_userActionHistory = new GenericRepository<UserHistoryEntity>(_db, _db.UserActions));
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public UnitOfWork()
        {
            _connectionString = GetConnectionString();

            var optionBuilder = new DbContextOptionsBuilder<CableTVContext>();
            var options = optionBuilder
                .UseSqlServer(_connectionString)
                .Options;

            _db = new CableTVContext(options);
        }

        private static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");

            var config = builder.Build();
            var stringConnection = config.GetConnectionString("DefaultConnection");

            return stringConnection;
        }
        
        private void Dispose(bool disposing)
        {
            if ( ! _disposed )
            {
                if(disposing)
                {
                    _db.Dispose();
                }
                _disposed = true;
            }

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
