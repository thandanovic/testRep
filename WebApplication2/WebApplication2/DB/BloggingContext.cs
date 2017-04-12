using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.DB
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public void InitDB()
        {
            var blog = new Blog { Name = "TestBlog" };
            this.Blogs.Add(blog);
            this.SaveChanges();
        }
    }

    
}