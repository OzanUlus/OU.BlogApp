using Microsoft.AspNetCore.Identity;
using OU.BlogApp.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.Entity.Entities
{
    public class AppUser : IdentityUser<string>, IEntity
    {
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string? LastLogin { get; set; }
        public bool isBanned { get; set; } = false;
    }
}
