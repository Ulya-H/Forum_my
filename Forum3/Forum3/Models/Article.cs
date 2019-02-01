using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum3.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string Tags { get; set; }

        public DateTime PublishDate { get; set; }

        public int ViewsCount { get; set; }

        public string Image { get; set; }

      //  public virtual Category Category { get; set; }

        // public virtual ICollection<Question> Questions { get; set; }
    }
}