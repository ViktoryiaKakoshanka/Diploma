﻿using System;
using System.Collections.Generic;

namespace VestaTV.Cabel.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        TEntity FindById(int? id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        void Update(TEntity item);
        void Delete(int id);
    }
}