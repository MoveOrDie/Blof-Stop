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
            return View(new User());
        }

        public ActionResult Login(User u)
        {
            return View("PostLogin", TryLogin(u));
        }

        public ActionResult PostLogin(User u)
        {
            if (u == null)
            {
                return View("Login", new User());
            }

            return View(u);
        }

        // Takes user with 'UserName' and 'UserPassword'.
        // Returns the full user from the database if exists, or null otherwise.
        public User TryLogin(User u)
        {
            UserDal ud = new UserDal();
            List<User> users = (
                // For each user in ud.Users (call it user_from_db),
                // If it's username and password fields equals to those of u:
                // select: user_from_db.
                from user_from_db in ud.Users
                where user_from_db.UserName == u.UserName && user_from_db.UserPassword == u.UserPassword
                select user_from_db
            ).ToList<User>();

            //list<user> result;
            //for (int i = 0; i < ud.users.length; i++)
            //{
            //    user user_from_db = ud.users[i];
            //    if (user_from_db.username == u.username && u.userpassword == user_from_db.userpassword)
            //    {
            //        result.add(user_from_db);
            //    }

            if (users.Count() == 0)
            {
                return null;
            }
            return users[0];
        }
    }
}