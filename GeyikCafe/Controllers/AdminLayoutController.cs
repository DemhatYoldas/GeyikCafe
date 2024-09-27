using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeyikCafe.Context;

namespace GeyikCafe.Controllers
{
    public class AdminLayoutController : Controller
    {
        GeyikCafeContext db=new GeyikCafeContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialNotification() 
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
       

        public PartialViewResult PartialLogo()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialJS()
        {
            return PartialView();
        }
    }
}