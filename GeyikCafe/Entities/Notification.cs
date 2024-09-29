using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeyikCafe.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsRead { get; set; }

    }
}