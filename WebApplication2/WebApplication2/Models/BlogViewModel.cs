using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BlogViewModel
    {
        public int BlogId { get; set; }

        public string BlogName
        {
            get
            {
                return BlogId.ToString() ;// + " " + Name;
            } 
        }

        public virtual List<Post> Posts { get; set; }
    }
}