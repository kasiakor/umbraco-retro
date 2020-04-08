using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoRetro.Library.Models
{
    public class LastBlogPosts
    {
        public string Title { get; set; }
        public string Introduction { get; set; }
        public LastBlogPosts(string title, string introduction)
        {
            Title = title;
            Introduction = introduction;
        }
    }
}

