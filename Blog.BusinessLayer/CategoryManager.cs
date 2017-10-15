using Blog.DataAccessLayer;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Blog.BusinessLayer
{
  public class CategoryManager
    {
        BlogContext db = new BlogContext();

        public List<Category> GetAllCategory()
        {
          return  db.Categories.ToList();
        }
        
       public Category GetByCategory(int id)
        {
            return db.Categories.Where(x => x.Id == id).FirstOrDefault();
        }
     

    }
}
