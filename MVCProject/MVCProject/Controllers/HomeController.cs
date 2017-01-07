using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Post(string name,int age)
        {
           // string name = Request.QueryString["name"].ToString();
           // int age = int.Parse(Request.QueryString["age"].ToString());

            manzoorEntities db = new manzoorEntities();
            Mytable obj = new Mytable();
            obj.Name = name;
            obj.Age = age;            

            db.Mytables.Add(obj);
            db.SaveChanges();

            return Content("record have been submited");            
        }


        public ActionResult Read()
        {           
            return View();
        }

        public ActionResult ReadRecord(int Id)
        {
            manzoorEntities db = new manzoorEntities();
            var Name = db.Mytables.Where(p => p.Id == Id).FirstOrDefault().Name;
            var Age = db.Mytables.Where(p => p.Id == Id).FirstOrDefault().Age;

            ViewData["N"] = Name;
            ViewData["A"] = Age;

            return View("Read");
        }




    }
}