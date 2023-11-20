using OU.BlogApp.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.Entity.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        
        public string CreatedBy { get ; set ; }
        public string UpdateddBy { get ; set ; }
        public string DeletedtedBy { get ; set ; }
        public DateTime CreatedDate { get ; set ; } = DateTime.Now;
        public DateTime UpdatedDate { get; set ; }
        public DateTime DeletedDate { get; set; }
        public bool IsActive { get; set; }=true;
    }
}
