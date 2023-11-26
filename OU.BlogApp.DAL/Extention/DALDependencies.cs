using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OU.BlogApp.DAL.Context;
using OU.BlogApp.DAL.IdendityConfigurations;
using OU.BlogApp.DAL.Uow.Abstract;
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
        public static void AddDALDependencies(this IServiceCollection services, string connectionString)
        {
            //dbcontext kayıt
            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer(connectionString);

            });

            services.AddIdentity<AppUser, AppRole>();

            

            //services.AddIdentityCore<AppUser>(option =>
            //{ 
            //    option.User.RequireUniqueEmail = true;
            //    option.SignIn.RequireConfirmedEmail = false; //ileride true
            //    option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromHours(1);
            //    option.Lockout.MaxFailedAccessAttempts = 3;


            //    option.Password.RequireNonAlphanumeric = false;
            //    option.Password.RequireLowercase = false;
            //    option.Password.RequireUppercase = false;
            //    option.Password.RequireDigit = true;
            //    option.Password.RequiredLength = 6;

            //}

            //).AddRoleManager<RoleManager<AppRole>>()
            //.AddPasswordValidator<CustomPasswordValidator>()
            //.AddUserValidator<CustomUserValidator>()
            //.AddEntityFrameworkStores<AppDbContext>();



            



        }
    }
}
