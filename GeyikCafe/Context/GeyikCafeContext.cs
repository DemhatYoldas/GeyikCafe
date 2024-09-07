using GeyikCafe.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeyikCafe.Context
{
    public class GeyikCafeContext:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<MailSubscribe> MailSubscribes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}