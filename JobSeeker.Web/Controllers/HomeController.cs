using System.Web.Mvc;

namespace JobSeeker.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //[Authorize(Roles = "ADMIN")]
        //public ActionResult Users()
        //{
        //    ViewBag.Title = "Home Page";

        //    return View();
        //}
    }
}
