using System.Web.Mvc;

namespace Chartex.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Help");
        }
    }
}
