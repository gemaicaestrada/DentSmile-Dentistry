using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;
using DataLibrary;



namespace DataLibrary.BusinessLogic
{
    public class OnlineInquiryProcessor1
    {
        //create online inquiry
        public static int CreateOnlineInquiry(string firstName, string lastName, int contactNumber,
            string emailAddress, string subjectMessage, string bodyMessage)
        {
            Models.DentalInquiry DentalInquiryData = new DentalInquiry
            {
                FirstName = firstName,
                LastName = lastName,
                ContactNumber = contactNumber,
                EmailAddress = emailAddress,
                SubjectMessage = subjectMessage,
                BodyMessage = bodyMessage
            };

            string sql1 = @"insert into dbo.DentalInqury (FirstName, LastName, ContactNumber, EmailAddress, SubjectMessage, BodyMessage)
            values (@FirstName, @LastName, @ContactNumber, @EmailAddress, @SubjectMessage, @BodyMessage);";

            return SqlDataAccess1.SaveData(sql1, DentalInquiryData);
        }

        //load data
        public static List<DentalInquiry> LoadDentalInquiry()
        {
            string sql2 = @"select FirstName, LastName, ContactNumber, EmailAddress," +
            "SubjectMessage, BodyMessage from dbo.DentalInqury;";

            return SqlDataAccess1.LoadData<DentalInquiry>(sql2);
        }
    }
}
