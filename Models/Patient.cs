using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Data;

namespace MReportAPI.Models
{
    public class Patient : IAuthEntity
    {
        public int Id { get; set; }
        public string PatientRegNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string NIC { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string GaurdianType { get; set; }
        public string GaurdianName { get; set; }
        public string GaurdianMobile { get; set; }
        public string GaurdianEmail { get; set; }
        public string District { get; set; }
        public string BloodGroup { get; set; }
        public string Condition { get; set; }
        public string ImgPath { get; set; }

    }
}
