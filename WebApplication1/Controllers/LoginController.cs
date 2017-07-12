using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Dal;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            User test = new Models.User
            {
                UserName = "test",
                UserPassword = "55555"
            };
            return View(test);
        }

        public ActionResult Auth(User user_credentials)
        {
            User actual_user = CheckUser(user_credentials);

            // The user does not exist or bad information given.
            if (actual_user.Equals(user_credentials))
            {
                ViewBag.errorMessage = "הכניסה נכשלה, אנא בדוק את שם המשתמש והססמא ונסה שנית";
                return View("Login", actual_user);
            }

            ViewBag.errorMessage = "התחברת בהצלחה";
            return RedirectToRoute("HomeAfterLogin", actual_user);
        }

        // Finds a user with the given credentials.
        // Returns the full user data from the db on success, or the given user credentials on failure.
        private User CheckUser(User user)
        {
            DataLayer dal = new DataLayer();

            if (ModelState.IsValid)
            {
                //todo: check if user == user and password=password on server side and on browser side
                // goto homepage
                List<User> userOk = (from u in dal.Users
                                     where (u.UserName == user.UserName) && (u.UserPassword == user.UserPassword) select u).ToList<User>();
                if (userOk.Count == 1)
                {
                    return userOk[0];
                    // user is logged in
                    //todo: right wing menu should now be avalible and reffer the user to HomeScreen
                }
            }
            return user;
        }
    }
}