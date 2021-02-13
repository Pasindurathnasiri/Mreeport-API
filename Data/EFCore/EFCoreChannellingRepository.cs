using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MReportAPI.Models;

namespace MReportAPI.Data.EFCore
{
    public class EFCoreChannellingRepository : EFCoreRepository<Channelling, MReportAPIContext>
    {
        public EFCoreChannellingRepository(MReportAPIContext context) : base(context)
        {

        }

    }
}
