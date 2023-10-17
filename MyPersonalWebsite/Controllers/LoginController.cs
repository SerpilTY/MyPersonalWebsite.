using MyPersonalWebsite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyPersonalWebsite.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin IsAdmin) {
        var info=c.Admins.FirstOrDefault(x=>x.UserName==IsAdmin.UserName && x.Password==IsAdmin.Password);
            if(info != null)
            {
                FormsAuthentication.SetAuthCookie(info.UserName, false);
                Session["UserName"] = info.UserName.ToString();
                return RedirectToAction("Index","Admin");
            }else { return View(); }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}