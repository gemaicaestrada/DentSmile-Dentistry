using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentSmileApp.Models;
using DataLibrary;
using DataLibrary.BusinessLogic;
using static DataLibrary.BusinessLogic.PatientProfileProcessor;
using static DataLibrary.BusinessLogic.OnlineInquiryProcessor1;




namespace DentSmileApp.Controllers
{
    public class HomeController : Controller
    {
        //Index or Home
        [Route("Home")]
        public ActionResult Index()
        {
            return View();
        }

        //New Patient section
        [Route("AddNewPatient")]
        public ActionResult NewPatient()
        {
            return View();
        }


        //Add New Patient Action - returning
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewPatient(PatientProfile model)
        {
            if(ModelState.IsValid)
            {
                int recordsCreated = CreatePatientProfile(model.PatientId, 
                model.FirstName, 
                model.LastName,
                model.BirthDate, 
                model.Address, 
                model.ContactNumber, 
                model.EmailAddress);
                return View("Index");
            }
            return View();
        }

        //Dental Inquiry
        public ActionResult DentalOnlineInquiry()
        {
            ViewBag.Message = "Please enter your inquiry below";

            return View();
        }

        // Dental Inquiry - returning
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DentalOnlineInquiry(DentalInquiry model)
        {
            if (ModelState.IsValid)
            {
                int inquiryCreated = CreateOnlineInquiry(model.FirstName,
                    model.LastName,
                    model.ContactNumber,
                    model.EmailAddress,
                    model.SubjectMessage,
                    model.BodyMessage);

                return View("Index");

            }

            return View();
        }


        //Office information
        [Route("officeinformation")]
        public ActionResult officeinformation()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Contact Section
        public ActionResult TreatmentPlans()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
    }
}