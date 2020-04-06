using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoRetro.Models
{
    public class Service
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Service(string title, string subtitle, string category, string description)
        {
            Title = title;
            Subtitle = subtitle;
            Category = category;
            Description = description;
        }
    }
}