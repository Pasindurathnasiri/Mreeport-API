using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Data;

namespace MReportAPI.Models
{
    public class Channelling:IEntity
    {
        public int Id { get; set; }
        public string RefNo { get; set; }

        public string PatientRegNo { get; set; }
        public string DoctorRegNo { get; set; }
        public string HospitalRegNo { get; set; }

    }
}
