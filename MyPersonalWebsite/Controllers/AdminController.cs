﻿using MyPersonalWebsite.Models.Classes;
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
        [Authorize]
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
        [HttpGet] public ActionResult NewIcon() {
        return View();
        }
        [HttpPost] public ActionResult NewIcon(Icons i)
        {
            c.GetIcons.Add(i);
            c.SaveChanges();
            return RedirectToAction("IconsList");
        }

        public ActionResult IconDetails(int id)
        {
            var icondetails = c.GetIcons.Find(id);
            return View("IconDetails", icondetails);
        }

        public ActionResult UpdateIcons(Icons x)
        {
            var iconsdetails = c.GetIcons.Find(x.Id);
            iconsdetails.IconName = x.IconName;
            iconsdetails.Link = x.Link;
            c.SaveChanges();
            return RedirectToAction("IconsList");

        }
        public ActionResult DeleteIcon(int id)
        {
            var icon = c.GetIcons.Find(id);
            c.GetIcons.Remove(icon);
            c.SaveChanges();
            return RedirectToAction("IconsList");
        }
        
    }
}