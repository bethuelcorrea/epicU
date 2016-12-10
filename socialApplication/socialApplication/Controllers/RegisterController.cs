using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using socialApplication.Models;

namespace socialApplication.Controllers
{
    public class RegisterController : Controller
    {
        private EpicUEntities db = new EpicUEntities();

        // GET: Register
        public ActionResult Index()
        {
            var members = db.Members.Include(m => m.Friend);
            return View(members.ToList());
        }


        // GET: Register/Create
        public ActionResult Create()
        {
            ViewBag.MemberId = new SelectList(db.Friends, "FriendId", "FriendId");
            return View();
        }

        // POST: Register/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MemberId,FirstName,LastName,Email,Password")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Members.Add(member);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }

            ViewBag.MemberId = new SelectList(db.Friends, "FriendId", "FriendId", member.MemberId);
            return View(member);
        }   
       
        


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
