using System.Web.Mvc;

namespace githubtest.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetDetails()
        {
            return View();
        }
    }
}