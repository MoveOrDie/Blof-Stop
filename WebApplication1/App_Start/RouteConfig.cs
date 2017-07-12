using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Main_Page",
                url: "",
                defaults: new { controller = "First", action = "Index", id = UrlParameter.Optional }
               
            );

            routes.MapRoute(
                name: "Main_Page2",
                url: "First/Index",
                defaults: new { controller = "First", action = "Index", id = UrlParameter.Optional }
            );
                        routes.MapRoute(
                name: "Main_Page3",
                url: "Index",
                defaults: new { controller = "First", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Sign_Up_Now",
                url: "SignUpNow",
                defaults: new { controller = "SignUp", action = "SignUp", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Sign_Up_Success",
                url: "SignUpSuccess",
                defaults: new { controller = "SignUp", action = "SignUpSuccess", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Submit",
                url: "Submit",
                defaults: new { controller = "SignUp", action = "Submit", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "AddInvoiceN1",
                url: "AddInvoiceN1",
                defaults: new { controller = "AddInvoice", action = "AddInvoiceN1", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "AddInvoiceN1_1",
                url: "AddInvoice/AddInvoiceN1",
                defaults: new { controller = "AddInvoice", action = "AddInvoiceN1", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "LoginScreen",
                url: "Login/Login",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "LoginScreenN2",
                url: "Login",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "HomeAfterLogin",
                url: "Home",
                defaults: new { controller = "HomeAfterLogin", action = "Home", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "HomeAfterLogin2",
                url: "HomeAfterLogin/Home",
                defaults: new { controller = "HomeAfterLogin", action = "Home", id = UrlParameter.Optional }
            );
        }
    }
}
