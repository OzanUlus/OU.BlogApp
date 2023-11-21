using Microsoft.AspNetCore.Identity;
using OU.BlogApp.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.Entity.Entities
{
    public class AppRole : IdentityRole<string>,IEntity
    {
    }
}
