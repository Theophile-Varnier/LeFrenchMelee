using LeFrenchMelee.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace LeFrenchMelee.Data
{
    public abstract class AbstractDao<T> where T : Entity
    {
        protected readonly MeleeContext Context;

        protected DbSet<T> Table;

        public AbstractDao(MeleeContext context)
        {
            Context = context;
            Table = context.Set<T>();
        }

        public T Add(T entity)
        {
            Table.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public void Remove(T entity)
        {
            Table.Remove(entity);
            Context.SaveChanges();
        }

        public IEnumerable<T> GetAll(Func<T, bool> filtres, params Expression<Func<T, object>>[] dataLoadOptions)
        {
            IQueryable<T> res = Table;
            foreach(Expression<Func<T, object>> expr in dataLoadOptions)
            {
                res = res.Include(expr);
            }
            return res.Where(filtres).ToList();
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] dataLoadOptions)
        {
            return GetAll(obj => true, dataLoadOptions);
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }
    }
}
