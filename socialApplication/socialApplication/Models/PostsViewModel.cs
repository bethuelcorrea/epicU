using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace socialApplication.Models
{
    public class PostsViewModel
    {
        public int PostId { get; set; }
        public int MemberId { get; set; }
        public System.DateTime PostDate { get; set; }
        public string Comment { get; set; }
        public string VideoUrl { get; set; }
    }
}