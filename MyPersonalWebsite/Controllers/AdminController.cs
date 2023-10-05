using MyPersonalWebsite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MyPersonalWebsite.Controllers
{
    
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.HomePages.ToList();
            return View(value);
        }
    }
}