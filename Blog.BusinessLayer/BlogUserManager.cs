using Blog.Entity;
using Blog.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BusinessLayer
{
  public class BlogUserManager
    {
        Repository<BlogUser> repo_user = new Repository<BlogUser>();

      public BlogUser RegisterUser(RegisterViewModel data)
        {

           
            //repo_user.Insert(new BlogUser
            //{

            //    Name = data.Name,
            //    Surname = data.Surname,
            //    Username = data.Username,
            //    Password = data.Password,
            //    Email = data.Email,
            //    CreatedOn = DateTime.Now,
            //    ModifiedOn = DateTime.Now,
            //    ModifiedUsername = "system",
            //    IsActive = false,
            //    GuidActive = new Guid(),
            //    IsAdmin = false

            //});

            BlogUser newUser = new BlogUser()
            {
                Name = data.Name,
                Surname = data.Surname,
                Username = data.Username,
                Password = data.Password,
                Email = data.Email,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                ModifiedUsername = "system",
                IsActive = false,
                GuidActive = new Guid(),
                IsAdmin = false

            };
            repo_user.Insert(newUser);
            return newUser;
        }
    }
}
