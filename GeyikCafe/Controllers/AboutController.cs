using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeyikCafe.Entities;
using GeyikCafe.Context;

namespace GeyikCafe.Controllers
{
    public class AboutController : Controller
    {
        GeyikCafeContext db = new GeyikCafeContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult AboutHeaderPartial()
        {
            return PartialView();
        }
    }
}