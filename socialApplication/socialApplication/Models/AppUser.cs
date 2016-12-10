using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace socialApplication.Models
{
    public class AppUser
    {

        public static Member Current
        {
            get
            {
                // If we're not authenticated, stop here.
                var context = HttpContext.Current;
                if (!context.Request.IsAuthenticated) return null;

                // Get the items we've already created during this request.
                // If we already have this member saved, just use that.
                var items = context.Request.RequestContext.HttpContext.Items;
                if (items["AppUser"] != null) return (Member)items["AppUser"];

                // Get the member ID
                var id = Convert.ToInt32(context.User.Identity.Name);

                // Get the member and save them to the current request
                EpicUEntities db = new EpicUEntities();
                items["AppUser"] = db.Members.FirstOrDefault(m => m.MemberId == id);

                // Return the member from the items collection
                return (Member)items["AppUser"];
            }
        }

    }
}