using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeyikCafe.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime SendDate { get; set; }
        public string People { get; set; }
        public string Message { get; set; }
        public bool  IsRead { get; set; }
        public string VideUrl { get; set; }
    }
}