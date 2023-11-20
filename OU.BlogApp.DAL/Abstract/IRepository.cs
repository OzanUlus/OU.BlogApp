using OU.BlogApp.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.DAL.Abstract
{
    public interface IRepository<T> where T :class , IEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetQueryable();
        ICollection<T> GetAll(Expression<Func<T,bool>>filter);
        T? GetById(int id);
        ICollection<T> GetAll();
    }
}
