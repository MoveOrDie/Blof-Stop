using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeAfterLoginController : Controller
    {
        // GET: HomeAfterLogin
        public ActionResult Home(User user)
        {
            return View(user);
        }
    }
}