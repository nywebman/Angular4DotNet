using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angular4DotNet.Models.Registration;

namespace Angular4DotNet.Controllers
{
    public class InstructorsController : Controller
    {
        private RegistrationVmBuilder _regisBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return View("Index", "", _regisBuilder.GetSerializedInstructors());
        }

    }
}
