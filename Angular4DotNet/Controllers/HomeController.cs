using System.Web.Mvc;

namespace Angular4DotNet.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            Response.Redirect(@"/Registration");
        }

    }
}
