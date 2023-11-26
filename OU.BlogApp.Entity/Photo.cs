using OU.BlogApp.Entity.Abstract;
using OU.BlogApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.Entity
{
    public class Photo:BaseEntity
    {
        
        public string Id { get; set; }
        public string PhotoPath { get; set; }
        public string PhotoType { get; set; }

        #region Navigation Properties
        
        #endregion

        public ICollection<Article> Articles { get; set; }
    }
}
