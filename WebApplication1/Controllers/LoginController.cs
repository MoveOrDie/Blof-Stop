using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Dal;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            User u = new User();
            return View(u);
        }

        public ActionResult LoginSuccessful(User u)
        {
            // If u exists in db:
            //    return OK
            // else:
            //    return error

            UserDal ud = new UserDal();

            List<User> users = (
                from user_from_db in ud.Users
                where user_from_db.UserName == u.UserName && user_from_db.UserPassword == u.UserPassword
                select user_from_db
            ).ToList<User>();


        }
    }
}