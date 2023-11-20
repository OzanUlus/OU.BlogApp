using Microsoft.EntityFrameworkCore;
using OU.BlogApp.DAL.Abstract;
using OU.BlogApp.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.DAL.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbContext _dbContext;
        public GenericRepository(DbContext dbContext)
        {
          _dbContext = dbContext;
        }
        public void Add(T entity)
        {
           _dbContext.Set<T>().Add(entity);
            
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public ICollection<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return _dbContext.Set<T>().Where(filter).ToList();
        }

        public ICollection<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IQueryable<T> GetQueryable()
        {
            return _dbContext.Set<T>().AsQueryable();
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }
    }
}
