using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum3.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

       // public virtual ICollection<Article> Articles { get; set; }

       

    }
}