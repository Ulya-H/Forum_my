﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum3.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

       // public DateTime PublishDate { get; set; }

       // public int ViewsCount { get; set; }

       // public virtual Article Article { get; set; }
    }
}