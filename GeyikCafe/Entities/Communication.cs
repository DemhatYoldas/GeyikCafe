﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeyikCafe.Entities
{
    public class Communication
    {
        public int CommunicationId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string TechEmail { get; set; }
        public string BookEmail { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}