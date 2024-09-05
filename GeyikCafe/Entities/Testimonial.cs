using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeyikCafe.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}