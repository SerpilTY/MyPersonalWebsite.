using MyPersonalWebsite.Models.Classes;
using System.Linq;
using System.Web.Mvc;

namespace MyPersonalWebsite.Controllers
{
    public class HomePageController : Controller
    {
        //GET: HomePage
       Context c = new Context();
        public ActionResult Index()
        {
            var value = c.HomePages.ToList();
            return View(value);
        }
        public PartialViewResult Icons()
        {
            var value = c.GetIcons.ToList();
            return PartialView(value);
          
        }
    }
}