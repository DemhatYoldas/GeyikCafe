using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeyikCafe.Entities
{
    public class Feature
    {
        public int FeautreId { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}