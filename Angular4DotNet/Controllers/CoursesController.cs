using System.Web.Mvc;
using Angular4DotNet.Models.Registration;

namespace Angular4DotNet.Controllers
{
    public class CoursesController : Controller
    {
        private RegistrationVmBuilder _regisBuilder=new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return View("Index", "", _regisBuilder.GetSerializedCourses());
        }
    }
}
