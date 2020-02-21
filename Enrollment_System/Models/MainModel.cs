using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enrollment_System.Models
{
    public class MainModel
    {
    }
    public class Enrollment_Registration
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
        public string EntryYear { get; set; }
        public string MobileNumber { get; set; }
        public string BirthDate { get; set; }
        public string Grade { get; set; }
        public string Location { get; set; }
        public string StatusForm { get; set; }
        public string StudentStatus { get; set; }

        public List<Enrollment_Registration> PopulatealLRecords { get; set; }


    }
}