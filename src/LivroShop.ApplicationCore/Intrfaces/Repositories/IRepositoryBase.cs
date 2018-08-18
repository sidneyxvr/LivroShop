using System;
using System.Collections.Generic;
using System.Text;

namespace LivroShop.ApplicationCore.Intrfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
