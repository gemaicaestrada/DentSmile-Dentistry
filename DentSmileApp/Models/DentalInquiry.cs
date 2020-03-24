using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DentSmileApp.Models
{
    public class DentalInquiry
    {
        [Display(Name = "First Name: ")]
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name: ")]
        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }

        [Display(Name = "Contact Number: ")]
        [Required(ErrorMessage = "Please enter a valid contact number.")]
        [DataType(DataType.PhoneNumber)]
        public int ContactNumber { get; set; }

        [Display(Name = "Email Address: ")]
        [Required(ErrorMessage = "Please enter a valid email address.")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Display(Name = "Subject: ")]
        [Required(ErrorMessage = "Please write your subject.")]
        public string SubjectMessage { get; set; }

        [Display(Name = "Message: ")]
        [Required(ErrorMessage ="Please write your message.")]
        public string BodyMessage { get; set; }
    }
}