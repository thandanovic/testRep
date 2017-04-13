namespace WebApplication2.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.DB.BloggingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "testDB";
        }

        protected override void Seed(WebApplication2.DB.BloggingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var blogs = new List<Blog>
            {
                new Blog { Name = "Test1" },
                new Blog { Name = "Test2" },
                new Blog { Name = "Test3" },
                new Blog { Name = "Test4" },
                new Blog { Name = "Test5" }
            };
            blogs.ForEach(x => context.Blogs.AddOrUpdate(p => p.Name, x));
            context.SaveChanges();

            var posts = new List<Post>
            {
                new Post {Content = "Post1 Content", Title = "Post1", BlogId = blogs.Single(x=> x.Name =="Test1").BlogId },
                new Post {Content = "Post2 Content", Title = "Post2", BlogId = blogs.Single(x=> x.Name =="Test2").BlogId },
                new Post {Content = "Post3 Content", Title = "Post3", BlogId = blogs.Single(x=> x.Name =="Test3").BlogId },
                new Post {Content = "Post4 Content", Title = "Post4", BlogId = blogs.Single(x=> x.Name =="Test4").BlogId },
                new Post {Content = "Post5 Content", Title = "Post5", BlogId = blogs.Single(x=> x.Name =="Test5").BlogId }

            };
            posts.ForEach(x => context.Posts.AddOrUpdate(p => p.Title, x));
            context.SaveChanges();

            var users = new List<User>
            {
                new User { Email = "test1@gmail.com" },
                new User { Email = "test2@gmail.com" },
                new User { Email = "test3@gmail.com" }
            };
            users.ForEach(x => context.Users.AddOrUpdate(p => p.Email, x));
            context.SaveChanges();

            

        }
    }
}
