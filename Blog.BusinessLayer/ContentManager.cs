using Blog.DataAccessLayer;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BusinessLayer
{
   public class ContentManager
    {
        BlogContext db = new BlogContext();

        public List<Content> GetAllContent()
        {
            return db.Contents.ToList();
        }
    }
}
