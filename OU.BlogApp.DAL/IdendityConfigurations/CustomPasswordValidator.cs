using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Design.Internal;
using OU.BlogApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.DAL.IdendityConfigurations
{
    public class CustomPasswordValidator : IPasswordValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)
        {
            var errors = new List<IdentityError>();
            if (password!.ToLower().Contains(user.UserName!)) 
            {
                errors.Add(new() { Code = "2", Description = "şifre kullanıcı adı içremez" });
            
            }
            if (password!.ToLower().Contains("123456"))
            {
                errors.Add(new() { Code = "Password", Description = "şifre çok basit" });
            }
            if (errors.Any()) 
            {
              return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            
            }

            return Task.FromResult(IdentityResult.Success);
        }
    }
}
