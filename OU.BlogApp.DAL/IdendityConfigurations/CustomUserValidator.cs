using Microsoft.AspNetCore.Identity;
using OU.BlogApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.DAL.IdendityConfigurations
{
    public class CustomUserValidator : IUserValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            var errors = new List<IdentityError>();
            if (char.IsDigit(user.UserName[0])) 
            {
                errors.Add(new IdentityError() { Code = "3", Description = "UserName rakam ile başlamyamaz" });
            
            }
            if (errors.Any()) 
            {
            
              return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }
            return Task.FromResult(IdentityResult.Success);
        }
    }
}
