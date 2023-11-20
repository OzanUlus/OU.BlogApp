using Microsoft.EntityFrameworkCore;
using OU.BlogApp.DAL.Abstract;
using OU.BlogApp.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.DAL.Uow.Abstract
{
    public interface IUow
    {
        void SaveChanges();
        public IRepository<T> GetRepository<T>() where T : class, IEntity;
    }
}
