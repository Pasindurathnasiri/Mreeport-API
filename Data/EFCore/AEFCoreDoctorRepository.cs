using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Models;

namespace MReportAPI.Data.EFCore
{
    public class AEFCoreDoctorRepository : AEFCoreRepository<Doctor, MReportAPIContext>
    {
        public AEFCoreDoctorRepository(MReportAPIContext Acontext) : base(Acontext)
        {
            
        }

        
    }
}
