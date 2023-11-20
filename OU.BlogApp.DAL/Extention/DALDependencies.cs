using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OU.BlogApp.DAL.Context;
using OU.BlogApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.DAL.Extention
{
    public static class DALDependencies
    {
        public static void AddDALDependencies(this IServiceCollection services, string connectionStrin)
        {
            //dbcontext kayıt
            services.AddDbContext<AppDbContex>(x =>
            {
                x.UseSqlServer(connectionStrin);

            });


           
        }
    }
}
