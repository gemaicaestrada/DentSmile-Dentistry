using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;


namespace DataLibrary.BusinessLogic
{
    public class PatientProfileProcessor
    {
        public static int CreatePatientProfile(int patientId, string firstName, string lastName,
            System.DateTime? birthDate, string address, int contactNumber, string emailAddress)
        {
            PatientProfile PatientData = new PatientProfile
            {
                PatientId = patientId,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                Address = address,
                ContactNumber = contactNumber,
                EmailAddress = emailAddress
            };

            string sql = @"insert into dbo.PatientProfile (PatientId, FirstName, LastName, BirthDate, Address, ContactNumber, EmailAddress)
                            values(@PatientId, @FirstName, @LastName, @BirthDate, @Address, @ContactNumber, @EmailAddress);";

            return SqlDataAccess.SaveData(sql, PatientData);
        }

            public static List<PatientProfile> LoadPatientProfile()
            {
                string sql = "select PatientId, FirstName, LastName, BirthDate, Address, ContactNumber, EmailAddress " +
                "from dbo.PatientProfile;";
                return SqlDataAccess.LoadData<PatientProfile>(sql);
            }  
    }
}
