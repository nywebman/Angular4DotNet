using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class CoursesController : Controller
    {
        //
        // GET: /Courses/

        public ActionResult Index()
        {
            return View("Index", "", "you");
        }

    }
}
