using GeyikCafe.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeyikCafe.Entities;

namespace GeyikCafe.Controllers
{
    public class DefaultController : Controller
    {
        GeyikCafeContext db =new GeyikCafeContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar () 
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var degerler = db.Features.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult PartialService()
        {
            var degerler=db.Services.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult PartialAbout()
        {
            var degerler = db.Abouts.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult PartialMenu()
        {
            var degerlerMenu=db.Menus.ToList();
            var degerlerMenuCategory = db.MenuCategories.ToList();
            var model = new Tuple<List<Menu>, List<MenuCategory>>(degerlerMenu, degerlerMenuCategory);
            return PartialView(model);
        }

        public PartialViewResult PartialReservation()
        {
            var degerler=db.Reservations.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult PartialTeam()
        {
            return PartialView();
        }

        public PartialViewResult PartialTestimonial() 
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        
        public PartialViewResult PartialJavaScript()
        {
            return PartialView();
        }
    }
}