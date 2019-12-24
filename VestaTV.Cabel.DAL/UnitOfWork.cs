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

        private IGenericRepository<Master> _masters;
        private IGenericRepository<CableTvProblem> _cableTVProblems;
        private IGenericRepository<OrderOnCableTV> _orderOnCableTV;
        private IGenericRepository<OrderRepairAndRestruction> _orderRepairAndRestruction;
        private IGenericRepository<City> _cities;
        private IGenericRepository<Street> _streets;
        private IGenericRepository<Subscriber> _subscribers;
        private IGenericRepository<SubscriberRelationship> _subscriberrelationships;
        private IGenericRepository<User> _user;
        private IGenericRepository<UserHistory> _userActionHistory;

        public IGenericRepository<Master> Masters
        {
            get => _masters ?? (_masters = new GenericRepository<Master>(_db, _db.Masters));
        }

        public IGenericRepository<CableTvProblem> CableTVProblems
        {
            get => _cableTVProblems ??
                   (_cableTVProblems = new GenericRepository<CableTvProblem>(_db, _db.CableTvproblems));
        }

        public IGenericRepository<OrderOnCableTV> OrdersOnCableTV
        {
            get => _orderOnCableTV ??
                   (_orderOnCableTV = new GenericRepository<OrderOnCableTV>(_db, _db.OrderOnCableTvs));
        }

        public IGenericRepository<OrderRepairAndRestruction> OrdersRepairAndRestruction
        {
            get => _orderRepairAndRestruction ?? (_orderRepairAndRestruction = new GenericRepository<OrderRepairAndRestruction>(_db, _db.OrderRepairAndRestructions));
        }

        public IGenericRepository<City> Cities
        {
            get => _cities ?? (_cities = new GenericRepository<City>(_db, _db.Cities));
        }

        public IGenericRepository<Street> Streets
        {
            get => _streets ?? (_streets = new GenericRepository<Street>(_db, _db.Streets));
        }

        public IGenericRepository<Subscriber> Subscribers
        {
            get => _subscribers ?? (_subscribers = new GenericRepository<Subscriber>(_db, _db.Subscribers));
        }

        public IGenericRepository<SubscriberRelationship> SubscriberRelationships
        {
            get => _subscriberrelationships ?? (_subscriberrelationships =
                       new GenericRepository<SubscriberRelationship>(_db, _db.SubscriberRelationships));
        }

        public IGenericRepository<User> Users
        {
            get => _user ?? (_user = new GenericRepository<User>(_db, _db.Users));
        }

        public IGenericRepository<UserHistory> UserActionHistory
        {
            get => _userActionHistory ?? (_userActionHistory = new GenericRepository<UserHistory>(_db, _db.UserActions));
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
