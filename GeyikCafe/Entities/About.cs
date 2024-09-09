using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeyikCafe.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public string AboutBigImageUrl { get; set; }
        public string AboutBigImageOneUrl { get; set; }
        public string AboutBigImageTwoUrl { get; set; }
        public string AboutBigImagethirdUrl { get; set; }
        public string AboutBigImagefourthUrl { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Experience { get; set; }
        public string MasterChefs { get; set; }
    }
}