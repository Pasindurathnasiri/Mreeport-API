using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Data;

namespace MReportAPI.Models
{
    public class Hospital : IHAuthEntity
    {
        public int Id { get; set; }
        public string HosRegNo { get; set; }
        public string HospitalName { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string OwnerNIC { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
        public string OwnerName { get; set; }
        public string OwnerMobile { get; set; }
        public string ImgPath { get; set; }
    }
}
