using AutoMapper;
using System;
using System.Collections.Generic;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cabel.DAL.Entities;
using VestaTV.Cabel.DAL.Extentions;
using VestaTV.Cabel.DAL.Interfaces;
using VestaTV.Cabel.DAL.Repositories;

namespace VestaTV.Cabel.DAL.WrappersByMapping
{
    internal class MasterRepositoryWrapper : IMasterRepositoryWrapper
    {
        private CableTVContext _context;
        private IGenericRepository<MasterEntity> _mastersDB;

        public MasterRepositoryWrapper(CableTVContext context)
        {
            _context = context;
            _mastersDB = new GenericRepository<MasterEntity>(_context, _context.Masters);
        }

        public void Create(Master model)
        {
            _mastersDB.Create(model.Map());
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Master FindById(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Master> Get(Func<Master, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Master> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Master item)
        {
            throw new NotImplementedException();
        }
    }
}
