using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternalEmployeeApp.Controllers
{
    public class InteralController : Controller
    {
        [Route("EmployeesAnnouncements")]
        public ActionResult EmployeeAnnouncements()
        {
            return View();
        }

        [Route("PatientsInquiryData")]
        public ActionResult PatientsInquiry()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("PatientsRecord")]
        public ActionResult PatientsRecord()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}