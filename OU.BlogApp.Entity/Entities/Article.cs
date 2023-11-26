using OU.BlogApp.Entity.Abstract;
using OU.BlogApp.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OU.BlogApp.Entity.Entities
{
    public class Article : BaseEntity
    {
      
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }

        #region Nagivation Properties
        public Category Category { get; set; }
        public Photo Photo { get; set; }
        public AppUser AppUser { get; set; }
        #endregion


        #region FK
        public string CategoryId { get; set; }
        public string PhotoId { get; set; }
        public string AppuserId { get; set; }
        #endregion



    }
}
