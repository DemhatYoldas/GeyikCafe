using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeyikCafe.Controllers
{
    public class DefaultController : Controller
    {
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
            return PartialView();
        }

        public PartialViewResult PartialService()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }

        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }

        public PartialViewResult PartialReservation()
        {
            return PartialView();
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