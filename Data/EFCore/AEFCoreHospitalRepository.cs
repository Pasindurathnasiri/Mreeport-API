using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Models;

namespace MReportAPI.Data.EFCore
{
    public class AEFCoreHospitalRepository : HAEFCoreRepository<Hospital, MReportAPIContext>
    {
        public AEFCoreHospitalRepository(MReportAPIContext HAcontext) : base(HAcontext)
        {

        }
    }
}
