using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNet.Controllers
{
    public class CoursesController : Controller
    {
        //
        // GET: /Courses/

        public ActionResult Index()
        {
            return View("Index", "", GetSerializedCourseVM());
        }

        public string GetSerializedCourseVM()
        {
            var courses = new[]
            {
                new CourseVm {Number = "CREA101", Name = "care of Creatures", Instructor = "r hagrid"},
                new CourseVm {Number = "DARK502", Name = "defence of dark arts", Instructor = "Snape"},
                new CourseVm {Number = "TRAN201", Name = "Transfiguration", Instructor = "Mcconagal"}
            };
            var settings = new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()}; 
            return JsonConvert.SerializeObject(courses, Formatting.None, settings);
        }

    }

    public class CourseVm
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
    }
}
