using LivroShop.ApplicationCore.Intrfaces.Repositories;
using LivroShop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivroShop.Infrastructure.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {

        protected readonly LivroShopContext _context;

        public RepositoryBase(LivroShopContext context)
        {
            _context = context;
        }

        public void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _context.Set<TEntity>().Update(obj);
            _context.SaveChanges();
        }
    }
}
