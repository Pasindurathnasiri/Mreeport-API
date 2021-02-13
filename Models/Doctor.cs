using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Data;

namespace MReportAPI.Models
{
    public class Doctor : IAuthEntity
    {
        public int Id { get; set; }
        public string MedRegNo { get; set; }
        public string FirstName { get; set; }
        public DateTime DOB { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string MaritalState { get; set; }
        public string Address { get; set; }
        public string SpArea { get; set; }
        public string NIC { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string ImgPath { get; set; }

    }
}
