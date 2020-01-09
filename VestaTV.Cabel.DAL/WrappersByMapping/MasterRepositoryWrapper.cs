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
            _mastersDB.Delete(id);
        }

        public Master FindById(int? id)
        {
            if (id == null)
                throw new ArgumentNullException();

            return _mastersDB.FindById(id).Map();
        }

        public IEnumerable<Master> Get(Func<Master, bool> predicate)
        {
            return _mastersDB.Get(predicate.Map()).Map();
        }

        public IEnumerable<Master> GetAll()
        {
            return _mastersDB.GetAll().Map();
        }

        public void Update(Master model)
        {
            _mastersDB.Update(model.Map());
        }
    }
}
