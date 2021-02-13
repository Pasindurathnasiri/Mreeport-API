using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Models;

namespace MReportAPI.Data.EFCore
{
    public class EFCoreVaccineRepository : EFCoreRepository<Vaccine, MReportAPIContext>
    {
        public EFCoreVaccineRepository(MReportAPIContext context) : base(context)
        {

        }
    }
}
