using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.Models
{
    public class EPortal_PatientProfile
    {
        [Display(Name = "Patient id")]
        public int PatientId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Birth date")]
        public System.DateTime? BirthDate { get; set; }
        
        
        public string Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int Age = now.Year - BirthDate.Value.Year;
                if (BirthDate > now.AddYears(-Age)) Age--;
                return Convert.ToString(Age);
            }
        }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Contact number")]
        public int ContactNumber { get; set; }

        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }
    }
}