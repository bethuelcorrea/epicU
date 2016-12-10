using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using socialApplication.Models;

namespace socialApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult Main()
        {
            EpicUEntities db = new EpicUEntities();
            
            List<object> mymodel = new List<object>();
            mymodel.Add(db.Posts.ToList());
            mymodel.Add(db.Likes.ToList());
            mymodel.Add(db.Unlikes.ToList());
            mymodel.Add(db.Members.ToList());
            return View(mymodel);
        }


    }
}