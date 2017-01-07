using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreSample.Models;
using Dapper;

namespace StoreSample.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Shrek!" };
            // return View(movie);

            return RedirectToAction("Index","Home", new {page = 1, sortby ="Name" });
        }

        public ActionResult Edit(int id)
        {
            
            return Content("id="+ id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortby = "Name")
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "Name";

            return Content(String.Format("PageIndex ={0}&SorrtBy={1}", pageIndex,sortby));

        }


    }
}