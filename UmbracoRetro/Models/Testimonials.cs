using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoRetro.Models
{
    public class Testimonials
    {
        public string Title { get; set; }
        public string Introduction { get; set; }
        public List<Testimonial> Testimonialslist { get; set; }
        public bool HasTestimonials { get { return Testimonialslist != null && Testimonialslist.Count > 0; } }
        public string ColumnClass
        {
            get
            {
                switch (Testimonialslist.Count)
                {
                    case 2:
                        return "col-md-6";
                    case 3:
                        return "col-md-4";
                    case 4:
                        return "col-md-3";
                    default:
                        return "col-md-12";
                }
            }
        } 


        public Testimonials(string title, string introducion)
        {
            Title = title;
            Introduction = introducion;
        }
    }
}