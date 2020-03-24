using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentSmileApp.Models;
using DataLibrary;
using DataLibrary.DataAccess;
using static DataLibrary.DataAccess.SqlDataAccess1;
using DataLibrary.BusinessLogic;
using static DataLibrary.BusinessLogic.PatientProfileProcessor;
using static DataLibrary.BusinessLogic.OnlineInquiryProcessor1;



namespace EmployeePortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult PatientsRecords()
        {
            ViewBag.Message = "List of Patients Registered Online";
            var PatientInfo = LoadPatientProfile();
            List<Models.EPortal_PatientProfile> ViewPatientProfile = new List<Models.EPortal_PatientProfile>();

            foreach (var row in PatientInfo)
            {
                ViewPatientProfile.Add(new Models.EPortal_PatientProfile
                {
                    PatientId = row.PatientId,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    BirthDate = row.BirthDate,
                    Address = row.Address,
                    ContactNumber = row.ContactNumber,
                    EmailAddress = row.EmailAddress
                });

            }
            return View(ViewPatientProfile);
        }

        public ActionResult OnlineDentalInquiry()
        {
            ViewBag.Message = "List of Patients Registered Online";
            var DentalInquiryInfo = LoadDentalInquiry();
            List<Models.EPortal_DentalInquiry> ViewOnlineDentalInquiry = new List<Models.EPortal_DentalInquiry>();

            foreach (var row in DentalInquiryInfo)
            {
                ViewOnlineDentalInquiry.Add(new Models.EPortal_DentalInquiry
                {
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    ContactNumber = row.ContactNumber,
                    EmailAddress = row.EmailAddress,
                    SubjectMessage = row.SubjectMessage,
                    BodyMessage = row.BodyMessage
                });
            }
            return View(ViewOnlineDentalInquiry);
        }

























        //public ActionResult PatientsRecord()
        //{
        //    ViewBag.Message = "List of Patients Registered Online";
        //    //var data = new Proc();
        //    var data = Proc.LoadPatientProfile();
        //    List<DentSmileApp.Models.PatientProfile> PatientProfile = new List<DentSmileApp.Models.PatientProfile>();

        //    foreach (var row in data)
        //    {
        //        PatientProfile.Add(new DentSmileApp.Models.PatientProfile
        //        {
        //            PatientId = row.PatientId,
        //            FirstName = row.FirstName,
        //            LastName = row.LastName,
        //            BirthDate = row.BirthDate,
        //            Address = row.Address,
        //            ContactNumber = row.ContactNumber,
        //            EmailAddress = row.EmailAddress
        //        });

        //    }

        //    return View(PatientProfile.ToList());
        //}




        public ActionResult InquiryList()
        {
            ViewBag.Message = "List of Dental Inquiries";

            return View();
        }
    }
}