﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore2.Models.Repositories
{
   public interface IBookStoreRepositories<TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);

        void Add(TEntity entity);
        void Update(int id,TEntity entity);
        void Delete(int id);
    }
}
