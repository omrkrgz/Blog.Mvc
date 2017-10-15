using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer
{
   public class BlogContext:DbContext
    {
        public BlogContext()
            : base("name=BLOGMVC")
        {
        }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<Liked> Likes { get; set; }
        public virtual DbSet<BlogUser> BlogUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}
