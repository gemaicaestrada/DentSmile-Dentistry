using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.Models
{
    public class EPortal_DentalInquiry
    {
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Contact Number")]
        public int ContactNumber { get; set; }

        [Display(Name = "Email Adress")]
        public string EmailAddress { get; set; }

        [Display(Name = "Subject")]
        public string SubjectMessage { get; set; }

        [Display(Name = "Message")]
        public string BodyMessage { get; set; }
    }
}