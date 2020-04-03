namespace UmbracoRetro.Models
{
    public class Testimonial
    {
        public string Quote { get; set; }
        public string Name { get; set; }

        public Testimonial(string quote, string name)
        {
            Quote = quote;
            Name = name;
        }
    }
}