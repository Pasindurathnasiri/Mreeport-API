using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Models;

namespace MReportAPI.Data.EFCore
{
    public class EFCoreReportRepository : EFCoreRepository<Report, MReportAPIContext>
    {
        public EFCoreReportRepository(MReportAPIContext context) : base(context)
        {

        }
    }
}
