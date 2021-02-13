using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Data;

namespace MReportAPI.Models
{
    public class Vaccine : IEntity
    {
        public int Id { get; set; }
        public string VaccineNo { get; set; }
        public string VaccineName { get; set; }
        public string BatchNo { get; set; }
        public string MFDate { get; set; }
        public string EXPDate { get; set; }
        public string Manufacturer { get; set; }
        public string NoOfUnits { get; set; }
        public string UnitPrice { get; set; }
    }
}