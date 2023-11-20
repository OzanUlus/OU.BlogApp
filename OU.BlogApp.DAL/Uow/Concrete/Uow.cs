using Microsoft.EntityFrameworkCore;
using OU.BlogApp.DAL.Abstract;
using OU.BlogApp.DAL.Repository;
using OU.BlogApp.DAL.Uow.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.DAL.Uow.Concrete
{
    public class Uow : IUow
    {
        private readonly DbContext _dbContext;
        public Uow(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        IRepository<T> IUow.GetRepository<T>()
        {
            return new GenericRepository<T>(_dbContext);
        }
    }
}
