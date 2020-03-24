using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class PatientProfile
    {

        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
