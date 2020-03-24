using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DentSmileApp.Models
{
    public class PatientProfile
    {
        [Display(Name ="Patient id:")]
        [Range(001,999, ErrorMessage ="Please enter a valid number")]
        public int PatientId { get; set; }

        [Display(Name = "First Name:")]
        [Required(ErrorMessage ="Please enter your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage ="Please enter your last name.")]
        public string LastName { get; set; }

        [Display(Name = "Birth date:")]
        [Required(ErrorMessage ="Please enter your birthdate.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        public System.DateTime? BirthDate { get; set; }


        [Display(Name = "Age")]
        public string age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - BirthDate.Value.Year;
                if (BirthDate > now.AddYears(-age)) age--;
                return Convert.ToString(age);
            }
        }

        [Display(Name = "Address:")]
        public string Address { get; set; }

        [Display(Name = "Contact number:")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage ="Please enter your valid contact number.")]
        public int ContactNumber { get; set; }


        [Display(Name = "Email address:")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Please enter a valid email Address.")]
        public string EmailAddress { get; set; }
        
    }
}