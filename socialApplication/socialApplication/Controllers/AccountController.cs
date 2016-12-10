using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using socialApplication.Models;
using System.Web.Security;
using socialApplication.ViewModels;

namespace socialApplication.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Member User)
        {
            var db = new EpicUEntities();
            var member = db.Members.FirstOrDefault(x => x.Email == User.Email && x.Password == User.Password);
            if (member == null)
            {
                ViewBag.Msg = "Invalid User";
                return View();
            }
            else
            {
                var persistentCookie = true;
                var ticket = new FormsAuthenticationTicket(
                    1,
                    member.MemberId.ToString(),
                    DateTime.Now,
                    DateTime.Now.AddMinutes(30),
                    persistentCookie,
                    "your custom data"                  
                    
                    );

                var cookie = new HttpCookie(
                    FormsAuthentication.FormsCookieName,
                    FormsAuthentication.Encrypt(ticket))
                {
                    Path = FormsAuthentication.FormsCookiePath,
                    Expires = persistentCookie
                    ? ticket.Expiration
                    : DateTime.Now.AddDays(-1)
                };



                Response.Cookies.Add(cookie);

                //FormsAuthentication.SetAuthCookie(User.MemberId.ToString(), false);
                return RedirectToAction("Main", "Home");
                
            }
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Main", "Home");
        }

        public ActionResult Post()
        {
            EpicUEntities db = new EpicUEntities();
            var model = new Post()
            {
                MemberId = Convert.ToInt32(User.Identity.Name)
            };     
                

            return View(model);
        }


        [HttpPost]
        public ActionResult Post(Post post)
        {
            post.PostDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                EpicUEntities db = new EpicUEntities();
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("PersonalTimeLine", "Account");

            }


            return View();
        }
               


        public ActionResult PersonalTimeLine()
        {
            var model = new TimeLineViewModel();

            EpicUEntities db = new EpicUEntities();

            model.Posts = db.Posts.ToList();
            model.Likes = db.Likes.ToList();
            model.Members = db.Members.ToList();
            model.Unlikes = db.Unlikes.ToList();      
            

            return View(model);
                
        }

        public JsonResult LikePost(int id)
        {
                        
            
                EpicUEntities db = new EpicUEntities();
            var existingRecord = db.Likes.SingleOrDefault(c => c.MemberId == AppUser.Current.MemberId && c.PostId == id );

            if (existingRecord == null)
            {

                db.Likes.Add(new Like()
                {
                    MemberId = AppUser.Current.MemberId,
                    PostId = id,
                    IsLiked = true
                });
                db.SaveChanges();
            }
            else {
                if (existingRecord.IsLiked == false) {
                    existingRecord.IsLiked = true;
                    db.SaveChanges();


                }
            }
                      

            return Json(true);

        }


        public JsonResult UnLinkedPost(int id)
        {


            EpicUEntities db = new EpicUEntities();
            var existingRecord = db.Likes.SingleOrDefault(c => c.MemberId == AppUser.Current.MemberId && c.PostId == id);
            if (existingRecord == null)

            {

                db.Likes.Add(new Like()
                {
                    MemberId = AppUser.Current.MemberId,
                    PostId = id,
                    IsLiked = false
                });
                db.SaveChanges();
            }
            else {
                if (existingRecord.IsLiked == true)
                {
                    existingRecord.IsLiked = false;
                    db.SaveChanges();


                }
            }


            return Json(false);

        }






    }
}