using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeyikCafe.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string SocialName { get; set; }
        public string SocialUrl { get; set; }
        public string IconUrl { get; set; }
    }
}