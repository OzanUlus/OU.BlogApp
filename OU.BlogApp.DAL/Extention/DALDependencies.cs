﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OU.BlogApp.DAL.Context;
using OU.BlogApp.DAL.IdendityConfigurations;
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

            services.AddIdentityCore<AppUser>(option =>
            { 
                option.User.RequireUniqueEmail = true;
                option.SignIn.RequireConfirmedEmail = true;
                option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromHours(1);
                option.Lockout.MaxFailedAccessAttempts = 3;


                option.Password.RequireNonAlphanumeric = false;
                option.Password.RequireLowercase = true;
                option.Password.RequireUppercase = true;
                option.Password.RequireDigit = true;
                option.Password.RequiredLength = 6;

            }

            ).AddPasswordValidator<CustomPasswordValidator>()
            .AddUserValidator<CustomUserValidator>()
            .AddEntityFrameworkStores<AppDbContex>();
            


           
        }
    }
}
