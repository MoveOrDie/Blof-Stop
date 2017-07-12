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
            return View();
        }
        public ActionResult CheckUser(User user)
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
                    ViewBag.errorMessage = "התחברת בהצלחה";
                    return RedirectToRoute("HomeAfterLogin");
                    // user is logged in
                    //todo: right wing menu should now be avalible and reffer the user to HomeScreen
                }

            }
            else
            {
                ViewBag.errorMessage = "הכניסה נכשלה, אנא בדוק את שם המשתמש והססמא ונסה שנית";
                return View("Login", user);
                    
            }
            ViewBag.errorMessage = "הכניסה נכשלה, אנא בדוק את שם המשתמש והססמא ונסה שנית";
            return View("Login", user);

        }
    }
}