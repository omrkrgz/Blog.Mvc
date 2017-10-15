
using Blog.BusinessLayer;
using Blog.Entity;
using Blog.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Blog.Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ContentManager cmn = new ContentManager();
            return View(cmn.GetAllContent());

        }

        public ActionResult GetByCategory(int? id)
        {
            CategoryManager cm = new CategoryManager();
            Category cat = cm.GetByCategory(id.Value);


            return View("Index", cat.Contents.OrderByDescending(x => x.ModifiedOn).ToList());
        }

        public ActionResult RegisterTrue()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            Repository<BlogUser> repo_user = new Repository<BlogUser>();
            BlogUserManager blgusrmngr = new BlogUserManager();
            BlogUser controlUsername = repo_user.Find(x => x.Username == model.Username);
            BlogUser controlMail = repo_user.Find(x => x.Email == model.Email);

            if (ModelState.IsValid)
            {
                if (controlUsername != null)
                {
                    ModelState.AddModelError("", $"'{model.Username}' kullanıcı adı kullanılıyor");
                    return View(model);
                }

                if (controlMail != null)
                {
                    ModelState.AddModelError("", $"'{model.Email}' E-posta kullanılıyor");
                    return View(model);
                }
                
                blgusrmngr.RegisterUser(model);
                return RedirectToAction("RegisterTrue");
            }

            return View(model);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel Model)
        {
            return View();
        }

        public ActionResult Logout()
        {
            return View();
        }

    }

}
