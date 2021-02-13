using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Data;

namespace MReportAPI.Models
{
    public class Report :IEntity
    {
        public int Id { get; set; }
        public string ReportNo { get; set; }
        public string ReportType { get; set; }
        public string DocRegNo { get; set; }
        public string PatientRegNo { get; set; }
        public string ImgLink { get; set; }
        public string ImgLink2 { get; set; }

    }
}
