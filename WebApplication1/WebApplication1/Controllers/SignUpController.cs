using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Dal;

namespace WebApplication1.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult SignUp()
        {
            return View(new User());
        }
        public ActionResult SignUpSuccess()
        {
           return View();
        }
        public ActionResult submit(User user)
        {
            user.UserBirthDate = new DateTime(int.Parse(Request.Form["DOBYear"]), int.Parse(Request.Form["DOBMonth"]), int.Parse(Request.Form["DOBDay"]));
            user.UserGender = Request.Form["gender"];
            user.UserScore = 0;
            user.UserRole = "משתמש רשום";
            user.UserPassword = Request.Form["UserPassword"];
            if (ModelState.IsValid)
            {
                Console.WriteLine(user.ToString());
                UserDal dal = new UserDal();
                dal.Users.Add(user);
                dal.SaveChanges();
                return View("SignUpSuccess");
            }
            else
            {
                return View("SignUp",user);
            }
        }
    }
}


//User user = new User
//{
//    //User ID - increasing number automatic by server
//    UserFirstName = Request.Form["UserFirstName"],
//    UserLastName = Request.Form["UserLastName"],
//    UserBirthDate = new DateTime(int.Parse(Request.Form["DOBYear"]), int.Parse(Request.Form["DOBMonth"]), int.Parse(Request.Form["DOBDay"])),
//    UserGender = Request.Form["gender"],

//    UserScore = 0,
//    UserRole = "משתמש חדש",
//    UserName = Request.Form["Username"],
//    UserPassword = Request.Form["Userpassword"],
//    UserEmail = Request.Form["UserEmail"],
//};