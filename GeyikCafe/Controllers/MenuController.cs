using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeyikCafe.Entities;
using GeyikCafe.Context;

namespace GeyikCafe.Controllers
{
    public class MenuController : Controller
    {
        GeyikCafeContext db = new GeyikCafeContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult MenuHeaderPartial()
        {
            return PartialView();
        }
    }
}