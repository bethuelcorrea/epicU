using socialApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace socialApplication.ViewModels
{
    public class TimeLineViewModel
    {
        public IEnumerable<Member> Members { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Unlike> Unlikes { get; set; }
        public IEnumerable<Like> Likes { get; set; }
    }
}