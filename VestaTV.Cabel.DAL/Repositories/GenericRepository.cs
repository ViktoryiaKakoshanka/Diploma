using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VestaTV.Cabel.DAL.Interfaces;

namespace VestaTV.Cabel.DAL.Repositories
{
    internal class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private CableTVContext _context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(CableTVContext context, DbSet<TEntity> dbSet)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = dbSet ?? throw new ArgumentNullException(nameof(dbSet));
        }

        public void Create(TEntity item)
        {
            if (item == null)
                throw new ArgumentNullException();

            _dbSet.Add(item);
        }

        public void Delete(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException();

            var entity = FindById(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public TEntity FindById(int id)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException();

            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException();

            return _dbSet.Where(predicate).ToList();
        }

        public void Update(TEntity item)
        {
            if (item == null)
                throw new ArgumentNullException();

            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
