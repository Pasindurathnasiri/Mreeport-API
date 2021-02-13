using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Models;

namespace MReportAPI.Data.EFCore
{
    public class EFCorePatientRepository : AEFCoreRepository<Patient, MReportAPIContext>
    {
        public EFCorePatientRepository(MReportAPIContext Acontext) : base(Acontext)
        {

        }
    }

}
