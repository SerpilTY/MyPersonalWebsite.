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
        public ActionResult HomePageDetails(int id)
        {
            var hpdetails = c.HomePages.Find(id);
            return View("HomePageDetails", hpdetails);
        }

        public ActionResult UpdateHomePage(HomePage x) {
            var hpdetails = c.HomePages.Find(x.Id);
            hpdetails.UserName = x.UserName;
            hpdetails.Title = x.Title;
            hpdetails.Description = x.Description;
            hpdetails.Contact = x.Contact;
            hpdetails.Profile = x.Profile;
            c.SaveChanges();
            return RedirectToAction("Index"); 
        
        }
        public ActionResult IconsList()
        {
            var value = c.GetIcons.ToList();
            return View(value);
        }
    }
}