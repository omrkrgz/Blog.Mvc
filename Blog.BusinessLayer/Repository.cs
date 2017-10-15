using Blog.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BusinessLayer
{
   public class Repository<T> where T : class
    {
        BlogContext db = new BlogContext();
        
        public List<T> List()
        {
           return db.Set<T>().ToList();
        }

        public int Save()  
        {
            return db.SaveChanges();
        }

        public int Insert(T obj)
        {
           db.Set<T>().Add(obj);
           return Save();
        }

        public int Update(T obj)
        {
            return Save();
        }

        public int Delete(T obj)
        {
            db.Set<T>().Remove(obj);
            return Save();
        }

        public T Find(Expression<Func<T, bool >> where)
        {
           return db.Set<T>().FirstOrDefault(where);
        }
    }
}
