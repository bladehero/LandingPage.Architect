using System.Web.Mvc;

namespace DiplomaLandingPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact(string name, string email, string message)
        {
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
    }
}
