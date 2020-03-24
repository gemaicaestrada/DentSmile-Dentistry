using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class DentalInquiry
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string SubjectMessage { get; set; }
        public string BodyMessage { get; set; }
    }
}
