using AuthenticationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthenticationMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login       
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User u)
        {
            socialnetworkEntities OE = new socialnetworkEntities();
            var count = OE.Users.Where(x =>x.Email == u.Email && x.Password == u.Password).Count();
            if (count == 0)
            {
                ViewBag.Msg = "Invalid User";
                return View();
            }
            else
            {
                FormsAuthentication.SetAuthCookie(u.Email, false);                               
                return RedirectToAction("Contact","Home");

            }
            
        }
    }
}